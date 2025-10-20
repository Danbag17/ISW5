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
        public Incident(string department, string description, DateTime reportdate, 
                         Employee reporter) {
            
            this.Description = description;
            this.Date = date;
            this.Department = department;
            this.Priority = priority;
            this.Status = status;
            this.RejectReason = rejectReason;
            this.Cost = cost;
            this.Area = area;
            this.Reporter = reporter;
            
        }

    }
}
