using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CBS.Payment.DTO
{
    /// <summary>
    /// 响应基类
    /// </summary>
    [DataContract]
    [Serializable]
    public class ResponseBase
    {
        public ResponseBase() { Message = string.Empty; }
        /// <summary>
        /// 处理结果状态 T 成功，F 失败
        /// </summary>
        [DataMember]
        public string Status { get; set; }
        /// <summary>
        /// 处理结果描述
        /// </summary>
        [DataMember]
        public string Message { get; set; }
        /// <summary>
        /// 支付平台分配的唯一支付号
        /// </summary>
        [DataMember]
        public string PayNo { get; set; }
    }
}
