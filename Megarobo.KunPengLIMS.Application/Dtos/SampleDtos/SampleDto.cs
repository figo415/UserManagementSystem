using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class SampleDto
    {
        public Guid Id { get; set; }

		public string Name { get; set; }

		public string SourceTaskText { get; set; }

		public SourceTask SourceTask { get; set; }

		public string Type { get; set; }

		public string Description { get; set; }

		public string Cubage { get; set; }

		public string CubageUnit { get; set; }

		public string CubageValue { get; set; }

		public string Quality { get; set; }

		public string QualityUnit { get; set; }

		public string QualityValue { get; set; }

		public string Thickness { get; set; }

		public string ThicknessUnit { get; set; }

		public string ThicknessValue { get; set; }

		public string PositionText
        {
            get
            {
				if(Positions!=null && Positions.Any())
                {
					var txt = new List<string>();
					var c = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
					foreach(var position in Positions)
                    {
						if(position.boxType=="box")
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

		public List<LocationDto> Positions { get; set; }

		public DateTime CreateTime { get; set; }

		public DateTime DeletedTime { get; set; }

		public DateTime NextPhotoTime { get; set; }

		public string PurchaseFromName { get; set; }

		public string PurchaseFromUrl { get; set; }

		public string PurchasePrice { get; set; }

		public DateTime? PurchaseDate { get; set; }

		public string Supplier { get; set; }

		public string History { get; set; }

		public string SubType { get; set; }

		public List<SampleCellDto> Cells { get; set; }
	}
}
