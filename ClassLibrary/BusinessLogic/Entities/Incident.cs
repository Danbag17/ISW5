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
        public Incident(string description, string department, DateTime reportdate, 
                         Employee reporter) {
            
            this.Description = description;
            this.ReportDate = reportdate;
            this.Department = department;
            this.Reporter = reporter;
        }

    }
}
