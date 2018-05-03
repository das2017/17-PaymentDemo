using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CBS.Payment.DTO.Request
{
    /// <summary>
    /// 支付请求
    /// </summary>
    [DataContract]
    [Serializable]
    public class TradePayRequest : RequestBase
    {
        private string _paymethod = "directPay";
        private string _trade_type = "JSAPI";
        private string _payment_type = "1";
        /// <summary>
        /// 应用系统订单号--最长28位
        /// </summary>
        [DataMember]
        public string OutOrderNo { get; set; }
        /// <summary>
        /// 预付款订单ID
        /// </summary>
        public string OrderNo { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        [DataMember]
        public string Subject { get; set; }
        /// <summary>
        /// 商品描述
        /// </summary>
        [DataMember]
        public string Body { get; set; }
        /// <summary>
        /// 商品展示网址
        /// </summary>
        [DataMember]
        public string ShowUrl { get; set; }
        /// <summary>
        /// 交易金额（单位元，2位小数点）
        /// </summary>
        [DataMember]
        public decimal TotalFee { get; set; }
        /// <summary>
        /// 请求参数-支付类型
        /// 支付宝：默认为 1（商品购买）
        /// 微信支付： 1胜意，其他为支付中心
        /// </summary>
        [DataMember]
        public string PaymentType
        {
            get { return _payment_type; }
            set { _payment_type = value; }
        }
        /// <summary>
        /// 支付方式，默认为directPay
        /// bankPay（网银支付）
        /// directPay（余额支付）
        /// </summary>
        [DataMember]
        public string Paymethod
        {
            get { return _paymethod; }
            set { _paymethod = value; }
        }
        /// <summary>
        /// 默认网银
        /// </summary>
        [DataMember]
        public string Defaultbank { get; set; }
        /// <summary>
        /// 公用业务扩展参数
        /// </summary>
        [DataMember]
        public string Extend_param { get; set; }
        /// <summary>
        /// 用户IP（非商户服务器IP），为了防止欺诈，支付时财付通会校验此IP
        /// 财付通支付时，需提交该参数
        /// </summary>
        [DataMember]
        public string Spbill_Create_Ip { get; set; }
        /// <summary>
        /// 验签
        /// 预付款支付时，由应用系统提供
        /// </summary>
        [DataMember]
        public string Key { get; set; }
        /// <summary>
        /// 分润收款客户集
        /// </summary>
        [DataMember]
        public List<RoyaltyParameterRequest> RoyaltyParameters { get; set; }
        /// <summary>
        /// 微信支付用户标识
        /// </summary>
        [DataMember]
        public string OpenID { get; set; }

        /// <summary>
        /// 微信支付方式，默认为JSAPI 
        /// JSAPI--公众号支付、NATIVE--原生扫码支付、APP--app支付
        /// </summary>
        [DataMember]
        public string Trade_Type
        {
            get { return _trade_type; }
            set { _trade_type = value; }
        }

        /// <summary>
        /// 异步通知地址，默认为配置地址
        /// </summary>
        [DataMember]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 同步通知地址，默认为配置地址
        /// </summary>
        [DataMember]
        public string ReturnUrl { get; set; }
        
        /// <summary>
        /// 微信支付-子商户支付信息
        /// </summary>
        [DataMember]
        public PaySubMch PaySubMch { get; set; }
        /// <summary>
        /// 微信支付H5
        /// </summary>
        [DataMember]
        public PaySceneInfo PaySceneInfo { get; set; }
    }
}
