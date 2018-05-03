using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;

namespace CBS.Payment.Business
{
    public class PaymentHelper
    {
        private static string _SystemID = ConfigurationManager.AppSettings["SystemID"];
        private static int _tenPayRefundSN = 0;
        private static readonly object Locker = new object();
        /// <summary>
        /// 支付中心唯一ID
        /// </summary>
        /// <param name="payIdentity"></param>
        /// <returns></returns>
        public static string GenPayNo(string payIdentity)
        {
            DateTime now = DateTime.Now;
            DateTime startTime = Convert.ToDateTime(now.Year + "-" + now.Month + "-" + now.Day + " " + now.Hour + ":" + now.Minute + ":" + now.Second);
            return payIdentity + now.ToString("yyyyMMddHHmmss") +(Convert.ToInt16(_SystemID+ "000") + (int)(now - startTime).TotalMilliseconds).ToString();
        }
        /// <summary>
        /// 财付通退款ID
        /// </summary>
        /// <param name="refundIdentity"></param>
        /// <returns></returns>
        public static string GenTenpayRefundNo(string refundIdentity)
        {
            lock (Locker)
            {
                if (_tenPayRefundSN == 99)
                {
                    _tenPayRefundSN = 1;
                }
                else
                {
                    _tenPayRefundSN++;
                }
                Thread.Sleep(100);
                return "109" + refundIdentity + DateTime.Now.ToString("yyMMddHHmmss") + _SystemID + _tenPayRefundSN.ToString().PadLeft(2, '0');
            }
        }      
    }
}
