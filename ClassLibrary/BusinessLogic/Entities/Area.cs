using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities
{
    public partial class Area
    {
        public Area() {
            //Colecciones
            Incidents = new List<Incident>();
        }

        public Area(String name, Master masters)
        {
            this.Name = name;
            Masters = masters;
        }
    }
}
