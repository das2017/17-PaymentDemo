using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CBS.Payment.DTO.Request
{
    /// <summary>
    /// 分润详情
    /// </summary>
    [DataContract]
    [Serializable]
    public class RoyaltyParameterRequest
    {
        /// <summary>
        /// 转出人支付宝账号（Email）
        /// </summary>
        [DataMember]
        public string TransIn { get; set; }
        /// <summary>
        /// 转入人支付宝账号(Email)
        /// </summary>
        [DataMember]
        public string TransOut { get; set; }
        /// <summary>
        /// 分润客户ID
        /// </summary>
        [DataMember]
        public string RoyClientID { get; set; }
        /// <summary>
        /// 分润金额
        /// </summary>
        [DataMember]
        public decimal RoyMoney { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [DataMember]
        public string Remark { get; set; }
        /// <summary>
        /// 1:供应商 2:平台服务方 3:资金清算方 4:独立分润方
        ///注意：bus_args中必须有一个供应商的角色，而且只允许有一个供应商
        /// </summary>
        [DataMember]
        public string RoleID { get; set; }
    }
}
