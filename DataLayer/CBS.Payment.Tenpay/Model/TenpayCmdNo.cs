using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBS.Payment.Tenpay.Model
{
    public class TenpayCmdNo
    {
        private static string _trade_pay = "1";
        private static string _trade_royalty = "3";
        private static string _trade_royaltyRollBack = "95";
        private static string _trade_refund = "93";
        

        /// <summary>
        /// 纯网关接口名称
        /// </summary>
        public static string Trade_Pay { get { return _trade_pay; } }
        /// <summary>
        /// 分润接口名称
        /// </summary>
        public static string Trade_Royalty { get { return _trade_royalty; } }
        /// <summary>
        /// 分润退款接口名称
        /// </summary>
        public static string Trade_RoyaltyRollBack { get { return _trade_royaltyRollBack; } }
        /// <summary>
        /// 退款接口名称
        /// </summary>
        public static string Trade_Refund { get { return _trade_refund; } }

    }
}
