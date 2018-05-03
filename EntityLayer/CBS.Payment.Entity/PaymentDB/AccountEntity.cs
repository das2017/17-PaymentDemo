using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBS.Payment.Entity.PaymentDB
{
    /// <summary>
    /// 平台支付账号信息
    /// </summary>
    public class AccountEntity
    {
        /// <summary>
        /// 自增长编号
        /// </summary>
        public int AccountID { get; set; }
        /// <summary>
        /// 平台分配的账号
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// 账号描述
        /// </summary>
        public string AccountName { get; set; }
        /// <summary>
        /// 账号类型：1 支付宝，2财付通
        /// </summary>
        public string AccountType { get; set; }
        /// <summary>
        /// 合作者身份ID(支付宝)/商家的商户号(财付通)
        /// </summary>
        public string Partner { get; set; }

        /// <summary>
        /// 支付宝/财付通--密钥
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 支付宝--收款支付宝账号
        /// </summary>
        public string Seller_Email { get; set; }

        /// <summary>
        /// 支付宝--收款支付宝账号ID
        /// </summary>
        public string Seller_Id { get; set; }

        /// <summary>
        /// 财付通--证书路径
        /// </summary>
        public string CertPath { get; set; }

        /// <summary>
        /// 财付通--证书密码
        /// </summary>
        public string CertPassword { get; set; }

        /// <summary>
        /// 账号状态： 0 停用，1 启用
        /// </summary>
        public string Status { get; set; }
    }
}
