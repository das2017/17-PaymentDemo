using CBS.Payment.DTO.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CBS.Payment.DTO.Response
{
    /// <summary>
    /// 解冻结果
    /// </summary>
    [DataContract]
    [Serializable]
    public class TradeUnFreezeResponse:ResponseBase
    {
        /// <summary>
        /// 请求数据实体
        /// </summary>
        [DataMember]
        public TradeUnFreezeRequest unFreezeRequest { get; set; }
    }
}
