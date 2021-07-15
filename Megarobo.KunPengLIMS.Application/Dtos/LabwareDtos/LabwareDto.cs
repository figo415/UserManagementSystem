using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class LabwareDto
    {
		public Guid Id { get; set; }

		public string Name { get; set; }

		public string Type { get; set; }

		public string Subclass { get; set; }

		public string ArticleNumber { get; set; }

		public string Brand { get; set; }

		public string Specification { get; set; }

		public string Position { get; set; }

		public int AvailableQuantity { get; set; }

		public int AvailableHole { get; set; }

		public string Barcode { get; set; }

		public DateTime CreateTime { get; set; }

		public DateTime LastModifiedTime { get; set; }

		public DateTime DeletedTime { get; set; }

		public string PurchaseFromName { get; set; }

		public string PurchaseFromUrl { get; set; }

		public string PurchasePrice { get; set; }

		public DateTime PurchaseDate { get; set; }

		public string Supplier { get; set; }

		public string Remarks { get; set; }
	}
}
