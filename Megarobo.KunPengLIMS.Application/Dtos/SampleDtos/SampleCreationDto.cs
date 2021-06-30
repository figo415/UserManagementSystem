using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class SampleCreationDto
    {
		[Required(ErrorMessage ="样本名称不能为空")]
		public string Name { get; set; }

		[Required(ErrorMessage ="请选择样本类型")]
		public string Type { get; set; }

		[Required(ErrorMessage = "请输入体积")]
		public string Cubage { get; set; }

		[Required(ErrorMessage ="请选择体积单位")]
		public string CubageUnit { get; set; }

		[Required(ErrorMessage = "请输入浓度")]
		public string Thickness { get; set; }

		[Required(ErrorMessage = "请选择浓度单位")]
		public string ThicknessUnit { get; set; }

		[Required(ErrorMessage = "请输入质量")]
		public string Quality { get; set; }

		[Required(ErrorMessage = "请选择质量单位")]
		public string QualityUnit { get; set; }

		[Required(ErrorMessage ="请选择供应商")]
		public string Supplier { get; set; }

		public string PurchaseFromName { get; set; }

		public string PurchaseFromUrl { get; set; }

		public string PurchasePrice { get; set; }

		public DateTime PurchaseDate { get; set; }

		public string Description { get; set; }

		public List<Guid> PositionIds { get; set; }

		public List<Guid> CellIds { get; set; }
	}
}
