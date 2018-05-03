using CBS.Payment.DTO.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CBS.Payment.DTO.Response
{
    /// <summary>
    /// 冻结结果
    /// </summary>
    [DataContract]
    [Serializable]
    public class TradeFreezeResponse:ResponseBase
    {
        /// <summary>
        /// 冻结请求数据实体
        /// </summary>
        [DataMember]
        public TradeFreezeRequest freezeRequest { get; set; }
    }
}
