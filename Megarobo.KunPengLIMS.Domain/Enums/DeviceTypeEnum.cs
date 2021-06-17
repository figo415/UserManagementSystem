using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Megarobo.KunPengLIMS.Domain.Enums
{
    public enum DeviceTypeEnum
    {
        [Description("培养箱")]
        Incubator,
        [Description("PCR")]
        PCR,
        [Description("移液工作站")]
        PipetWorkstation,
        [Description("货架")]
        StorageRack
    }
}
