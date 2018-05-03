using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CBS.Payment.DTO.Request
{
    /// <summary>
    /// 补差请求
    /// </summary>
    [DataContract]
    [Serializable]
    public class TradeSupplRequest:RequestBase
    {
        /// <summary>
        /// 交易号
        /// </summary>
        [DataMember]
        public string TradeNo { get; set; }
        /// <summary>
        /// 交易金额
        /// </summary>
        [DataMember]
        public decimal SupplAmount { get; set; }
    }
}
