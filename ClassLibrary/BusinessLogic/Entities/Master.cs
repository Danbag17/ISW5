using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities
{
    public partial class Master : Employee
    {
        public Master() { }
        public Master(string Id, string FullName, string Password):base(Id, FullName, Password) { }
        
        
    }
}

