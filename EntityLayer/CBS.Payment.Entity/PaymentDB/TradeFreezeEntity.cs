using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBS.Payment.Entity.PaymentDB
{
    /// <summary>
    /// 冻结、解冻详情
    /// </summary>
    public class TradeFreezeEntity
    {
        /// <summary>
        /// 冻结/解冻单号
        /// </summary>
        public string FreezeNo { get; set; }
        /// <summary>
        /// 冻结/解冻账号 Email
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// 冻结/解冻金额
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// 冻结/解冻状态
        /// </summary>
        public string Status { get; set; }
    }
}
