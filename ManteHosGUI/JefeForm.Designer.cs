namespace ManteHosGUI
{
    partial class JefeForm
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
            this.lblRol = new System.Windows.Forms.Label();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.lblOpciones = new System.Windows.Forms.Label();
            this.btnReportar = new System.Windows.Forms.Button();
            this.btnRevisar = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(12, 31);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(107, 25);
            this.lblRol.TabIndex = 1;
            this.lblRol.Text = "Rol: Head";
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludo.Location = new System.Drawing.Point(311, 102);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(63, 29);
            this.lblSaludo.TabIndex = 2;
            this.lblSaludo.Text = "Hola";
            // 
            // lblOpciones
            // 
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpciones.Location = new System.Drawing.Point(359, 203);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(102, 25);
            this.lblOpciones.TabIndex = 3;
            this.lblOpciones.Text = "Opciones:";

            // 
            // btnReportar
            // 
            this.btnReportar.Location = new System.Drawing.Point(156, 240);
            this.btnReportar.Name = "btnReportar";
            this.btnReportar.Size = new System.Drawing.Size(180, 40);
            this.btnReportar.TabIndex = 4;
            this.btnReportar.Text = "Reportar Incidencia";
            this.btnReportar.UseVisualStyleBackColor = true;
            // 
            // btnRevisar
            // 
            this.btnRevisar.Location = new System.Drawing.Point(488, 240);
            this.btnRevisar.Name = "btnRevisar";
            this.btnRevisar.Size = new System.Drawing.Size(180, 40);
            this.btnRevisar.TabIndex = 5;
            this.btnRevisar.Text = "Revisar Incidencias";
            this.btnRevisar.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(688, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 40);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Cerrar sesión";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // JefeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnRevisar);
            this.Controls.Add(this.btnReportar);
            this.Controls.Add(this.lblOpciones);
            this.Controls.Add(this.lblSaludo);
            this.Controls.Add(this.lblRol);
            this.Name = "JefeForm";
            this.Text = "JefeForm";
            this.Load += new System.EventHandler(this.JefeForm_Load);
            this.Controls.SetChildIndex(this.lblRol, 0);
            this.Controls.SetChildIndex(this.lblSaludo, 0);
            this.Controls.SetChildIndex(this.lblOpciones, 0);
            this.Controls.SetChildIndex(this.btnReportar, 0);
            this.Controls.SetChildIndex(this.btnRevisar, 0);
            this.Controls.SetChildIndex(this.btnLogout, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Label lblOpciones;
        private System.Windows.Forms.Button btnReportar;
        private System.Windows.Forms.Button btnRevisar;
        private System.Windows.Forms.Button btnLogout;
    }
}