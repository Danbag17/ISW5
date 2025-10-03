using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities
{
    public partial class Employee
    {
        public Employee(string id, string fullName, string password)
        {
            Id = id;
            FullName = fullName;
            Password = password;
            
        }
    }
}
