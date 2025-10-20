using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities
{
    public partial class Incident
    {
        public Incident() { }
        public Incident(string description, string department, DateTime date, 
                         Employee reporter) {
            
            this.Description = description;
            this.Date = date;
            this.Department = department;
            this.Reporter = reporter;
        }

    }
}
