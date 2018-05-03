using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBS.Payment.Alipay.Model
{
    /// <summary>
    /// 请求数据实体--纯网关接口,即时到帐交易接口
    /// </summary>
    public class AlipayPay : AlipayRequestBase
    {
        /// <summary>
        /// 请求参数-商户网站唯一订单号
        /// </summary>
        public string Out_trade_no { get; set; }

        /// <summary>
        /// 请求参数-商品名称
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// 请求参数-商品描述
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// 请求参数-商品展示网址
        /// </summary>
        public string Show_url { get; set; }

        /// <summary>
        /// 请求参数-交易金额
        /// </summary>
        public string Total_fee { get; set; }

        /// <summary>
        /// 请求参数-支付类型
        /// 1（商品购买）
        /// </summary>
        public string Payment_type { get; set; }

        /// <summary>
        /// 请求参数-默认支付方式
        /// bankPay（网银支付）
        /// directPay（余额支付）
        /// </summary>
        public string Paymethod { get; set; }

        /// <summary>
        /// 请求参数-默认网银
        /// </summary>
        public string Defaultbank { get; set; }

        /// <summary>
        /// 卖家支付宝账号
        /// </summary>
        public string Seller_email { get; set; }

        /// <summary>
        /// 卖家支付宝账户号
        /// </summary>
        public string Seller_id { get; set; }

        /// <summary>
        /// 请求参数-提成(分账)类型:10(卖家给第三方提成)
        /// </summary>
        public string Royalty_type { get; set; }

        /// <summary>
        /// 请求参数-分润账号集，参数:收款方帐号^金额^备注|收款方帐号2^金额2^备注2
        /// </summary>
        public string Royalty_parameters { get; set; }

        /// <summary>
        /// 请求参数-公用业务扩展参数
        /// </summary>
        public string Extend_param { get; set; }

        /// <summary>
        /// 请求参数-超时时间
        /// </summary>
        public string It_b_pay { get; set; }
    }
}
