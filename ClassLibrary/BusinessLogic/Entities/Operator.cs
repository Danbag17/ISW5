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

        public Operator(string FullName, string Id, string Password, Shift Shift):base(FullName, Id, Password) { 
            this.Shift = (int)Shift Morning;
                this.WorkOrders  = new List<WorkOrder>();
        }
    }
}
