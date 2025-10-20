using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities
{
    public partial class WorkOrder
    {
        public WorkOrder() { }
        public WorkOrder(DateTime EndDate, string RepairReport, DateTime StartDate, Incident Incident) {
            this.EndDate = EndDate;
            this.RepairReport = RepairReport;
            this.StartDate = StartDate;
            this.Incident = Incident;
            this.Operators = new List<Operator>();
            this.UsedParts = new List<UsedPart>();
        
        }

    }
}
