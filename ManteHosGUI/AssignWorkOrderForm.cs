using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ManteHos.Services;
using ManteHos.Entities;

namespace ManteHosGUI
{
    public partial class AssignWorkOrderForm : Form
    {
        private readonly IManteHosService service;
        private readonly Incident incident;

        private List<Operator> availableOperators;
        private List<Operator> assignedOperators;

        public AssignWorkOrderForm(IManteHosService service, Incident incident)
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
            availableOperators = service.GetOperatorsForIncident(incident).ToList();
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
                var wo = service.AssignWorkOrder(incident, assignedOperators);

                MessageBox.Show(
                    $"Orden de trabajo {wo.Id} creada correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

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
