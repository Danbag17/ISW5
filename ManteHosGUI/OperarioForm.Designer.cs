namespace ManteHosGUI
{
    partial class OperarioForm
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
            this.btnCerrarOrden = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(9, 25);
            this.lblRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(115, 20);
            this.lblRol.TabIndex = 1;
            this.lblRol.Text = "Rol: Operario";
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludo.Location = new System.Drawing.Point(233, 83);
            this.lblSaludo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(49, 24);
            this.lblSaludo.TabIndex = 2;
            this.lblSaludo.Text = "Bienvenido";
            this.lblSaludo.Click += new System.EventHandler(this.lblSaludo_Click);
            // 
            // lblOpciones
            // 
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpciones.Location = new System.Drawing.Point(269, 165);
            this.lblOpciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(80, 20);
            this.lblOpciones.TabIndex = 3;
            this.lblOpciones.Text = "Opciones:";
            // 
            // btnCerrarOrden
            // 
            this.btnCerrarOrden.Location = new System.Drawing.Point(240, 195);
            this.btnCerrarOrden.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrarOrden.Name = "btnCerrarOrden";
            this.btnCerrarOrden.Size = new System.Drawing.Size(135, 32);
            this.btnCerrarOrden.TabIndex = 4;
            this.btnCerrarOrden.Text = "Cerrar Orden de Trabajo";
            this.btnCerrarOrden.UseVisualStyleBackColor = true;
            this.btnCerrarOrden.Click += new System.EventHandler(this.btnCerrarOrden_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(516, 10);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 32);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Cerrar sesión";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // OperarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnCerrarOrden);
            this.Controls.Add(this.lblOpciones);
            this.Controls.Add(this.lblSaludo);
            this.Controls.Add(this.lblRol);
            this.Name = "OperarioForm";
            this.Text = "Menú de Operario";
            this.Load += new System.EventHandler(this.OperarioForm_Load);
            this.Controls.SetChildIndex(this.lblRol, 0);
            this.Controls.SetChildIndex(this.lblSaludo, 0);
            this.Controls.SetChildIndex(this.lblOpciones, 0);
            this.Controls.SetChildIndex(this.btnCerrarOrden, 0);
            this.Controls.SetChildIndex(this.btnLogout, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Label lblOpciones;
        private System.Windows.Forms.Button btnCerrarOrden;
        private System.Windows.Forms.Button btnLogout;
    }
}
