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
    public partial class OperarioForm : EmpleadoForm
    {
        private readonly IManteHosService service;
        private readonly ManteHos.Entities.Employee usuario;

        public OperarioForm(IManteHosService s) : base(s)
        {
            InitializeComponent();
            this.service = s;
            this.usuario = s.UserLogged();
        }

        private void OperarioForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrarOrden_Click(object sender, EventArgs e)
        {
            var frm = new CerrarOrdenTrabajo(service);
            frm.ShowDialog();
        }

        // Asumiendo un botón 'btnLogout' en el Designer.
        private void btnLogout_Click(object sender, EventArgs e)
        {
            service.Logout();
            this.Close();
        }

        private void lblSaludo_Click(object sender, EventArgs e)
        {

        }
    }
}

