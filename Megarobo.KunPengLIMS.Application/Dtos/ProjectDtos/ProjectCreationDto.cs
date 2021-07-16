using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class ProjectCreationDto
    {
        [Required(ErrorMessage = "项目名称不能为空")]
        public string Name { get; set; }

        [Required(ErrorMessage = "请选择流程")]
        public Guid ProcessId { get; set; }

        public DateTime? PlannedStartTime { get; set; }

        public List<UserDto> Operators { get; set; }
    }
}
