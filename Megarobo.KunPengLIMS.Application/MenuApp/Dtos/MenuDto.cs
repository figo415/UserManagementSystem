using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Megarobo.KunPengLIMS.Application.MenuApp.Dtos
{
    public class MenuDto
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "功能名称不能为空。")]
        public string Name { get; set; }

        // 类型：0目录；1页面，2按钮
        public int Type { get; set; }

        public Guid ParentId { get; set; }

        public string Code { get; set; }

        public string Url { get; set; }

        public int OrdinalNumber { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
