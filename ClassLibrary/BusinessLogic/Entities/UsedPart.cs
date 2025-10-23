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

            this.Quantity = quantity;
            this.Part = part;

            if (part.CurrentQuantity < quantity)
            {
                // No hay suficiente → Needed = true
                this.Needed = true;
            }
            else
            {
                // Hay suficiente → descontar stock y Needed = false
                part.CurrentQuantity -= quantity;
                this.Needed = false;
            
            }
        }
    }
}
