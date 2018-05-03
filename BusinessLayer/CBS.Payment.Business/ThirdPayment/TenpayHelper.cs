using CBS.Payment.Alipay.Model;
using CBS.Payment.DB.PaymentDB;
using CBS.Payment.DTO.Request;
using CBS.Payment.Entity.PaymentDB;
using CBS.Payment.Tenpay.Model;
using CBS.Payment.Utility;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace CBS.Payment.Business.ThirdPayment
{
    public class TenpayHelper
    {
        static readonly PaymentDBFacade _PaymentDBFacade = new PaymentDBFacade();
        private static string _MsgType = "sync";
        /// <summary>
        /// 支付远程调用
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static TenpayResponseBase<TenpayPay> TradePay(string payNo, TradePayRequest request, AccountEntity accountEntity)
        {
            TenpayPay tenpayRequestModel = new TenpayPay();
            TenpayResponseBase<TenpayPay> tenpayResponseModel = new TenpayResponseBase<TenpayPay>();
           
            return tenpayResponseModel;
        }
        /// <summary>
        /// 分润远程调用
        /// </summary>
        /// <param name="payNo"></param>
        /// <param name="request"></param>
        /// <param name="accountEntity"></param>
        /// <returns></returns>
        public static TenpayResponseBase<TenpayRoyalty> TradeRoyalty(string payNo, TradeRoyaltyRequest request, AccountEntity accountEntity)
        {
            TenpayResponseBase<TenpayRoyalty> tenpayResponseModel = new TenpayResponseBase<TenpayRoyalty>();
           
            return tenpayResponseModel;
        }
        /// <summary>
        /// 退款远程调用
        /// </summary>
        /// <param name="payNo"></param>
        /// <param name="request"></param>
        /// <param name="accountEntity"></param>
        /// <returns></returns>
        public static TenpayResponseBase<TenpayRefund> TradeRefund(string payNo, TradeRefundRequest request, AccountEntity accountEntity)
        {
            TenpayResponseBase<TenpayRefund> tenpayResponseModel = new TenpayResponseBase<TenpayRefund>();
            
            return tenpayResponseModel;
        }
        /// <summary>
        /// 分润退款远程调用
        /// </summary>
        /// <param name="payNo"></param>
        /// <param name="request"></param>
        /// <param name="accountEntity"></param>
        /// <returns></returns>
        public static TenpayResponseBase<TenpayRefund> TradeRoyaltyRefund(string payNo, TradeRefundRequest request, AccountEntity accountEntity)
        {
            TenpayResponseBase<TenpayRefund> tenpayResponseModel = new TenpayResponseBase<TenpayRefund>();
           
            return tenpayResponseModel;
        }
    }
}
