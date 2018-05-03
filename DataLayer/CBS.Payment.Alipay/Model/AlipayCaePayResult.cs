using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBS.Payment.Alipay.Model
{
    /// <summary>
    /// 响应数据实体--机票无密支付(CAE代扣)
    /// </summary>
    public class AlipayCaePayResult
    {
        ///// <summary>
        ///// 平台分配的账号
        ///// </summary>
        //public string PaymentAccount { get; set; }
        ///// <summary>
        ///// 平台分配的唯一流水号
        ///// </summary>
        //public string PaymentNo { get; set; }

        /// <summary>
        /// 商户网站唯一订单号
        /// </summary>
        public string Out_trade_no { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// 卖方帐号
        /// </summary>
        public string Seller_email { get; set; }

        /// <summary>
        /// 买家帐号
        /// </summary>
        public string Buyer_email { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        public string Total_fee { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// 交易创建时间
        /// </summary>
        public string Gmt_Create { get; set; }

        /// <summary>
        /// 交易付款时间
        /// </summary>
        public string Gmt_payment { get; set; }
    }
}
