using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class QpcrDetectionDtoList:DtoList<QpcrDetectionDto>
    {
        public QpcrDetectionDtoList(IEnumerable<QpcrDetectionDto> dtos)
        {
            ObjectList = dtos;
        }
    }
}
