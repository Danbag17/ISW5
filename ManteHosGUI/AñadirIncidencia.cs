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
            // Esto llena la lista automáticamente con las opciones definidas en tu enum.
            comboPrioridad.DataSource = Enum.GetValues(typeof(Priority));
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validaciones básicas (incluyendo que se haya seleccionado una prioridad)
                if (string.IsNullOrWhiteSpace(txtDepartamento.Text) ||
                    string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                    comboPrioridad.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, rellena todos los campos y selecciona una prioridad.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Recoger datos del formulario
                string departamento = txtDepartamento.Text;
                string descripcion = txtDescripcion.Text;
                DateTime fecha = dateFecha.Value;
                // Obtenemos el valor seleccionado y lo convertimos al tipo 'Priority'
                Priority prioridadSeleccionada = (Priority)comboPrioridad.SelectedItem;

                // 3. Obtener el usuario logueado
                Employee reportero = service.UserLogged();

                if (reportero == null)
                {
                    MessageBox.Show("No hay usuario logueado. Debe iniciar sesión.", "Error de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                // 4. Crear el objeto Incidencia
                // Usamos el constructor básico y luego asignamos la prioridad
                Incident incidente = new Incident(departamento, descripcion, fecha, reportero);
                incidente.Priority = prioridadSeleccionada; // Asignamos la prioridad seleccionada

                // 5. Llamar al servicio para guardar en la BD
                service.AddIncident(incidente);

                // 6. Feedback y cerrar
                MessageBox.Show("Incidencia registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar la incidencia: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboPrioridad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
