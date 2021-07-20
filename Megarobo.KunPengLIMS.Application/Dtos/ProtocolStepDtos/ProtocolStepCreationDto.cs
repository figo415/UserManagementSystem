using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class ProtocolStepCreationDto
    {
        public Guid ParentId { get; set; }

        [Required(ErrorMessage = "ProtocolStep描述不能为空")]
        public string Description { get; set; }

        public string Note { get; set; }

        public SolutionDto Solution { get; set; }

        public List<LabwareUsageDto> LabwareUsages { get; set; }
    }
}
