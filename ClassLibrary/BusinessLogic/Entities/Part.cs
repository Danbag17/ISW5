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
        public Part() { }
        public Part(string Code, int CurrentQuantity, string Description, int MinimunQuantity, string UnitOfMesuare, float UnitPrice)
        {
            {
                this.Code = Code;
                this.Description = Description;
                this.UnitPrice = UnitPrice;
                this.CurrentQuantity = CurrentQuantity;
                this.MinimunQuantity = MinimunQuantity;
                this.UnitOfMeasure = UnitOfMesuare;

                UsedParts = new List<UsedPart>();
            }
        }
    }
}
