using ManteHos.Entities;
using ManteHos.Services;
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
    public partial class HospitalApp : ManteHosFormBase
    {
        public HospitalApp()
        {
            InitializeComponent();
        }

        public HospitalApp(IManteHosService s) : base(s)
        {
            InitializeComponent();
        }

        private void HospitalApp_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btInicioSesion_Click(object sender, EventArgs e)
        {
            try { 
            //El formulario llama al servicio para que intente loguear al usuario
            this.service.Login(txtUsuario.Text, txtContraseña.Text);
            panelLogin.Visible = false;
            menuStrip1.Visible = true;
                
                Employee usuario = this.service.UserLogged();
                
                //Vemos quien se logea y dependiendo de su rango tendran unas funciones u otras
                if (usuario is Head) // Es un Jefe
                {
                    MenuJefes.Visible = true;
                }
                else if (usuario is Master) // Es un Maestro
                {
                    MenuMaestros.Visible = true;
                }
                else if (usuario is Operator) // Es un Operario
                {
                    MenuOperarios.Visible = true;
                }
                MessageBox.Show("Bienvenido " + usuario.FullName);
            }
            catch (Exception ex) {
            MessageBox.Show(ex.Message); // Si el servicio no funciona, mostramos el error
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
