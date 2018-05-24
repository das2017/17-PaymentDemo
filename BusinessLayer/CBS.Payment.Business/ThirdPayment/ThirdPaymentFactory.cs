using CBS.Payment.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBS.Payment.Business.ThirdPayment
{
    public class ThirdPaymentFactory
    {
        public static IPaymentService Create(PayChannels channels)
        {
            if (channels.ToString().Equals("alipay", StringComparison.OrdinalIgnoreCase))
            {
                return new ThirdPayment.AlipayLogic();
            }
            if (channels.ToString().Equals("tenpay", StringComparison.OrdinalIgnoreCase))
            {
                return new ThirdPayment.TenpayLogic();
            }

            throw new NotImplementedException();
        }
    }
}
