using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities
{
    public partial class Incident
    {
        public Incident() { }
        public Incident(int id, string description, DateTime date, string department, int priority,
                        int status, string rejectReason, float cost,
                        Area area, Employee reporter, WorkOrder workOrder) {
            this.Id = id;
            this.Description = description;
            this.Date = date;
            this.Department = department;
            this.Priority = priority;
            this.Status = status;
            this.RejectReason = rejectReason;
            this.Cost = cost;
            this.Area = area;
            this.Reporter = reporter;
            this.WorkOrder = workOrder;
        }

    }
}
