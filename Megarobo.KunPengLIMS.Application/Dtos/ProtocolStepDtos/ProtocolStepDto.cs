using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class ProtocolStepDto
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public string Note { get; set; }

        public DateTime CreateTime { get; set; }

        public List<ProtocolStepDto> Children { get; set; }
    }
}
