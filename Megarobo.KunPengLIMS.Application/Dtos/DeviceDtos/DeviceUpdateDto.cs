using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class DeviceUpdateDto
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public List<LocationDto> Positions { get; set; }
    }
}
