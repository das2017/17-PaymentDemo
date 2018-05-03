using CBS.Payment.DTO.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CBS.Payment.DTO.Response
{
    /// <summary>
    /// 分润结果
    /// </summary>
    [DataContract]
    [Serializable]
    public class TradeRoyaltyResponse:ResponseBase
    {
        /// <summary>
        /// 分润请求数据实体
        /// </summary>
        [DataMember]
        public TradeRoyaltyRequest royaltyRequest { get; set; }
    }
}
