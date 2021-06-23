using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class DepartmentCreationDto
    {
        [Required(ErrorMessage ="请提供上级部门")]
        public Guid ParentId { get; set; }

        [Required(ErrorMessage = "部门名称不能为空")]
        public string Name { get; set; }

        [Required(ErrorMessage ="请提供显示序号")]
        public int OrdinalNumber { get; set; }

        public string Manager { get; set; }

        public string ContactNumber { get; set; }

        [DefaultValue(true)]
        public bool IsActive { get; set; }
    }
}
