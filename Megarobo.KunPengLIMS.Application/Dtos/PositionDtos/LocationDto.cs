using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class LocationDto
    {
        public int value { get; set; }

        public string label { get; set; }

        public int? boxId { get; set; }

        public int pid { get; set; }

        public int labId { get; set; }

        public string name { get; set; }

        public int? boxCols { get; set; }

        public int? boxRows { get; set; }

        public string boxType { get; set; }

        public List<string> selectedList { get; set; }

        public List<BoxStoreDto> boxStore { get; set; }

        public string localInfo { get; set; }

        [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
        public List<LocationDto> children { get; set; }
    }
}
