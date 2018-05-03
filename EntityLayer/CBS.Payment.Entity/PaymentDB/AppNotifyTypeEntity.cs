using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBS.Payment.Entity.PaymentDB
{
    public enum AppNotifyTypeEntity
    {
        /// <summary>
        /// 支付宝支付同步返回 1
        /// </summary>
        AlipayPayReturn,
        /// <summary>
        /// 支付宝支付异步通知 2
        /// </summary>
        AlipayPay,
        /// <summary>
        /// 支付宝代扣异步通知 3
        /// </summary>
        AlipayCaePay,
        /// <summary>
        /// 支付宝退款异步通知 4
        /// </summary>
        AlipayRefund,
        /// <summary>
        /// 到卡异步通知 5
        /// </summary>
        AlipayDback,
        /// <summary>
        /// 支付宝补差异步通知 6
        /// </summary>
        AlipaySuppl,
        /// <summary>
        /// 支付宝分润异步通知 7
        /// </summary>
        AlipayRoyalty,
        /// <summary>
        /// 支付宝转账异步通知 8
        /// </summary>
        AlipayTrans,
        /// <summary>
        /// 支付宝冻结异步通知 9
        /// </summary>
        AlipayFreeze,
        /// <summary>
        /// 支付宝解冻异步通知 10
        /// </summary>
        AlipayUnFreeze,
        /// <summary>
        /// 财付通支付同步返回 11
        /// </summary>
        TenpayReturn
    }
}
