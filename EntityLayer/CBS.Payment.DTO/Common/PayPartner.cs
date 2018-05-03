using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CBS.Payment.DTO
{
    /// <summary>
    /// 第三方支付合作者帐号资料
    /// 当使用点对点直接支付时，该类需要传入相应的合作者帐号
    /// </summary>
    [DataContract]
    [Serializable]
    public class PayPartner
    {
        /// <summary>
        /// 合作者ID
        /// </summary>
        [DataMember]
        public string PartnerID { get; set; }
        /// <summary>
        /// 合作者密钥
        /// </summary>
        [DataMember]
        public string PartnerKey { get; set; }
        /// <summary>
        /// 收款帐号
        /// </summary>
        [DataMember]
        public string SellerEmail { get; set; }
        /// <summary>
        /// 收款帐号ID
        /// </summary>
        [DataMember]
        public string SellerID { get; set; }

        /// <summary>
        /// 证书路径
        /// </summary>
        [DataMember]
        public string SslCertPath { get; set; }

        /// <summary>
        ///证书密码 
        /// </summary>
        [DataMember]
        public string SslCertPwd { get; set; }
    }
}
