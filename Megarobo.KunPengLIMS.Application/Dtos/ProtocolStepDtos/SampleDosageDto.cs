using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class SampleDosageDto
    {
		public string Name { get; set; }

		public string CubageValue { get; set; }

		public string CubageUnit { get; set; }

		public string QualityValue { get; set; }

		public string QualityUnit { get; set; }

		public bool IsCell { get; set; }

		public int Quantity { get; set; }
	}
}
