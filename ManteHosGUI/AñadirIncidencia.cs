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
    public partial class AñadirIncidencia : ManteHosFormBase
    {
        public AñadirIncidencia()
        {
            InitializeComponent();
        }
        public AñadirIncidencia(IManteHosService s):base(s)
        {
            InitializeComponent();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validaciones básicas
                if (string.IsNullOrWhiteSpace(txtDepartamento.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Rellena todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Recoger datos
                string departamento = txtDepartamento.Text;
                string descripcion = txtDescripcion.Text;
                DateTime fecha = dateTimePicker1.Value;

                // 3. Obtener quién reporta (usuario logueado)
                Employee reportero = service.UserLogged();

                if (reportero == null)
                {
                    MessageBox.Show("No hay usuario logueado. Inicia sesión de nuevo.", "Error");
                    this.Close();
                    return;
                }

                // 4. Crear el objeto
                Incident incidente = new Incident(departamento, descripcion, fecha, reportero);

                // 5. Llamar al servicio para guardar en BD
                service.AddIncident(incidente);

                MessageBox.Show("Incidencia guardada correctamente.", "Éxito");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error");
            }
        }

        // Evento para el botón Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
