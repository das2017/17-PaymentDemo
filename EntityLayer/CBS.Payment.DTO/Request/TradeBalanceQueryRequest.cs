using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CBS.Payment.DTO.Request
{
    /// <summary>
    /// 余额查询请求
    /// </summary>
    [DataContract]
    [Serializable]
    public class TradeBalanceQueryRequest:RequestBase
    {
        /// <summary>
        /// 验签
        /// 预付款支付时，由应用系统提供
        /// </summary>
        [DataMember]
        public string Key { get; set; }
    }
}
