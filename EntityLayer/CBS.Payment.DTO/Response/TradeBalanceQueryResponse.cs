using CBS.Payment.DTO.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CBS.Payment.DTO.Response
{
    /// <summary>
    /// 余额查询结果
    /// </summary>
    [DataContract]
    [Serializable]
    public class TradeBalanceQueryResponse:ResponseBase
    {
        /// <summary>
        /// 余额
        /// </summary>
        [DataMember]
        public decimal Amount { get; set; }
        /// <summary>
        /// 请求实体
        /// </summary>
        [DataMember]
        public TradeBalanceQueryRequest queryRequest { get; set; }
    }
}
