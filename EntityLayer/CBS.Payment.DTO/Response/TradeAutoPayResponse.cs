using CBS.Payment.DTO.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CBS.Payment.DTO.Response
{
    /// <summary>
    /// 代扣结果
    /// </summary>
    [DataContract]
    [Serializable]
    public class TradeAutoPayResponse:ResponseBase
    {
        /// <summary>
        /// 交易流水号
        /// </summary>
        [DataMember]
        public string TradeNo { get; set; }
        /// <summary>
        /// 支付请求数据实体
        /// </summary>
        [DataMember]
        public TradeAutoPayRequest autoPayRequest { get; set; }
    }
}
