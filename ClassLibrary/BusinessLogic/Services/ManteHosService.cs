using ManteHos.Entities;
using ManteHos.Persistence;
using ManteHos.Services;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace ManteHos.Services
{
    public class ManteHosService : IManteHosService
    {
        private readonly IDAL dal;
        private Employee User_Logged;
        public ManteHosService(IDAL dal)
        {
            this.dal = dal;
            User_Logged = null;
        }

        /// <summary>
        /// Borra todos los datos de la BD
        /// </summary>
        public void RemoveAllData()
        {
            dal.RemoveAllData();
        }

        /// <summary>
        /// Salva todos los cambios que haya habido en el contexto de la aplicación desde la última vez que se hizo Commit
        /// </summary>
        public void Commit()
        {
            dal.Commit();
        }

        /// <summary>
        /// Inicializa los datos para que haya ciertos datos para poder usarlos luego
        /// </summary>
        public void DBInitialization()
        {
            RemoveAllData();

            // Dar de alta ciertos datos relevantes para el sistema
            Head head = new Head("Ibañez", "h1", "h1");
            AddPerson(head);
            Master tfmotu = new Master("Bárcenas", "m1", "m1");
            AddPerson(tfmotu);
            Master master2 = new Master("He-Man", "m2", "m2");
            AddPerson(master2);
            Master master3 = new Master("Picasso", "m3", "m3");
            AddPerson(master3);
            Operator op1 = new Operator("Pepe Gotera", "o1", "o1", Shift.Morning);
            AddPerson(op1);
            Operator op2 = new Operator("Otilio", "o2", "o2", Shift.Morning);
            AddPerson(op2);
            Operator op3 = new Operator("Rompetechos", "o3", "o3", Shift.Night);
            AddPerson(op3);

            Employee empleado1 = new Employee("Sacarino", "e1", "e1");
            AddPerson(empleado1);
            Employee empleado2 = new Employee("Pepe García", "e2", "e2");
            AddPerson(empleado2);

            Area a1 = new Area("Mecánica", tfmotu);
            AddArea(a1);
            Area a2 = new Area("Electricidad", master2);
            AddArea(a2);
            Area a3 = new Area("Pintura", master3);
            AddArea(a3);

            Part p1 = new Part("Esc50", 5, "Placa de escayola para techo", 1, "Placa de 50x30cms", 5);
            AddPart(p1);
            Part p2 = new Part("TM8", 3000, "Tornillo métrica 8", 100, "Tornillo", 0.01F);
            AddPart(p2);
            Part p3 = new Part("ClimaEst", 4, "Cristal Climalit de ventana estándar", 0, "Cristal 75x100cms", 200);
            AddPart(p3);

        }

        public void AddPerson(Employee person)
        {
            // Restricción: No puede haber dos personas con el mismo Id
            if (dal.GetById<Employee>(person.Id) == null)
            {
                dal.Insert<Employee>(person);
                dal.Commit();
            }
            else throw new ServiceException("Person with Id " + person.Id + " already exists.");
        }

        public void AddArea(Area area)
        {
            // Restricción: No puede haber dos áreas con el mismo Nombre
            if (!dal.GetWhere<Area>(x => x.Name == area.Name).Any())
            {
                dal.Insert<Area>(area);
                dal.Commit();
            }
            else throw new ServiceException("Area with Name " + area.Name + " already exists.");
        }

        public void AddPart(Part part)
        {
            // Restricción: No puede haber dos piezas con la misma descripción
            if (!dal.GetWhere<Part>(x => x.Description == part.Description).Any())
            {
                dal.Insert<Part>(part);
                dal.Commit();
            }
            else throw new ServiceException("Part with Description " + part.Description + " already exists.");
        }

        //
        // Resto de metodos necesarios para el servicio
        //

        public void Login(string login, string password)
        {
            if (string.IsNullOrEmpty(login))
            {
                throw new ServiceException("El login no puede estar vacío");
            }

            if (string.IsNullOrEmpty(password))
            {
                throw new ServiceException("La contraseña no puede estar vacía");
            }

            Employee empleado_encontrado = dal.GetById<Employee>(login);

            if (empleado_encontrado == null)
            {
                throw new ServiceException("No existe el usuario");
            }

            if (empleado_encontrado.Password != password)
            {
                throw new ServiceException("La contraseña es incorrecta");
            }

            User_Logged = empleado_encontrado;

        }

        public void Logout()
        {
            User_Logged = null;
            dal.Rollback();
        }
        public Employee UserLogged()
        {
            return User_Logged;
        }

        public void ReviewIncident(int incidentId, bool accepted, string rejectReason, Area area, Priority newPriority)
        {

            if (User_Logged == null)
                throw new ServiceException("Debe iniciar sesión.");

            if (!(User_Logged is Head))
                throw new ServiceException("Solo un jefe puede revisar incidencias.");

            Incident incident = dal.GetById<Incident>(incidentId);
            if (incident == null)
                throw new ServiceException("La incidencia no existe.");

            if (accepted)
            {
                if (area == null)
                    throw new ServiceException("Una incidencia debe tener un area.");

                incident.Status = Status.Accepted;
                incident.Area = area;
                incident.RejectReason = null;
                incident.Priority = newPriority;
            }
            else
            {
                incident.Status = Status.Rejected;
                if (string.IsNullOrEmpty(rejectReason))
                    throw new ServiceException("Debe indicar motivo del rechazo.");

                incident.RejectReason = rejectReason;
                incident.Area = null;
            }
            dal.Commit();
        }

        public void AddIncident(Incident incident)
        {
            dal.Insert<Incident>(incident);
            dal.Commit();
        }
        public WorkOrder AssignWorkOrder(int incidentId, List<Operator> operators)
        {
            //Usuario logeado
            if (User_Logged == null)
                throw new ServiceException("Debe iniciar sesión.");

            // El usuario debe ser Master
            if (!(User_Logged is Master))
                throw new ServiceException("Solo un maestro puede asignar órdenes de trabajo.");

            Master master = (Master)User_Logged;

            //Miramos si la incidencia existe
            Incident incident = dal.GetById<Incident>(incidentId);
            if (incident == null)
                throw new ServiceException("La incidencia no existe.");

            //Miramos si ha sido aceptada
            if (incident.Status != Status.Accepted)
                throw new ServiceException("La incidencia debe estar aceptada.");

            //La incidencia debe estar en el area de master
            if (incident.Area == null || incident.Area.Id != master.Area.Id)
                throw new ServiceException("La incidencia pertenece a otra área.");

            //Comprobamos si hay operadores disponibles
            if (operators == null || operators.Count == 0)
                throw new ServiceException("Debe asignar al menos un operario.");

            //Creamos la orden
            WorkOrder wo = new WorkOrder(DateTime.Now, incident);

            //Asignamos un operador
            foreach (var op in operators)
                wo.AddOperator(op);

            dal.Insert(wo);
            dal.Commit();

            return wo;
        }

        public WorkOrder CloseWorkOrder(int workOrderId, string report, DateTime endDate)
        {
            if (User_Logged == null)
                throw new ServiceException("Debe iniciar sesión.");

            if (!(User_Logged is Operator opLogged))
                throw new ServiceException("Solo un operario puede cerrar órdenes de trabajo.");

            WorkOrder wo = dal.GetById<WorkOrder>(workOrderId);
            if (wo == null)
                throw new ServiceException("La orden de trabajo no existe.");

            if (!wo.Operators.Contains(opLogged))
                throw new ServiceException("El operario no tiene asignada esta orden de trabajo.");

            if (wo.EndDate != default(DateTime))
                throw new ServiceException("La orden de trabajo ya está cerrada.");

            //Miramos si quedan piezas pendientes
            bool pendingParts = wo.UsedParts.Any(up => up.Needed);
            if (pendingParts)
                throw new ServiceException("La orden tiene piezas pendientes. No se puede cerrar.");

            //Validamos los datos del operario
            if (string.IsNullOrWhiteSpace(report))
                throw new ServiceException("Debe indicar un informe de reparación.");

            wo.RepairReport = report;
            wo.EndDate = endDate;

            dal.Commit();

            return wo;
        }



    }
}
