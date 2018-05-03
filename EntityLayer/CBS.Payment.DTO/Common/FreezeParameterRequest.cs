using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CBS.Payment.DTO.Request
{
    /// <summary>
    /// 冻结详情
    /// </summary>
    [DataContract]
    [Serializable]
    public class FreezeParameterRequest
    {
        /// <summary>
        /// 冻结单号
        /// </summary>
        [DataMember]
        public string FreezeNo { get; set; }
        /// <summary>
        /// 冻结/解冻账号 Email
        /// </summary>
        [DataMember]
        public string Account { get; set; }
        /// <summary>
        /// 冻结/解冻金额
        /// </summary>
        [DataMember]
        public decimal Amount { get; set; }
        /// <summary>
        /// 冻结状态
        /// </summary>
        [DataMember]
        public string Status { get; set; }
    }
}
