using ManteHos.Entities;
using ManteHos.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ManteHosGUI
{
    public partial class MaestroForm : EmpleadoForm 
    {
        public MaestroForm(){
            
            InitializeComponent();
        }

        public MaestroForm(IManteHosService service) : base(service){
            
            InitializeComponent();
        }

        // --- 2. La función que te falta ---
        private void CargarIncidencias()
        {
            // A. Obtenemos el usuario actual y lo convertimos a "Master"
            Master maestro = service.UserLogged() as Master;

            if (maestro != null)
            {
                // B. Pedimos al servicio las incidencias de SU área
                // (Asegúrate de haber añadido este método al servicio como hablamos antes)
                var listaIncidencias = service.GetIncidentsForMaster(maestro.Id);

                // C. Llenamos la tabla
                dgvIncidencias.DataSource = null; // Limpiar primero
                dgvIncidencias.DataSource = listaIncidencias;

                // D. Opcional: Ocultar columnas feas (Relaciones con otras tablas)
                if (dgvIncidencias.Columns["WorkOrder"] != null)
                    dgvIncidencias.Columns["WorkOrder"].Visible = false;

                if (dgvIncidencias.Columns["Area"] != null)
                    dgvIncidencias.Columns["Area"].Visible = false;
            }
        }

        // --- 1. Evento Load (Para cargar datos al abrir la ventana) ---
        // IMPORTANTE: Tienes que conectar este evento desde el rayo amarillo en el diseño
        // o hacer doble clic en el fondo del formulario.
        private void MaestroForm_Load(object sender, EventArgs e)
        {
            CargarIncidencias();
        }

        



        private void button1_Click(object sender, EventArgs e)
        {
           
            // 1. Validar que hay algo seleccionado en la tabla
            if (dgvIncidencias.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una incidencia primero.");
                return;
            }

            // 2. Recuperar el objeto Incidencia de la fila seleccionada
            Incident incidenciaSeleccionada = (Incident)dgvIncidencias.CurrentRow.DataBoundItem;

            // 3. Comprobación de seguridad (Opcional, según PDF)
            // Si la incidencia ya está cerrada o en progreso, quizás no quieras dejar abrirla
            if (incidenciaSeleccionada.Status == Status.Completed)
            {
                MessageBox.Show("Esta incidencia ya está cerrada.");
                return;
            }

            // 4. --- AQUÍ ESTÁ LA MAGIA ---
            // Creamos tu ventana YA HECHA y le pasamos el servicio y la incidencia
            AsignarOrdenDeTrabajo ventanaHija = new AsignarOrdenDeTrabajo(this.service, incidenciaSeleccionada);

            // 5. La mostramos como diálogo (bloquea la de atrás)
            ventanaHija.ShowDialog();

            // 6. ¡MUY IMPORTANTE! 
            // Cuando la ventana hija se cierre (ShowDialog termina), 
            // tenemos que refrescar la tabla para que se vea que el estado ha cambiado a "InProgress"
            CargarIncidencias();
        
        }

        private void dgvIncidencias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
