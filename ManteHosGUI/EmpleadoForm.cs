using ManteHos.Services;
using ManteHos.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManteHosGUI
{
    public partial class EmpleadoForm : ManteHosFormBase
    {

        protected Employee usuario;

        public EmpleadoForm()
        {
            InitializeComponent();
        }

        public EmpleadoForm(IManteHosService s) : base(s)
        {
            InitializeComponent();
            usuario = service.UserLogged();
        }

        private void CerrarSesion_Click(object sender, EventArgs e)
        {
            // 1. Mostramos la ventana emergente preguntando
            DialogResult respuesta = MessageBox.Show(
                "¿Estás seguro de que quieres cerrar la sesión?",
                "Cerrar Sesión",                                
                MessageBoxButtons.YesNo,                        
                MessageBoxIcon.Question                          
            );

            // 2. Comprobamos qué ha pulsado el usuario
            if (respuesta == DialogResult.Yes)
            {
                // SÍ, cerramos la ventana.
                // Esto hará que el control vuelva al Login (HospitalApp) y se ejecute el Logout real.
                this.Close();
            }
            else
            {
                
            }
        }

        private void ReportarIncidencia_Click(object sender, EventArgs e)
        {
            AñadirIncidencia ventana = new AñadirIncidencia(this.service);

            ventana.ShowDialog();
        }
    }
}
