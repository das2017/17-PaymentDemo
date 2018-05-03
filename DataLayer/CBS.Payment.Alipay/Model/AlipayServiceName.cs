using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBS.Payment.Alipay.Model
{
    public class AlipayServiceName
    {
        private static string _trade_pay = "create_direct_pay_by_user";
        private static string _trade_cae_pay = "cae_charge_agent";
        private static string _trade_royalty = "distribute_royalty";
        private static string _trade_refund = "refund_fastpay_by_platform_nopwd";
        private static string _trade_suppl = "trade.amount.suppl";
        private static string _trade_trans = "batch_trans_notify";
        private static string _trade_freeze = "air_trade_refund_freeze";
        private static string _trade_unfreeze = "air_trade_refund_unfreeze";
        private static string _trade_account_query = "account.page.query";

        /// <summary>
        /// 纯网关接口,即时到帐交易服务名称
        /// </summary>
        public static string Trade_Pay { get { return _trade_pay; } }
        /// <summary>
        /// 机票无密支付(CAE代扣)服务名称
        /// </summary>
        public static string Trade_CAEPay { get { return _trade_cae_pay; } }
        /// <summary>
        /// 分润接口名称
        /// </summary>
        public static string Trade_Royalty { get { return _trade_royalty; } }
        /// <summary>
        /// 无密退款--分润退款服务名称
        /// </summary>
        public static string Trade_Refund { get { return _trade_refund; } }
        /// <summary>
        /// 补差服务名称
        /// </summary>
        public static string Trade_Suppl { get { return _trade_suppl; } }
        /// <summary>
        /// 批量转账（充值）接口名称
        /// </summary>
        public static string Trade_Trans { get { return _trade_trans; } }
        /// <summary>
        /// 冻结接口名称
        /// </summary>
        public static string Trade_Freeze { get { return _trade_freeze; } }
        /// <summary>
        /// 解冻接口名称
        /// </summary>
        public static string Trade_UnFreeze { get { return _trade_unfreeze; } }
        /// <summary>
        /// 财务明细查询接口名称
        /// </summary>
        public static string Trade_Account_Query { get { return _trade_account_query; } }
    }
}
