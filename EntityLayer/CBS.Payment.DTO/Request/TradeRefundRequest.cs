using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CBS.Payment.DTO.Request
{
    /// <summary>
    /// 退款请求
    /// </summary>
    [DataContract]
    [Serializable]
    public class TradeRefundRequest:RequestBase
    {
        /// <summary>
        /// 交易流水号
        /// </summary>
        [DataMember]
        public string TradeNo { get; set; }
        /// <summary>
        /// 订单号:商户系统内部的定单号
        /// </summary>
        [DataMember]
        public string OutOrderNo { get; set; }
        /// <summary>
        /// 退款账户（Email）
        /// </summary>
        [DataMember]
        public string RefundAccount { get; set; }
        /// <summary>
        /// 总金额:以元为单位
        /// </summary>
        [DataMember]
        public decimal TotalFee { get; set; }
        /// <summary>
        /// 退款金额
        /// </summary>
        [DataMember]
        public decimal RefundFee { get; set; }
        /// <summary>
        /// 退款理由
        /// </summary>
        [DataMember]
        public string RefundReason { get; set; }
        /// <summary>
        /// 退补差金额
        /// </summary>
        [DataMember]
        public decimal SupplFee { get; set; }
        /// <summary>
        /// 退补差理由 
        /// </summary>
        [DataMember]
        public string SupplReason { get; set; }
        /// <summary>
        /// 退分润明细
        /// </summary>
        [DataMember]
        public List<RoyaltyParameterRequest> Para { get; set; }
        /// <summary>
        /// 退款说明信息
        /// </summary>
        [DataMember]
        public string RefundDesc { get; set; }

        /// <summary>
        /// 支付类型
        /// </summary>
        public string PaymentType { get; set; }
        /// <summary>
        /// 验签
        /// 预付款支付时，由应用系统提供
        /// </summary>
        [DataMember]
        public string Key { get; set; }
        /// <summary>
        /// 异步通知地址，默认为配置地址
        /// </summary>
        [DataMember]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Subject { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// IP
        /// </summary>
        public string Spbill_Create_Ip { get; set; }

        /// <summary>
        /// 微信支付-子商户支付信息
        /// </summary>
        [DataMember]
        public PaySubMch PaySubMch { get; set; }
    }
}
