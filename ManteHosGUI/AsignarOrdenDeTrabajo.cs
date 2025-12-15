using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ManteHos.Services;
using ManteHos.Entities;

namespace ManteHosGUI
{
    public partial class AsignarOrdenDeTrabajo : ManteHosFormBase
    {
       
        private readonly Incident incident;

        private List<Operator> availableOperators;
        private List<Operator> assignedOperators;

        public AsignarOrdenDeTrabajo()
        {
            InitializeComponent();
        }
        public AsignarOrdenDeTrabajo(IManteHosService service, Incident incident)
        {
            InitializeComponent();

            this.service = service;
            this.incident = incident;

            assignedOperators = new List<Operator>();

            LoadIncidentData();
            LoadOperators();
            RefreshLists();
        }

        private void LoadIncidentData()
        {
            lblDescription.Text = incident.Description;
            lblDepartment.Text = incident.Department;
            lblArea.Text = incident.Area?.Name ?? "(sin área)";
        }

        
        private void LoadOperators()
        {
            // 1. Cargar TODOS los operarios disponibles del área
            // (Asumiendo que GetOperatorsForIncident devuelve TODOS los del área)
            var allOperators = service.GetOperatorsForIncident(incident).ToList();

            // 2. Comprobar si la incidencia YA TIENE una orden
            // Necesitas un método en el servicio para traer la orden de la incidencia, ej: GetWorkOrderByIncident
            WorkOrder existingOrder = service.GetWorkOrderByIncident(incident);

            if (existingOrder != null)
            {
                // CASO EDICIÓN: La orden existe
                // Ponemos en la lista "Asignados" los que ya están en la BD
                assignedOperators = existingOrder.Operators.ToList();

                // En la lista "Disponibles" ponemos (Todos - Asignados)
                availableOperators = allOperators.Where(op => !assignedOperators.Any(ao => ao.Id == op.Id)).ToList();

                // Cambiamos el texto del botón porque ya no es "Crear", es "Guardar/Actualizar"
                btnCreateWorkOrder.Text = "Actualizar Orden";
            }
            else
            {
                // CASO CREACIÓN: No existe orden
                availableOperators = allOperators;
                assignedOperators = new List<Operator>(); // Lista vacía
            }
        }
        

        private void RefreshLists()
        {
            lbAvailableOperators.DataSource = null;
            lbAvailableOperators.DataSource = availableOperators;
            lbAvailableOperators.DisplayMember = "FullName";

            lbAssignedOperators.DataSource = null;
            lbAssignedOperators.DataSource = assignedOperators;
            lbAssignedOperators.DisplayMember = "FullName";
        }

        private void btnAddOperator_Click(object sender, EventArgs e)
        {
            var op = lbAvailableOperators.SelectedItem as Operator;
            if (op == null) return;

            availableOperators.Remove(op);
            assignedOperators.Add(op);
            RefreshLists();
        }

        private void btnRemoveOperator_Click(object sender, EventArgs e)
        {
            var op = lbAssignedOperators.SelectedItem as Operator;
            if (op == null) return;

            assignedOperators.Remove(op);
            availableOperators.Add(op);
            RefreshLists();
        }

        private void btnCreateWorkOrder_Click(object sender, EventArgs e)
        {
            if (assignedOperators.Count == 0)
            {
                MessageBox.Show("Debe asignar al menos un operario.");
                return;
            }

            try
            {
                WorkOrder ordenExistente = service.GetWorkOrderByIncident(incident);

                if (ordenExistente == null)
                {
                    // CREAR NUEVA (Lo que ya tienes)
                    service.AssignWorkOrder(incident, assignedOperators);
                }
                else
                {
                    // ACTUALIZAR EXISTENTE (Te falta este método en el servicio)
                    // Necesitas algo como: service.UpdateWorkOrderOperators(ordenExistente, assignedOperators);
                    service.UpdateWorkOrderOperators(ordenExistente, assignedOperators);
                }
                this.Close();
            }
            catch (ServiceException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
