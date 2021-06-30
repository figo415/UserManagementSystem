using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class DeviceDto
    {
		public Guid Id { get; set; }

		public string Name { get; set; }

		public string Type { get; set; }

		public string Position { get; set; }

		public string ModelNumber { get; set; }

		public string Brand { get; set; }

		public string PurchaseFromName { get; set; }

		public string PurchaseFromUrl { get; set; }

		public string PurchasePrice { get; set; }

		public DateTime PurchaseDate { get; set; }

		public string Supplier { get; set; }

		public DateTime CreatedTime { get; set; }
	}
}
