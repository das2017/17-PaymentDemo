using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CBS.Payment.DTO
{
    /// <summary>
    /// 请求基类
    /// </summary>
    [DataContract]
    [Serializable]
    public class RequestBase
    {
        /// <summary>
        /// 支付渠道
        /// </summary>
        [DataMember]
        public PayChannels payChannels { get; set; }
        /// <summary>
        /// 第三方支付合作者帐号资料
        /// </summary>
        [DataMember]
        public PayPartner payPartner { get; set; }
        /// <summary>
        /// 请求参数-应用平台ID
        /// </summary>
        [DataMember]
        public string AppID { get; set; }
        /// <summary>
        /// 平台账号，由平台分配
        /// 对应每一个与第三方支付公司签约的商户
        /// 预付款支付时，为付款客户ID，由应用系统提供
        /// </summary>
        [DataMember]
        public string PayAccount { get; set; }
        /// <summary>
        /// 支付平台分配的唯一支付号
        /// </summary>
        [DataMember]
        public string PayNo { get; set; }
    }
}
