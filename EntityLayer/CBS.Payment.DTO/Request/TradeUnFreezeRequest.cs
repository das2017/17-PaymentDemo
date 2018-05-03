using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CBS.Payment.DTO.Request
{
    /// <summary>
    /// 解冻请求
    /// </summary>
    [DataContract]
    [Serializable]
    public class TradeUnFreezeRequest:RequestBase
    {
        /// <summary>
        /// 交易号
        /// 最短 16 位，最长 64 位
        /// </summary>
        [DataMember]
        public string TradeNo { get; set; }
        /// <summary>
        /// 解冻详细数据
        /// </summary>
        [DataMember]
        public List<FreezeParameterRequest> Details { get; set; }
    }
}
