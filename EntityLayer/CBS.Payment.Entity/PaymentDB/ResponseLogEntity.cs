using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBS.Payment.Entity.PaymentDB
{
    /// <summary>
    /// 支付平台响应日志表
    /// </summary>
    public class ResponseLogEntity
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
        /// 响应详细信息
        /// </summary>
        public string ResponseDetail { get; set; }
        /// <summary>
        /// 响应时间
        /// </summary>
        public Nullable<DateTime> ResponseDate { get; set; }
    }
}
