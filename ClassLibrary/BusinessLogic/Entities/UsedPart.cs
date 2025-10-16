using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities
{
    public partial class UsedPart
    {
        public UsedPart() { }

        public UsedPart(int Id, int Quantity, Boolean Needed, Part Parts) {
            this.Id = Id;
            this.Quantity = Quantity;
            this.Needed = Needed;
            this.Parts = Parts;
        }
    }
}
