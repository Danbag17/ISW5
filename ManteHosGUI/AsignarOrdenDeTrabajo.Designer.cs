namespace ManteHosGUI
{
    partial class AsignarOrdenDeTrabajo
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ListBox lbAvailableOperators;
        private System.Windows.Forms.ListBox lbAssignedOperators;
        private System.Windows.Forms.Button btnAddOperator;
        private System.Windows.Forms.Button btnRemoveOperator;
        private System.Windows.Forms.Button btnCreateWorkOrder;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lbAvailableOperators = new System.Windows.Forms.ListBox();
            this.lbAssignedOperators = new System.Windows.Forms.ListBox();
            this.btnAddOperator = new System.Windows.Forms.Button();
            this.btnRemoveOperator = new System.Windows.Forms.Button();
            this.btnCreateWorkOrder = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.SuspendLayout();

            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 9);
            this.lblDescription.Text = "Descripción";

            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(12, 30);
            this.lblDepartment.Text = "Departamento";

            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(12, 51);
            this.lblArea.Text = "Área";

            this.lbAvailableOperators.Location = new System.Drawing.Point(15, 80);
            this.lbAvailableOperators.Size = new System.Drawing.Size(200, 160);

            this.lbAssignedOperators.Location = new System.Drawing.Point(330, 80);
            this.lbAssignedOperators.Size = new System.Drawing.Size(200, 160);

            this.btnAddOperator.Location = new System.Drawing.Point(230, 110);
            this.btnAddOperator.Text = ">>";
            this.btnAddOperator.Click += new System.EventHandler(this.btnAddOperator_Click);

            this.btnRemoveOperator.Location = new System.Drawing.Point(230, 150);
            this.btnRemoveOperator.Text = "<<";
            this.btnRemoveOperator.Click += new System.EventHandler(this.btnRemoveOperator_Click);

            this.btnCreateWorkOrder.Location = new System.Drawing.Point(330, 260);
            this.btnCreateWorkOrder.Text = "Crear Orden";
            this.btnCreateWorkOrder.Click += new System.EventHandler(this.btnCreateWorkOrder_Click);

            this.btnCancel.Location = new System.Drawing.Point(420, 260);
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.ClientSize = new System.Drawing.Size(560, 310);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lbAvailableOperators);
            this.Controls.Add(this.lbAssignedOperators);
            this.Controls.Add(this.btnAddOperator);
            this.Controls.Add(this.btnRemoveOperator);
            this.Controls.Add(this.btnCreateWorkOrder);
            this.Controls.Add(this.btnCancel);

            this.Text = "Asignar Orden de Trabajo";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
