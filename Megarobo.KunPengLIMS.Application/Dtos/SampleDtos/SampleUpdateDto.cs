using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class  SampleUpdateDto
    {
		public bool IsRealSample { get; set; }

		public string Name { get; set; }

		public string Type { get; set; }

		public string CubageValue { get; set; }

		public string CubageUnit { get; set; }

		public string ThicknessValue { get; set; }

		public string ThicknessUnit { get; set; }

		public string QualityValue { get; set; }

		public string QualityUnit { get; set; }

		public string Supplier { get; set; }

		public SourceTask SourceTask { get; set; }

		public string PurchaseFromName { get; set; }

		public string PurchaseFromUrl { get; set; }

		public string PurchasePrice { get; set; }

		public DateTime? PurchaseDate { get; set; }

		public string Description { get; set; }

		public List<LocationDto> Positions { get; set; }

		public List<SampleCellDto> Cells { get; set; }
	}
}
