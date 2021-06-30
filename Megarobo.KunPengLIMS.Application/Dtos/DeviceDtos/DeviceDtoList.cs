using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class DeviceDtoList:DtoList<DeviceDto>
    {
        public DeviceDtoList(IEnumerable<DeviceDto> dtos)
        {
            ObjectList = dtos;
        }
    }
}
