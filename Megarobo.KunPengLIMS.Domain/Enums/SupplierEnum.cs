using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Megarobo.KunPengLIMS.Domain.Enums
{
    public enum SupplierEnum
    {
        [Description("ThermoFisher")]
        ThermoFisher,
        [Description("全式金")]
        全式金,
        [Description("诺维赞")]
        诺维赞,
        [Description("碧云天")]
        碧云天,
        [Description("Gibco")] 
        Gibco,
        [Description("Merck")]
        Merck,
        [Description("invitrogen")]
        invitrogen
    }
}
