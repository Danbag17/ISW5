using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManteHos.Services;
using ManteHos.Entities;
using System.Drawing.Text;
using System.Runtime.Remoting;
using ManteHos.Persistence;

namespace ManteHosGUI
{
    public partial class RevisarIncidencia : Form
    {
        private IManteHosService service;
        private Incident incident;
        public RevisarIncidencia(IManteHosService service, Incident incident)
        {
            InitializeComponent();
            this.service = service;
            this.incident = incident;
        }

        private void RevisarIncidencia_Load(object sender, EventArgs e)
        {
            CargarDatosIncidencia();
            CargarAreas();
            CargarPrioridades();
            ConfigurarEventosDecision(); //Cambiar nombre?
            ActualizarInterfaz();
        }

        private void CargarDatosIncidencia()
        {
            txtDescripcion.Text = incident.Description;

            lblFecha.Text = "Fecha: " + incident.ReportDate.ToString("g");
            string nombre = "(desconocido)";
            if (incident.Reporter != null)
                nombre = incident.Reporter.FullName;
            lblReportado.Text = nombre;
            lblDept.Text = incident.Department;
            lblPriori.Text = incident.Priority.ToString();
            //comprobar si directamente se pone valor = incident.Nombre o &"Nombre: "{incident.Nombre}
        }
        private void CargarAreas()
        {
            var listaAreas = service.GetAreas();
            cbArea.DataSource= listaAreas;
            cbArea.DisplayMember= "Name";
            cbArea.ValueMember = "Id";
        }
        private void CargarPrioridades()
        {
            cbPrioridad.DataSource = Enum.GetValues(typeof(Priority));
        }

        private void ConfigurarEventosDecision()
        {
            rbAceptar.CheckedChanged += (s, e) => ActualizarInterfaz();
            rbRechazar.CheckedChanged += (s, e) => ActualizarInterfaz();
        }

        private void ActualizarInterfaz()
        {
            if (rbAceptar.Checked)  
            {
                cbArea.Enabled = true;          // Activar selección de área
                cbPrioridad.Enabled = true;     // Activar selección de prioridad

                txtMotivoRechazo.Enabled = false;      // No permitir escribir motivo de rechazo
                txtMotivoRechazo.Clear();              // Limpiar cualquier texto previo
            }
            else  
            {
                cbArea.Enabled = false;        
                cbPrioridad.Enabled = false;    

                txtMotivoRechazo.Enabled = true;       
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                bool aceptar = rbAceptar.Checked;

                Area area = null;
                Priority prioridad = incident.Priority;
                string motivo = null;

                if (aceptar)
                {
                    area = cbArea.SelectedItem as Area;

                    if(area == null)
                    {
                        MessageBox.Show("Debe seleccionar un área.");
                        return;
                    }

                    prioridad = (Priority)cbPrioridad.SelectedItem;
                }
                else
                {
                    motivo = txtMotivoRechazo.Text.Trim();

                    if (string.IsNullOrWhiteSpace(motivo))
                    {
                        MessageBox.Show("Debe indicar el motivo del rechazo.");
                        return;
                    }
                }

                service.ReviewIncident(incident, aceptar, motivo, area, prioridad);

                MessageBox.Show("Incidencia revisada correctamente");

                this.Close();
            }
            catch (ServerException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_CLick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
