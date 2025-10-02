using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities
{
    public partial class Area
    {
        public String Name         {
            get; set;
           
        }
        public int ID
        {
            get; set;
        }
        public virtual Master Masters
        {
            get;    set;
        }
        
        public virtual ICollection<Incident> Incidents
        {
            get; set;
        }

    }
}
