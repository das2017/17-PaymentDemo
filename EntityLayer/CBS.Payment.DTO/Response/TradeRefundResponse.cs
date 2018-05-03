using CBS.Payment.DTO.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CBS.Payment.DTO.Response
{
    /// <summary>
    /// 退款结果
    /// </summary>
    [DataContract]
    [Serializable]
    public class TradeRefundResponse:ResponseBase
    {
        /// <summary>
        /// 支付请求数据实体
        /// </summary>
        [DataMember]
        public TradeRefundRequest refundRequest { get; set; }
    }
}
