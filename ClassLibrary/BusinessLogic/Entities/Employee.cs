using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities
{
    public partial class Employee
    {
        public Employee() { }
        public Employee(string Id, string fullName, string password)
        {
            this.Id = Id;
            this.FullName = fullName;
            this.Password = password;
            
        }
    }
}
