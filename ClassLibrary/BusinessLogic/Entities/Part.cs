using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities
{
    public partial class Part
    {
        public Part() {
            Parts = new List<Part>();
        }
        public Part(string Code, string Description, float UnitPrice, int CurrentQuantity, int MinimunQuantity, string UnitOfMesuare) {
            {
                this.Code = Code;
                this.Description = Description;
                this.UnitPrice = UnitPrice;
                this.CurrentQuantity = CurrentQuantity;
                this.MinimunQuantity = MinimunQuantity;
                this.UnitOfMeasure = UnitOfMesuare;
            }
    }
}
