using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Megarobo.KunPengLIMS.Domain.Enums
{
    public enum CapacityUnit
    {
        [Description("F")]
        Farad,
        [Description("mF")]
        MilliFarad,
        [Description("μF")]
        MicroFarad,
        [Description("nF")]
        NanoFarad,
        [Description("pF")]
        PicoFarad
    }
}
