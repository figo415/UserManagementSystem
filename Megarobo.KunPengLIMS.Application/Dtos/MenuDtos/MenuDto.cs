using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

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

        public string Path { get; set; }

        public string Component { get; set; }

        public string Redirect { get; set; }

        public bool Hidden { get; set; }

        public Meta Meta { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<MenuDto> Children { get; set; }
    }

    public class Meta
    {
        public string Title { get; set; }

        public string Icon { get; set; }
    }
}
