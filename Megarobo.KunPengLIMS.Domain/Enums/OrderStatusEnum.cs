using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.Enums
{
    public enum OrderStatusEnum
    {
        OrderReceived,
        WaitForProducing,
        InProducing,
        Finished,
        Cancelled
    }
}
