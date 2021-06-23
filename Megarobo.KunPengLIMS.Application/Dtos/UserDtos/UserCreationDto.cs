using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class UserCreationDto
    {
        [Required(ErrorMessage ="用户名称不能为空")]
        public string UserName { get; set; }

        public string EMail { get; set; }

        [Required(ErrorMessage ="手机号码不能为空")]
        public string MobileNumber { get; set; }

        [Required(ErrorMessage ="请选择工作时间")]
        public List<string> WorkTime { get; set; }

        [DefaultValue(true)]
        public bool IsActive { get; set; }

        [Required(ErrorMessage ="请选择工作技能")]
        public List<Guid> SkillIds { get; set; }

        [Required(ErrorMessage ="请选择部门和角色")]
        public List<DepartmentIdRoleId> DepartmentRoleIds { get; set; }
    }
}
