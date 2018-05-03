using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBS.Payment.Alipay.Model
{
    /// <summary>
    /// 请求数据实体--机票无密支付(CAE代扣)
    /// </summary>
    public class AlipayCaePay : AlipayRequestBase
    {
        /// <summary>
        /// 请求参数-商户网站唯一订单号
        /// </summary>
        public string Out_trade_no { get; set; }

        /// <summary>
        /// 请求参数-金额
        /// </summary>
        public string Amount { get; set; }

        /// <summary>
        /// 请求参数-支付宝标题
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// 请求参数-代理业务编码,合作者ID+1000310004
        /// </summary>
        public string Type_code { get; set; }

        /// <summary>
        /// 请求参数-转出支付宝帐号
        /// user_id+0156，该字段还可传递支付宝登录账户（邮箱或手机号）
        /// </summary>
        public string Trans_account_out { get; set; }

        /// <summary>
        /// 转入支付宝帐号(平台收款帐号)
        /// user_id+0156，该字段还可传递支付宝登录账户（邮箱或手机号）
        /// </summary>
        public string Trans_account_in { get; set; }

        /// <summary>
        /// 请求参数-商户订单创建时间yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string Gmt_out_order_create { get; set; }

        /// <summary>
        /// 请求参数-代扣模式
        /// 机票代扣时走的是交易模式（trade 模式），传其他值无效。
        /// </summary>
        public string Charge_type { get; set; }

        /// <summary>
        /// 请求参数-分账类型:10(卖家给第三方提成)
        /// </summary>
        public string Royalty_type { get; set; }

        /// <summary>
        /// 请求参数-分账参数:收款方帐号^金额^备注|收款方帐号2^金额2^备注2
        /// </summary>
        public string Royalty_parameters { get; set; }
    }
}
