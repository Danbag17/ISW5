using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities
{
    public partial class Operator : Employee
    {
        public Operator() { }

        public Operator(int Shift, string Id, string FullName, string Password):base(Id, FullName, Password) { 
            this.Shift = Shift.Morning;
                this.WorkOrders  = new List<WorkOrder>();
        }
    }
}
