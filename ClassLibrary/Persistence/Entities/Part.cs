using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities
{
    public partial class Part
    {
        public String Code { 
            get; 
            set;
            
        }
        public String Description
        {
            get;
            set;

        }
        public float UnitPrice
        {
            get;
            set;

        }
        public int CurrentQuantity { 
            get; 
            set; 
        }
        public int MinimunQuantity
        {
            get;
            set;

        }
        public String UnitOfMeasure
        {
            get;
            set;

        }

        public virtual ICollection<UsedPart> UsedParts
        { 
            get; 
            set; 
        }
    }
    
}
