using CBS.Payment.Alipay.Model;
using CBS.Payment.DB.PaymentDB;
using CBS.Payment.DTO.Request;
using CBS.Payment.DTO.Response;
using CBS.Payment.Entity.PaymentDB;
using CBS.Payment.Utility;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace CBS.Payment.Business.ThirdPayment
{
    public class AlipayHelper
    {
        static readonly PaymentDBFacade _PaymentDBFacade = new PaymentDBFacade();
        private static string _MsgType = "sync";
        /// <summary>
        /// 支付远程调用
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static AlipayResponseBase<Alipay.Model.AlipayPay> TradePay(string payNo,TradePayRequest request, AccountEntity accountEntity)
        {
           
            AlipayPay alipayRequestModel = new AlipayPay();
            AlipayResponseBase<AlipayPay> alipayResponseModel = new AlipayResponseBase<AlipayPay>();          
            return alipayResponseModel;
        }
        /// <summary>
        /// 代扣远程调用
        /// </summary>
        /// <param name="request"></param>
        /// <param name="accountEntity"></param>
        /// <returns></returns>
        public static AlipayResponseBase<AlipayCaePayResult> TradeAutoPay(string payNo, TradeAutoPayRequest request, AccountEntity accountEntity)
        {
            AlipayResponseBase<AlipayCaePayResult> alipayResponseModel = new AlipayResponseBase<AlipayCaePayResult>();
           
            return alipayResponseModel;
        }
        /// <summary>
        /// 补差远程调用
        /// </summary>
        /// <param name="request"></param>
        /// <param name="accountEntity"></param>
        /// <returns></returns>
        public static AlipayResponseBase<AlipaySuppl> TradeSuppl(string payNo, TradeSupplRequest request, AccountEntity accountEntity)
        {
            AlipayResponseBase<AlipaySuppl> alipayResponseModel = new AlipayResponseBase<AlipaySuppl>();
            
            return alipayResponseModel;
        }
        /// <summary>
        /// 分润远程调用
        /// </summary>
        /// <param name="payNo"></param>
        /// <param name="request"></param>
        /// <param name="accountEntity"></param>
        /// <returns></returns>
        public static AlipayResponseBase<AlipayRoyalty> TradeRoyalty(string payNo, TradeRoyaltyRequest request, AccountEntity accountEntity)
        {
            AlipayResponseBase<AlipayRoyalty> alipayResponseModel = new AlipayResponseBase<AlipayRoyalty>();
           
            return alipayResponseModel;
        }
        /// <summary>
        /// 退款远程调用
        /// </summary>
        /// <param name="payNo"></param>
        /// <param name="request"></param>
        /// <param name="accountEntity"></param>
        /// <returns></returns>
        public static AlipayResponseBase<AlipayRefund> TradeRefund(string payNo, TradeRefundRequest request, AccountEntity accountEntity)
        {
            AlipayResponseBase<AlipayRefund> alipayResponseModel = new AlipayResponseBase<AlipayRefund>();
           
            return alipayResponseModel;
        }
        /// <summary>
        /// 转账远程调用
        /// </summary>
        /// <param name="payNo"></param>
        /// <param name="request"></param>
        /// <param name="accountEntity"></param>
        /// <returns></returns>
        public static AlipayResponseBase<AlipayTrans> TradeTrans(string payNo, TradeTransRequest request, AccountEntity accountEntity)
        {
            AlipayResponseBase<AlipayTrans> alipayResponseModel = new AlipayResponseBase<AlipayTrans>();
           
            return alipayResponseModel;
        }
        /// <summary>
        /// 冻结远程调用
        /// </summary>
        /// <param name="payNo"></param>
        /// <param name="request"></param>
        /// <param name="accountEntity"></param>
        /// <returns></returns>
        public static AlipayResponseBase<AlipayFreeze> TradeFreeze(string payNo, TradeFreezeRequest request, AccountEntity accountEntity)
        {
            AlipayResponseBase<AlipayFreeze> alipayResponseModel = new AlipayResponseBase<AlipayFreeze>();
           
            return alipayResponseModel;
        }
        /// <summary>
        /// 解冻远程调用
        /// </summary>
        /// <param name="payNo"></param>
        /// <param name="request"></param>
        /// <param name="accountEntity"></param>
        /// <returns></returns>
        public static AlipayResponseBase<AlipayUnFreeze> TradeUnFreeze(string payNo, TradeUnFreezeRequest request, AccountEntity accountEntity)
        {
            AlipayResponseBase<AlipayUnFreeze> alipayResponseModel = new AlipayResponseBase<AlipayUnFreeze>();
          
            return alipayResponseModel;
        }

    }
}
