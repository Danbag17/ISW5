namespace ManteHosGUI
{
    partial class RevisarIncidencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDescripción = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.labelDept = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.labelPriori = new System.Windows.Forms.Label();
            this.lblPriori = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvIncidencias = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.lblReportado = new System.Windows.Forms.Label();
            this.labelReporte = new System.Windows.Forms.Label();
            this.panelDecision = new System.Windows.Forms.Panel();
            this.labelMotivoRechazo = new System.Windows.Forms.Label();
            this.txtMotivoRechazo = new System.Windows.Forms.TextBox();
            this.rbAceptar = new System.Windows.Forms.RadioButton();
            this.rbRechazar = new System.Windows.Forms.RadioButton();
            this.cbPrioridad = new System.Windows.Forms.ComboBox();
            this.labelPrio2 = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidencias)).BeginInit();
            this.panelDatos.SuspendLayout();
            this.panelDecision.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDescripción
            // 
            this.labelDescripción.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripción.Location = new System.Drawing.Point(10, 10);
            this.labelDescripción.Name = "labelDescripción";
            this.labelDescripción.Size = new System.Drawing.Size(103, 23);
            this.labelDescripción.TabIndex = 0;
            this.labelDescripción.Text = "Descripción:";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(10, 168);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(48, 16);
            this.labelFecha.TabIndex = 2;
            this.labelFecha.Text = "Fecha:";
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(68, 168);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(77, 16);
            this.lblFecha.TabIndex = 3;
            // 
            // labelDept
            // 
            this.labelDept.Location = new System.Drawing.Point(10, 241);
            this.labelDept.Name = "labelDept";
            this.labelDept.Size = new System.Drawing.Size(100, 23);
            this.labelDept.TabIndex = 4;
            this.labelDept.Text = "Departamento:";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(119, 241);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(0, 16);
            this.lblDept.TabIndex = 5;
            // 
            // labelPriori
            // 
            this.labelPriori.AutoSize = true;
            this.labelPriori.Location = new System.Drawing.Point(10, 393);
            this.labelPriori.Name = "labelPriori";
            this.labelPriori.Size = new System.Drawing.Size(65, 16);
            this.labelPriori.TabIndex = 6;
            this.labelPriori.Text = "Prioridad:";
            // 
            // lblPriori
            // 
            this.lblPriori.AutoSize = true;
            this.lblPriori.Location = new System.Drawing.Point(88, 393);
            this.lblPriori.Name = "lblPriori";
            this.lblPriori.Size = new System.Drawing.Size(0, 16);
            this.lblPriori.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Location = new System.Drawing.Point(10, 38);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(245, 100);
            this.txtDescripcion.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvIncidencias);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 461);
            this.panel1.TabIndex = 1;
            // 
            // dgvIncidencias
            // 
            this.dgvIncidencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIncidencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncidencias.Location = new System.Drawing.Point(10, 40);
            this.dgvIncidencias.MultiSelect = false;
            this.dgvIncidencias.Name = "dgvIncidencias";
            this.dgvIncidencias.ReadOnly = true;
            this.dgvIncidencias.RowHeadersWidth = 51;
            this.dgvIncidencias.RowTemplate.Height = 24;
            this.dgvIncidencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIncidencias.Size = new System.Drawing.Size(230, 400);
            this.dgvIncidencias.TabIndex = 1;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Incidencias Pendientes:";
            // 
            // panelDatos
            // 
            this.panelDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDatos.Controls.Add(this.lblReportado);
            this.panelDatos.Controls.Add(this.labelReporte);
            this.panelDatos.Controls.Add(this.lblPriori);
            this.panelDatos.Controls.Add(this.labelDescripción);
            this.panelDatos.Controls.Add(this.labelPriori);
            this.panelDatos.Controls.Add(this.txtDescripcion);
            this.panelDatos.Controls.Add(this.labelDept);
            this.panelDatos.Controls.Add(this.lblDept);
            this.panelDatos.Controls.Add(this.lblFecha);
            this.panelDatos.Controls.Add(this.labelFecha);
            this.panelDatos.Location = new System.Drawing.Point(309, 30);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(265, 461);
            this.panelDatos.TabIndex = 2;
          
            // 
            // lblReportado
            // 
            this.lblReportado.AutoSize = true;
            this.lblReportado.Location = new System.Drawing.Point(115, 316);
            this.lblReportado.Name = "lblReportado";
            this.lblReportado.Size = new System.Drawing.Size(0, 16);
            this.lblReportado.TabIndex = 9;
            // 
            // labelReporte
            // 
            this.labelReporte.AutoSize = true;
            this.labelReporte.Location = new System.Drawing.Point(10, 317);
            this.labelReporte.Name = "labelReporte";
            this.labelReporte.Size = new System.Drawing.Size(98, 16);
            this.labelReporte.TabIndex = 8;
            this.labelReporte.Text = "Reportado por:";
            // 
            // panelDecision
            // 
            this.panelDecision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDecision.Controls.Add(this.labelMotivoRechazo);
            this.panelDecision.Controls.Add(this.txtMotivoRechazo);
            this.panelDecision.Controls.Add(this.rbAceptar);
            this.panelDecision.Controls.Add(this.rbRechazar);
            this.panelDecision.Controls.Add(this.cbPrioridad);
            this.panelDecision.Controls.Add(this.labelPrio2);
            this.panelDecision.Controls.Add(this.labelArea);
            this.panelDecision.Controls.Add(this.cbArea);
            this.panelDecision.Location = new System.Drawing.Point(644, 30);
            this.panelDecision.Name = "panelDecision";
            this.panelDecision.Size = new System.Drawing.Size(200, 333);
            this.panelDecision.TabIndex = 3;
            // 
            // labelMotivoRechazo
            // 
            this.labelMotivoRechazo.AutoSize = true;
            this.labelMotivoRechazo.Location = new System.Drawing.Point(20, 241);
            this.labelMotivoRechazo.Name = "labelMotivoRechazo";
            this.labelMotivoRechazo.Size = new System.Drawing.Size(101, 16);
            this.labelMotivoRechazo.TabIndex = 8;
            this.labelMotivoRechazo.Text = "Motivo rechazo:";
            // 
            // txtMotivoRechazo
            // 
            this.txtMotivoRechazo.Enabled = false;
            this.txtMotivoRechazo.Location = new System.Drawing.Point(20, 268);
            this.txtMotivoRechazo.Multiline = true;
            this.txtMotivoRechazo.Name = "txtMotivoRechazo";
            this.txtMotivoRechazo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMotivoRechazo.Size = new System.Drawing.Size(172, 45);
            this.txtMotivoRechazo.TabIndex = 7;
            // 
            // rbAceptar
            // 
            this.rbAceptar.AutoSize = true;
            this.rbAceptar.Location = new System.Drawing.Point(20, 20);
            this.rbAceptar.Name = "rbAceptar";
            this.rbAceptar.Size = new System.Drawing.Size(142, 20);
            this.rbAceptar.TabIndex = 6;
            this.rbAceptar.Text = "Aceptar incidencia:";
            this.rbAceptar.UseVisualStyleBackColor = true;
            // 
            // rbRechazar
            // 
            this.rbRechazar.AutoSize = true;
            this.rbRechazar.Location = new System.Drawing.Point(20, 208);
            this.rbRechazar.Name = "rbRechazar";
            this.rbRechazar.Size = new System.Drawing.Size(153, 20);
            this.rbRechazar.TabIndex = 5;
            this.rbRechazar.Text = "Rechazar incidencia:";
            this.rbRechazar.UseVisualStyleBackColor = true;
            
            // cbPrioridad
            // 
            this.cbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrioridad.FormattingEnabled = true;
            this.cbPrioridad.Location = new System.Drawing.Point(40, 130);
            this.cbPrioridad.Name = "cbPrioridad";
            this.cbPrioridad.Size = new System.Drawing.Size(120, 24);
            this.cbPrioridad.TabIndex = 4;
            // 
            // labelPrio2
            // 
            this.labelPrio2.AutoSize = true;
            this.labelPrio2.Location = new System.Drawing.Point(20, 110);
            this.labelPrio2.Name = "labelPrio2";
            this.labelPrio2.Size = new System.Drawing.Size(62, 16);
            this.labelPrio2.TabIndex = 3;
            this.labelPrio2.Text = "Prioridad";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(20, 60);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(39, 16);
            this.labelArea.TabIndex = 2;
            this.labelArea.Text = "Área:";
            // 
            // cbArea
            // 
            this.cbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArea.DropDownWidth = 120;
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(40, 79);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(121, 24);
            this.cbArea.TabIndex = 1;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(668, 431);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(150, 40);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // RevisarIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 503);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.panelDecision);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "RevisarIncidencia";
            this.Text = "Revisar Incidencia";
            this.Load += new System.EventHandler(this.RevisarIncidencia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidencias)).EndInit();
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.panelDecision.ResumeLayout(false);
            this.panelDecision.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelDescripción;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label labelDept;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label labelPriori;
        private System.Windows.Forms.Label lblPriori;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvIncidencias;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Label lblReportado;
        private System.Windows.Forms.Label labelReporte;
        private System.Windows.Forms.Panel panelDecision;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.RadioButton rbAceptar;
        private System.Windows.Forms.RadioButton rbRechazar;
        private System.Windows.Forms.ComboBox cbPrioridad;
        private System.Windows.Forms.Label labelPrio2;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Label labelMotivoRechazo;
        private System.Windows.Forms.TextBox txtMotivoRechazo;
        private System.Windows.Forms.Button btnConfirmar;

    }
}