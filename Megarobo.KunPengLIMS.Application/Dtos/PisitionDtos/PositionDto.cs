using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class PositionDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public List<PositionDto> Children { get; set; }
    }
}
