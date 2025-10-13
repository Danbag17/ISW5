using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities
{
    public partial class Head : Employee
    {
        public Head() { }
        public Head(string id, string fullName, string password) {
            this.Id = id;
            this.FullName = fullName;
            this.Password = password;
        }
    }
}
