using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBS.Payment.Alipay.Model
{
    /// <summary>
    /// 请求数据实体--冻结接口
    /// </summary>
    public class AlipayFreeze : AlipayRequestBase
    {
        /// <summary>
        /// 支付宝交易号
        /// 需要冻结的交易在支付宝系统中的交易流水号。最短 16 位，最长 64 位
        /// </summary>
        public string Trade_No { get; set; }

        /// <summary>
        /// 冻结详细数据 格式：冻结订单号^冻结账户^冻结账户ID^冻结金额
        /// </summary>
        public string Freeze_Details { get; set; }
    }
}
