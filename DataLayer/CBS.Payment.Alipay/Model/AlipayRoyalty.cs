using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBS.Payment.Alipay.Model
{
    /// <summary>
    /// 请求数据实体--分润接口
    /// </summary>
    public class AlipayRoyalty : AlipayRequestBase
    {
        /// <summary>
        /// 请求参数-商户网站唯一订单号
        /// </summary>
        public string Out_trade_no { get; set; }

        /// <summary>
        /// 请求参数-支付宝交易号
        /// </summary>
        public string Trade_no { get; set; }

        /// <summary>
        /// 请求参数-分润批次号
        /// </summary>
        public string Out_bill_no { get; set; }

        /// <summary>
        /// 请求参数-分账类型:10(卖家给第三方提成)
        /// </summary>
        public string Royalty_type { get; set; }

        /// <summary>
        /// 请求参数-分账参数
        /// 格式：收款方帐号^金额^备注|收款方帐号2^金额2^备注2
        /// </summary>
        public string Royalty_parameters { get; set; }

    }
}
