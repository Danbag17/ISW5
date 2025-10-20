using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities
{
    public partial class WorkOrder
    {
        public WorkOrder() {}
        public WorkOrder(DateTime StartDate, Incident Incident) {
            this.StartDate = StartDate;
            this.Incident = Incident;
            this.Operators = new List<Operator>();
            this.UsedParts = new List<UsedPart>();
        
        }

    }
}
