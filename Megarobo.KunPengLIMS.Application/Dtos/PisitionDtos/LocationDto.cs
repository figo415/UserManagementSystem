using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class LocationDto
    {
        public int value { get; set; }

        public string label { get; set; }

        public string boxId { get; set; }

        public int pid { get; set; }

        public int labId { get; set; }

        public string name { get; set; }

        public string boxCols { get; set; }

        public string boxRows { get; set; }

        public string boxType { get; set; }

        public List<string> selectedList { get; set; }

        public List<BoxStoreItemDto> boxStore { get; set; }

        public string localInfo { get; set; }

        public List<LocationDto> Children { get; set; }
    }
}
