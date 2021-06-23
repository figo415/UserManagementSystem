using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class DictItemDto
    {
        public Guid Id { get; set; }

        public string KeyName { get; set; }

        public string Type { get; set; }

        public List<string> Values { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
