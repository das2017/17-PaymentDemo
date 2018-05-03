using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBS.Payment.Alipay.Model
{
    /// <summary>
    /// 请求数据实体--子交易补差
    /// </summary>
    public class AlipaySuppl : AlipayRequestBase
    {
        /// <summary>
        /// 请求参数-商户网站唯一订单号
        /// </summary>
        public string Out_trade_no { get; set; }

        /// <summary>
        /// 请求参数-交易号
        /// </summary>
        public string Trade_no { get; set; }

        /// <summary>
        /// 请求参数-子交易商户网站订单号
        /// </summary>
        public string Out_suppl_no { get; set; }

        /// <summary>
        /// 请求参数-子交易金额
        /// </summary>
        public string Suppl_amount { get; set; }

        /// <summary>
        /// 总补差金额
        /// </summary>
        public string Total_suppl_amount { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        public string Trade_amount { get; set; }

    }
}
