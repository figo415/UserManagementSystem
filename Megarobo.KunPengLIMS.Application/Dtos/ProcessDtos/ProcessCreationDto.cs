using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class ProcessCreationDto
    {
        [Required(ErrorMessage ="流程名称不能为空")]
        public string Name { get; set; }

        public List<NodeDto> Nodes { get; set; }
    }
}
