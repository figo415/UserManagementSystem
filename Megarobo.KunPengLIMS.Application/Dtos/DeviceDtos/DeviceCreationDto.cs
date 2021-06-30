using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class DeviceCreationDto
    {
		[Required(ErrorMessage ="设备名称不能为空")]
		public string Name { get; set; }

		[Required(ErrorMessage ="请选择设备类型")]
		public string Type { get; set; }

		public string ModelNumber { get; set; }

		public string Brand { get; set; }

		public string PurchaseFromName { get; set; }

		public string PurchaseFromUrl { get; set; }

		public string PurchasePrice { get; set; }

		public DateTime PurchaseDate { get; set; }

		public List<Guid> PositionIds { get; set; }
	}
}
