using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Xml;

namespace CBS.Payment.Tenpay
{
    public class TenpayCommon
    {

        /// <summary>
        /// 支付通知页面路径
        /// </summary>
        public static string Pay_Return_url = "";//"http://testpay.test.***/payNotify/tenpay/TradePay_Return.aspx";

        /// <summary>
        /// 分润通知路径
        /// </summary>
        public static string Royalty_Return_url = "http://127.0.0.1/";

        /// <summary>
        /// 分润退款通知路径
        /// </summary>
        public static string RoyaltyRollBack_Return_url = "http://127.0.0.1/";

        /// <summary>
        /// 退款通知路径
        /// </summary>
        public static string Refund_Return_url = "http://127.0.0.1/";

        static TenpayCommon()
        {
            if (ConfigurationManager.AppSettings["Tenpay_PayReturn_Url"] != null)
            {
                Pay_Return_url = ConfigurationManager.AppSettings["Tenpay_PayReturn_Url"];
            }
        }

    
    }
}
