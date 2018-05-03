using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CBS.Payment.DTO.Request
{
    /// <summary>
    /// 分润请求
    /// </summary>
    [DataContract]
    [Serializable]
    public class TradeRoyaltyRequest:RequestBase
    {
        /// <summary>
        /// 请求参数-原交易号
        /// </summary>
        [DataMember]
        public string TradeNo { get; set; }
        /// <summary>
        /// 分润单号
        /// </summary>
        [DataMember]
        public string BillNo { get; set; }
        /// <summary>
        /// 总金额:以元为单位
        /// </summary>
        [DataMember]
        public decimal TotalFee { get; set; }
        /// <summary>
        /// 分账参数
        /// 提供：收款方帐号 金额 备注
        /// </summary>
        [DataMember]
        public List<RoyaltyParameterRequest> RoyaltyParameters { get; set; }
        /// <summary>
        /// 业务描述，特定格式的字符串，格式为：PNR^航程^机票张数^机票销售商在机票平台的id^联系人姓名^联系电话
        /// </summary>
        [DataMember]
        public string Desc { get; set; }
        /// <summary>
        /// 验签
        /// 预付款支付时，由应用系统提供
        /// </summary>
        [DataMember]
        public string Key { get; set; }
        /// <summary>
        /// 预付款支付方式
        /// </summary>
        [DataMember]
        public string PaymentType { get; set; }
    }
}
