using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CBS.Payment.DTO.Request
{
    /// <summary>
    /// 转账请求
    /// </summary>
    [DataContract]
    [Serializable]
    public class TradeTransRequest:RequestBase
    {
        /// <summary>
        /// 应用系统订单号--最长24位
        /// </summary>
        [DataMember]
        public string OutOrderNo { get; set; }
        /// <summary>
        /// 付款方的支付宝账号
        /// </summary>
        [DataMember]
        public string Email { get; set; }
        /// <summary>
        /// 付款账户名
        /// 付款方的支付宝账户名
        /// </summary>
        [DataMember]
        public string AccountName { get; set; }
        /// <summary>
        /// 付款详细数据--收款方账号
        /// </summary>
        [DataMember]
        public string SellerEmail { get; set; }
        /// <summary>
        /// 付款详细数据--收款方账号姓名
        /// </summary>
        [DataMember]
        public string SellerName { get; set; }
        /// <summary>
        /// 付款详细数据--付款金额
        /// </summary>
        [DataMember]
        public decimal Fee { get; set; }
        /// <summary>
        /// 付款详细数据--备注说明
        /// </summary>
        [DataMember]
        public string Remark { get; set; }
        /// <summary>
        /// 业务扩展参数
        /// 用于商户的特定业务信息的传递，只有商户与支付宝约定了传递此参数且约定了参数含义，此参数才有效。
        /// 参数格式：参数名 1^参数值1|参数名 2^参数值 2|……多条数据用“|”间隔。
        /// </summary>
        [DataMember]
        public string ExtendParam { get; set; }
    }
}
