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
    }
}
