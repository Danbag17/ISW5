using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities
{
    public partial class Head
    {
        public Head() { }
        public Head(string FullName, string Id, string Password):base(FullName, Id, Password) {
            this.Id = Id;
            this.FullName = FullName;
            this.Password = Password;
        }
    }
}
