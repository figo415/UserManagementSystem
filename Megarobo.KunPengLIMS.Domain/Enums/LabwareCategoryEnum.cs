using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Megarobo.KunPengLIMS.Domain.Enums
{
    public enum LabwareCategoryEnum
    {
        [Description("存储(样本试剂)")]
        Storage,
        [Description("移液")]
        Pipetting,
        [Description("配件")]
        Accessory
    }
}
