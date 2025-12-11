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
    public partial class EmpleadoForm : ManteHosFormBase
    {
        public EmpleadoForm()
        {
            InitializeComponent();
        }

        public EmpleadoForm(IManteHosService s) : base(s)
        {
            InitializeComponent();
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AñadirIncidencia ventana = new AñadirIncidencia(this.service);
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void CerrarSesion_Click(object sender, EventArgs e)
        {
           this.Close();

        }
    }
}
