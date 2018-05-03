using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CBS.Payment.DTO.Request
{
    /// <summary>
    /// 代扣请求
    /// </summary>
    [DataContract]
    [Serializable]
    public class TradeAutoPayRequest : RequestBase
    {
        /// <summary>
        /// 应用系统订单号--最长18位
        /// </summary>
        [DataMember]
        public string OutOrderNo { get; set; }
        /// <summary>
        /// 代扣金额
        /// </summary>
        [DataMember]
        public decimal Amount { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        [DataMember]
        public string Subject { get; set; }
        /// <summary>
        /// 转出帐号(Email)
        /// </summary>
        [DataMember]
        public string TransOutAccount { get; set; }
        /// <summary>
        /// 转入帐号(Email)
        /// </summary>
        [DataMember]
        public string TransInAccount { get; set; }
    }
}
