using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities
{
    public partial class Incident
    {
        public int Id { get; set; }
        public String Description { get; set; }
        public DateTime ReportDate { get; set; }
        public string Department { get; set; }
        public Priority Priority { get; set; }
        public Status Status { get; set; }
        public string RejectReason { get; set; }
        public float Cost { get; set; }


        //Relaciones
        public virtual Area Area { get; set; }
        public virtual Employee Reporter { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
    }
}
