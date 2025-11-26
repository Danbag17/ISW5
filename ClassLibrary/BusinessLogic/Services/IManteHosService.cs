using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManteHos.Entities;


namespace ManteHos.Services
{
    public interface IManteHosService
    {
        void RemoveAllData();
        void Commit();

        // Necesario para la inicialización de la BD
        void DBInitialization();

        //
        // A partir de aquí los necesarios para los CU solicitados
        //
        void Login(string login, string password);

        void Logout();

        void ReviewIncident(int incidentId, bool accepted, string rejectReason, Area area, Priority newPriority);

        //WorkOrder AssignWorkOrder(int incidentID, List<Operator> operators);

        Employee UserLogged();

        void AddIncident(Incident incident);

    }
}