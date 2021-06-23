using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class MenuCreationDto
    {
        [Required(ErrorMessage = "请提供上级菜单")]
        public Guid ParentId { get; set; }

        [DefaultValue(0)]
        // 类型：0目录；1页面，2按钮
        public int Type { get; set; }

        [Required(ErrorMessage = "菜单名称不能为空。")]
        public string Name { get; set; }

        public string Code { get; set; }

        public string RoutePath { get; set; }
        
        [Required(ErrorMessage = "请提供显示排序值")]
        public int OrdinalNumber { get; set; }

        public string Url { get; set; }

        [DefaultValue(true)]
        public bool IsActive { get; set; }
    }
}
