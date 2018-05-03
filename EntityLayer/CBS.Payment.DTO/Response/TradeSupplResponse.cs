using CBS.Payment.DTO.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CBS.Payment.DTO.Response
{
    /// <summary>
    /// 补差结果
    /// </summary>
    [DataContract]
    [Serializable]
    public class TradeSupplResponse:ResponseBase
    {
        /// <summary>
        /// 补差请求数据实体
        /// </summary>
        [DataMember]
        public TradeSupplRequest supplRequest { get; set; }
    }
}
