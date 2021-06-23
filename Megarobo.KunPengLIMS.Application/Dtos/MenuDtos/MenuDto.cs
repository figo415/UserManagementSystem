using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class MenuDto
    {
        public Guid Id { get; set; }

        public Guid ParentId { get; set; }

        public string Name { get; set; }

        // 类型：0目录；1页面，2按钮
        public int Type { get; set; }

        public bool IsActive { get; set; }

        public string Url { get; set; }

        public int OrdinalNumber { get; set; }

        public string Code { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
