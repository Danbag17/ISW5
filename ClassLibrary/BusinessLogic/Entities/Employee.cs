using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities
{
    public partial class Employee
    {
        public Employee() { 
            this.ReportedIncidents = new List<Incident>();
        }
        public Employee(string fullName, string Id, string password) : this()
        {
            this.Id = Id;
            this.FullName = fullName;
            this.Password = password;
            

        }
    }
}
