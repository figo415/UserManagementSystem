using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class DeviceDto
    {
		public Guid Id { get; set; }

		public string Name { get; set; }

		public string Type { get; set; }

		public string PositionText
        {
			get
			{
				if (Positions != null && Positions.Any())
				{
					var txt = new List<string>();
					var c = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
					foreach (var position in Positions)
					{
						if (position.boxType == "box")
						{
							var selected = new List<string>();
							if (position.selectedList != null && position.selectedList.Any())
							{
								foreach (var sel in position.selectedList)
								{
									var cell = sel.Split(",");
									var row = Convert.ToInt32(cell[0]);
									var rowlable = c[row - 1].ToString();
									selected.Add(rowlable + cell[1]);
								}
							}
							txt.Add(position.name + "[" + string.Join(",", selected) + "]");
						}
						else
						{
							txt.Add(position.name + "(" + position.localInfo + ")");
						}
					}
					return string.Join("/", txt);
				}
				return string.Empty;
			}
			set { }
		}

		public string ModelNumber { get; set; }

		public string Brand { get; set; }

		public string PurchaseFromName { get; set; }

		public string PurchaseFromUrl { get; set; }

		public string PurchasePrice { get; set; }

		public DateTime? PurchaseDate { get; set; }

		public string Supplier { get; set; }

		public DateTime CreateTime { get; set; }

		public List<LocationDto> Positions { get; set; }
	}
}
