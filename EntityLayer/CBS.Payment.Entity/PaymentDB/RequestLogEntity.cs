using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBS.Payment.Entity.PaymentDB
{
    /// <summary>
    /// 支付平台请求日志表
    /// </summary>
    public class RequestLogEntity
    {
        /// <summary>
        /// 自增长编号
        /// </summary>
        public int LogID { get; set; }
        /// <summary>
        /// 应用系统ID
        /// </summary>
        public string AppID { get; set; }
        /// <summary>
        /// 平台分配的账号
        /// </summary>
        public string PayAccount { get;set; }
        /// <summary>
        /// 合作者ID
        /// </summary>
        public string PartnerID { get; set; }
        /// <summary>
        /// 合作者密钥
        /// </summary>
        public string PartnerKey { get; set; }
        /// <summary>
        /// 收款帐号
        /// </summary>
        public string SellerEmail { get; set; }
        /// <summary>
        /// 收款帐号ID
        /// </summary>
        public string SellerID { get; set; }
        /// <summary>
        /// 平台分配的唯一流水号
        /// </summary>
        public string PayNo { get; set; }
        /// <summary>
        /// 交易类型:支付宝(A1支付 A2代扣 A3补差 A4分润 A5退款 A6转账 A7冻结 A8解冻)，财付通(T1支付 T2分润 T3退分润 T4退款)
        /// </summary>
        public string PayType { get; set; }
        /// <summary>
        /// 应用系统唯一标识号
        /// </summary>
        public string OutNo { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string Subject { get; set; }
        /// <summary>
        /// 商品描述
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// 请求详细信息
        /// </summary>
        public string RequestDetail { get; set; }
        /// <summary>
        /// 请求时间
        /// </summary>
        public Nullable<DateTime> RequestDate { get; set; }

        /// <summary>
        /// 异步通知地址，默认为配置地址
        /// </summary>
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 同步通知地址，默认为配置地址
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        /// 子商户公众号
        /// </summary>
        public string SubAppID { get; set; }
        /// <summary>
        /// 子商户号
        /// </summary>
        public string SubMchID { get; set; }
        /// <summary>
        /// 子用户标识
        /// </summary>
        public string SubOpenID { get; set; }
    }
}
