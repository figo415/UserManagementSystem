using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.Enums
{
    /// <summary>
    /// 订单状态
    /// </summary>
    public enum OrderStatusEnum
    {
        OrderReceived,
        WaitForProducing,
        InProducing,
        Finished,
        Cancelled
    }
}
