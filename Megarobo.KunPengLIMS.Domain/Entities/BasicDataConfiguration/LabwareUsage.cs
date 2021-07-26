using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    public class LabwareUsage:Entity
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public Guid ProtocolStepId { get; set; }

        [ForeignKey("ProtocolStepId")]
        public ProtocolStep ProtocolStep { get; set; }
    }
}
