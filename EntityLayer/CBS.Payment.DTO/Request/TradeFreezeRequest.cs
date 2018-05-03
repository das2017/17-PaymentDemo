using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CBS.Payment.DTO.Request
{
    /// <summary>
    /// 冻结请求
    /// </summary>
    [DataContract]
    [Serializable]
    public class TradeFreezeRequest:RequestBase
    {
        /// <summary>
        /// 交易号
        /// 最短 16 位，最长 64 位
        /// </summary>
        [DataMember]
        public string TradeNo { get; set; }

        /// <summary>
        /// 冻结详细数据
        /// </summary>
        [DataMember]
        public List<FreezeParameterRequest> Details { get; set; }
    }
}
