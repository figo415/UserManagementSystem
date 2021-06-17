using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Megarobo.KunPengLIMS.Domain.Enums
{
    public enum LabwareTypeEnum
    {
        [Description("6孔板")]
        SixPlate,
        [Description("12孔板")]
        TwelvePlate,
        [Description("24孔板")]
        TwentyFourPlate,
        [Description("48孔板")]
        FourtyEightPlate,
        [Description("96孔板")]
        NinetySixPlate,
        [Description("1.5mL管")]
        OnePointFivePipe,
        [Description("15mL管")]
        FifteenPipe,
        [Description("50mL管")]
        FiftyPipe
    }
}
