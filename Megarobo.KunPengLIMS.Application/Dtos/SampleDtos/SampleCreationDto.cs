using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class SampleCreationDto
    {
		public bool IsRealSample { get; set; }

		[Required(ErrorMessage ="样本名称不能为空")]
		public string Name { get; set; }

		[Required(ErrorMessage ="请选择样本类型")]
		public string Type { get; set; }

		[Required(ErrorMessage = "请输入体积")]
		public string CubageValue { get; set; }

		[Required(ErrorMessage ="请选择体积单位")]
		public string CubageUnit { get; set; }

		[Required(ErrorMessage = "请输入浓度")]
		public string ThicknessValue { get; set; }

		[Required(ErrorMessage = "请选择浓度单位")]
		public string ThicknessUnit { get; set; }

		[Required(ErrorMessage = "请输入质量")]
		public string QualityValue { get; set; }

		[Required(ErrorMessage = "请选择质量单位")]
		public string QualityUnit { get; set; }

		public string Supplier { get; set; }

		public SourceTask SourceTask { get; set; }

		public string PurchaseFromName { get; set; }

		public string PurchaseFromUrl { get; set; }

		public string PurchasePrice { get; set; }

		public DateTime? PurchaseDate { get; set; }

		public string Description { get; set; }

		public List<LocationDto> Positions { get; set; }

		public string SubType { get; set; }

		public List<SampleCellDto> Cells { get; set; }
	}
}
