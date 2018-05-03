using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using CBS.Payment.DB.PaymentDB;
using CBS.Payment.DTO;
using CBS.Payment.DTO.Response;
using CBS.Payment.Entity;
using CBS.Payment.Entity.PaymentDB;
using CBS.Payment.Utility;
using CBS.Payment.Entity.Model;

namespace CBS.Payment.Business
{

    public class PaymentNotifyLogic
    {
        static readonly CBS.Payment.DB.PaymentDB.PaymentDBFacade _PaymentDBFacade = new PaymentDBFacade();

        /// <summary>
        /// 支付宝支付同步返回
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public TradePayResponse AlipayPayReturn(AlipayPayReturnModel model)
        {
            TradePayResponse response = new TradePayResponse();
            return response;
        }
        /// <summary>
        /// 支付宝支付异步通知
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public TradePayResponse AlipayPayNotify(AlipayPayNotifyModel model)
        {
            TradePayResponse response = new TradePayResponse();
            return response;
        }
        /// <summary>
        /// 支付宝退款异步通知
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public TradePayResponse AlipayRefundNotify(AlipayRefundNotifyModel model)
        {
            TradePayResponse response = new TradePayResponse();
            return response;
        }
        /// <summary>
        /// 支付宝代扣异步通知
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public TradePayResponse AlipayCaeNotify(AlipayCaeNotifyModel model)
        {
            TradePayResponse response = new TradePayResponse();
            return response;
        }
        /// <summary>
        /// 支付宝转账异步通知
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public TradePayResponse AlipayTransNotify(AlipayTransNotifyModel model)
        {
            TradePayResponse response = new TradePayResponse();
            return response;
        }
        /// <summary>
        /// 支付宝冻结异步通知
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public TradePayResponse AlipayFreezeNotify(AlipayFreezeNotifyModel model)
        {
            TradePayResponse response = new TradePayResponse();
            return response;
        }
        /// <summary>
        /// 支付宝解冻异步通知
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public TradePayResponse AlipayUnFreezeNotify(AlipayUnFreezeNotifyModel model)
        {
            TradePayResponse response = new TradePayResponse();
            return response;
        }

        /// <summary>
        /// 财付通支付同步返回
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public TradePayResponse TenpayPayReturn(TenpayPayReturnModel model)
        {
            TradePayResponse response = new TradePayResponse();
            return response;
        }

        internal class NotifyType
        {
            internal static string AlipayPayReturn = "1";
            internal static string AlipayPayNotify = "2";
            internal static string AlipayCaeNotify = "3";
            internal static string AlipayRefundNotify = "5";
            internal static string AlipayTransNotify = "8";
            internal static string AlipayFreezeNotify = "9";
            internal static string AlipayUnFreezeNotify = "10";
            internal static string TenpayPayReturn = "11";
        }
    }
}
