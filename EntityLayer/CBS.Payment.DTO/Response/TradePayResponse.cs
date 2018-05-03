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
    public class TradePayResponse:ResponseBase
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
        public TradePayRequest payRequest { get; set; }
        /// <summary>
        /// 请求连接
        /// </summary>
        [DataMember]
        public string RequestUrl { get; set; }
        /// <summary>
        /// 异步通知
        /// </summary>
        [DataMember]
        public string NotifyUrl { get; set; }
    }
}
