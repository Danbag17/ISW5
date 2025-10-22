using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities
{
    public partial class WorkOrder
    {
        public WorkOrder() {

            Operators = new List<Operator>();
            UsedParts = new List<UsedPart>();
        }
        public WorkOrder(DateTime StartDate, Incident Incident) {
            this.StartDate = StartDate;
            this.Incident = Incident;
            this.Operators = new List<Operator>();
            this.UsedParts = new List<UsedPart>();
        
        }

    }
}
