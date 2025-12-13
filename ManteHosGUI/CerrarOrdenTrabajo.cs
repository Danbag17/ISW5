using ManteHos.Services;
using ManteHos.Entities;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ManteHosGUI
{
    public partial class CerrarOrdenTrabajo : ManteHosFormBase
    {
        // Usamos el tipo concreto para acceder al método auxiliar GetOpenWorkOrdersForOperator
        private readonly ManteHosService concreteService;
        private readonly IManteHosService service;
        private readonly Operator loggedOp;
        private WorkOrder selectedOrder;

        public CerrarOrdenTrabajo(IManteHosService s)
        {
            InitializeComponent();
            this.service = s;

            // CU Paso 2: El sistema busca las ordenes de trabajo asignadas al operario
            // Realizamos el casting obligatorio
            this.concreteService = s as ManteHosService;

            if (this.concreteService == null)
            {
                MessageBox.Show("Error de configuración: Se requiere la implementación ManteHosService.", "Error Fatal");
                this.Close();
                return;
            }

            // Obtenemos el usuario logueado (asumimos que es un Operator válido por premisa)
            this.loggedOp = service.UserLogged() as Operator;

            if (this.loggedOp == null)
            {
                MessageBox.Show("Error de Rol: El usuario logueado no tiene el rol de Operario.", "Error de Acceso");
                this.Close();
                return;
            }

            dtpFechaCierre.Value = DateTime.Now;
            LoadWorkOrders();
            this.Text = "Cerrar Orden de Trabajo";
        }

        private void LoadWorkOrders()
        {
            // Llamada al método auxiliar a través del servicio concreto (Muestra las órdenes pendientes)
            List<WorkOrder> orders = concreteService.GetOpenWorkOrdersForOperator(loggedOp);

            // dfvOrdenes es el DataGridView del Designer
            dfvOrdenes.DataSource = orders
                .Select(wo => new {
                    wo.Id,
                    Incidencia = wo.Incident.Description,
                    Inicio = wo.StartDate
                })
                .ToList();

            if (!orders.Any())
            {
                ClearOrderDetails();
                MessageBox.Show("No tienes órdenes de trabajo pendientes de cerrar.");
            }
        }

        private void ClearOrderDetails()
        {
            txtDescripcion.Text = "";
            lblFechaInicio.Text = "";
            lblCoste.Text = "";
            dgvPiezasUsadas.DataSource = null;
            txtInforme.Text = "";
            selectedOrder = null;
        }

        private void LoadOrderDetails()
        {
            if (selectedOrder == null)
            {
                ClearOrderDetails();
                return;
            }

            // CU Paso 4: El sistema muestra la información de la orden, piezas y coste
            txtDescripcion.Text = selectedOrder.Incident.Description;
            lblFechaInicio.Text = selectedOrder.StartDate.ToString("g");

            // Carga de Piezas Usadas (dgvPiezasUsadas)
            dgvPiezasUsadas.DataSource = selectedOrder.UsedParts
                .Select(up => new
                {
                    Pieza = up.Part.Description,
                    up.Quantity,
                    Precio = up.Part.UnitPrice,
                    Total = up.Part.UnitPrice * up.Quantity,
                    Necesaria = up.Needed
                })
                .ToList();

            // Cálculo y Carga del Coste Total
            float totalCost = selectedOrder.UsedParts.Sum(
                up => up.Part.UnitPrice * up.Quantity);

            lblCoste.Text = $"{totalCost:C2}";
        }

        private void dfvOrdenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dfvOrdenes.Rows.Count) return;
            if (dfvOrdenes.CurrentRow == null) return;

            // CU Paso 3: El operario escoge una de las órdenes
            int id = (int)dfvOrdenes.CurrentRow.Cells["Id"].Value;

            try
            {
                // Volvemos a obtener la lista y filtramos
                List<WorkOrder> allOrders = concreteService.GetOpenWorkOrdersForOperator(loggedOp);
                selectedOrder = allOrders.First(wo => wo.Id == id);

                LoadOrderDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar detalles de la orden: " + ex.Message);
            }
        }

        private void btnCerrarOrden_Click(object sender, EventArgs e)
        {
            if (selectedOrder == null)
            {
                MessageBox.Show("Debe seleccionar una orden antes de cerrarla.");
                return;
            }

            // CU Paso 5: relata trabajo y fecha
            string report = txtInforme.Text.Trim();
            DateTime endDate = dtpFechaCierre.Value;

            try
            {
                // CU Paso 6 y Extensiones Síncronas (validación de piezas)
                concreteService.CloseWorkOrder(selectedOrder, report, endDate);

                MessageBox.Show("Orden cerrada y completada correctamente.", "Éxito");
                this.Close();
            }
            catch (ServiceException ex)
            {
                // Si falla (ej. piezas pendientes), el formulario permanece abierto (continúa en paso 3)
                MessageBox.Show(ex.Message, "Error al Cerrar Orden", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Eventos vacíos del Designer
        private void CerrarOrdenTrabajo_Load(object sender, EventArgs e) { }
        private void txtInforme_TextChanged(object sender, EventArgs e) { }
        private void dtpFechaCierre_ValueChanged(object sender, EventArgs e) { }
    }
}