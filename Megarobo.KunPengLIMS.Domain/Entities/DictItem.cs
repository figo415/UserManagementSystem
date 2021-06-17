using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    /// <summary>
    /// 字典项
    /// </summary>
    public class DictItem:AuditableEntity
    {
        public string KeyName { get; set; }

        public string Type { get; set; }

        public string Value { get; set; }
    }
}
