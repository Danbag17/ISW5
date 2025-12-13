namespace ManteHosGUI
{
    public partial class CerrarOrdenTrabajo : Form
    {
        // Usamos el tipo concreto para acceder a GetOpenWorkOrdersForOperator
        private readonly ManteHosService concreteService;
        private readonly Operator loggedOp;
        private WorkOrder selectedOrder;

        public CerrarOrdenTrabajo(IManteHosService service)
        {
            InitializeComponent();

            this.concreteService = service as ManteHosService;
            if (this.concreteService == null)
            {
                MessageBox.Show("Error de configuración de servicio.", "Error Fatal");
                this.Close();
                return;
            }

            this.loggedOp = service.UserLogged() as Operator;
            if (this.loggedOp == null)
            {
                MessageBox.Show("Acceso denegado: debe ser un Operario.", "Error de Rol");
                this.Close();
                return;
            }

            dtpFechaCierre.Value = DateTime.Now;

            LoadWorkOrders();
            this.Text = "Cerrar Orden de Trabajo";
        }

        private void LoadWorkOrders()
        {
            List<WorkOrder> orders = concreteService.GetOpenWorkOrdersForOperator(loggedOp);

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

            txtDescripcion.Text = selectedOrder.Incident.Description;
            lblFechaInicio.Text = selectedOrder.StartDate.ToString("g");

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

            float totalCost = selectedOrder.UsedParts.Sum(
                up => up.Part.UnitPrice * up.Quantity);

            lblCoste.Text = $"{totalCost:C2}";

        }
        private void dfvOrdenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow selectedRow = dfvOrdenes.Rows[e.RowIndex];

            if (selectedRow.Cells["Id"].Value == null) return;

            int id = (int)selectedRow.Cells["Id"].Value;

            try
            {
                selectedOrder = concreteService
                   .GetOpenWorkOrdersForOperator(loggedOp)
                   .First(wo => wo.Id == id);

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

            string report = txtInforme.Text.Trim();

            DateTime endDate = dtpFechaCierre.Value;

            try
            {
                concreteService.CloseWorkOrder(selectedOrder, report, endDate);

                MessageBox.Show("Orden cerrada y completada correctamente.", "Éxito");
                this.Close();
            }
            catch (ServiceException ex)
            {
                MessageBox.Show(ex.Message, "Error al Cerrar Orden", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CerrarOrdenTrabajo_Load(object sender, EventArgs e) { }
        private void txtInforme_TextChanged(object sender, EventArgs e) { }
        private void dtpFechaCierre_ValueChanged(object sender, EventArgs e) { }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            concreteService.Logout();
            this.Close();
        }
    }
}
