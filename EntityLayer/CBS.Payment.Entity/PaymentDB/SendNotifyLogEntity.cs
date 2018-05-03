using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBS.Payment.Entity.PaymentDB
{
    /// <summary>
    /// 支付平台通知应用系统日志表
    /// </summary>
    public class SendNotifyLogEntity
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
        public string PayAccount { get; set; }
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
        /// 接收通知的详细信息
        /// </summary>
        public string ResponseDetail { get; set; }
        /// <summary>
        /// 接收时间
        /// </summary>
        public Nullable<DateTime> NotifyDate { get; set; }
    }
}
