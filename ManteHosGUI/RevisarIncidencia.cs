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

namespace ManteHosGUI
{
    public partial class RevisarIncidencia : Form
    {
        private readonly IManteHosService service;
        private readonly Incident incident;
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
            ActualizarUI();
        }

        private void CargarDatosIncidencia()
        {
            txtDescripcion.Text = incident.Description;
            lblFecha.Text = $"Fecha: {incident.ReportDate:g}";
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
            var areas = service.GetAllAreas();
            cbArea.DataSource= areas;
            cbArea.DisplayMember= "Name";
            cbArea.ValueMember = "Id";
        }
        private void CargarPrioridades()
        {
            cbPrioridad.DataSource = Enum.GetValues(typeof(Priority));
        }

        private void ConfigurarEventosDecision()
        {
            rbAceptar.CheckedChanged += (s, e) => ActualizarUI();
        }

        private void ActualizarUI()
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }

    }
}
