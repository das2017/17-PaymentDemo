using CBS.Payment.DTO.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CBS.Payment.DTO.Response
{
    /// <summary>
    /// 支付结果
    /// </summary>
    [DataContract]
    [Serializable]
    public class TradeTransResponse:ResponseBase
    {
        /// <summary>
        /// 批量转账请求数据实体
        /// </summary>
        [DataMember]
        public TradeTransRequest transRequest { get; set; }
        /// <summary>
        /// 请求连接
        /// </summary>
        [DataMember]
        public string RequestUrl { get; set; }
    }
}
