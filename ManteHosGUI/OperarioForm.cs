using ManteHos.Services;
using ManteHos.Entities;
using System;
using System.Windows.Forms;

namespace ManteHosGUI
{
    // Hereda de EmpleadoForm, como el JefeForm
    public partial class OperarioForm : EmpleadoForm
    {
       public OperarioForm()
        {
            InitializeComponent();
        }
        public OperarioForm(IManteHosService s) : base(s)
        {
            InitializeComponent();
           

            // Asumimos que el usuario ya está logueado y es un Operario
            this.usuario = s.UserLogged();
            this.Text = "Menú de Operario";
        }

        private void OperarioForm_Load(object sender, EventArgs e)
        {
        
        // Siguiendo el patrón de JefeForm:
        lblRol.Text = "Rol : Operario";
            // Asumimos que 'usuario' es accesible y tiene FullName
            lblSaludo.Text = "Hola " + usuario.FullName;
        }

        // Manejador del botón Cerrar Orden
        private void btnCerrarOrden_Click(object sender, EventArgs e)
        {
            // Abre el formulario de cierre de órdenes, que está en el mismo namespace (ManteHosGUI)
            var frm = new CerrarOrdenTrabajo(service);
            frm.ShowDialog();
        }

        // Manejador del botón Cerrar Sesión
        private void btnLogout_Click(object sender, EventArgs e)
        {
            service.Logout();
            this.Close();
            // Opcional: Application.Restart();
        }
    }
}