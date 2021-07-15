using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    public class PurchasableEntity:AuditableEntity,IPurchasable
    {
        public Link PurchaseFrom { get; set; }

        public Price Price { get; set; }

        public DateTime? PurchaseDate { get; set; }

        public string Supplier { get; set; }
    }
}
