using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities
{
    public partial class UsedPart
    {
        public UsedPart() { 
            if(this.WorkOrders == null)
                this.WorkOrders = new List<WorkOrder>();
        }

        public UsedPart(int quantity, Part part) : this(){
            if(part  == null) throw new ArgumentNullException(nameof(part));
            if(quantity<=0) throw new ArgumentOutOfRangeException(nameof(quantity));
            this.Quantity = quantity;
            this.Part = part;

            if (part.CurrentQuantity <= quantity)
            {
                // Hay suficiente → descontar stock y Needed = false
                this.Needed = false;
                part.CurrentQuantity -= quantity; 
            }
            else
            {
                // No hay suficiente → Needed = true
                this.Needed= true;
            }
        }
    }
}
