using CBS.Payment.Alipay.Model;
using CBS.Payment.DTO.Request;
using CBS.Payment.DTO.Response;
using CBS.Payment.Tenpay.Model;
using CBS.Payment.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBS.Payment.Business.ThirdPayment
{
    public class TenpayLogic : IPaymentService
    {
        public TradePayResponse TradePay(TradePayRequest request)
        {
            TenpayResponseBase<TenpayPay> tenpayResponseModel = new TenpayResponseBase<TenpayPay>();
            TradePayResponse response = new TradePayResponse();

            return response;
        }
        public TradeAutoPayResponse TradeAutoPay(TradeAutoPayRequest request)
        {
            throw new NotImplementedException();
        }
        public TradeSupplResponse TradeSuppl(TradeSupplRequest request)
        {
            throw new NotImplementedException();
        }
        public TradeRoyaltyResponse TradeRoyalty(TradeRoyaltyRequest request)
        {
            TradeRoyaltyResponse response = new TradeRoyaltyResponse();
           
            return response;
        }
        public TradeRefundResponse TradeRefund(TradeRefundRequest request)
        {
            TradeRefundResponse response = new TradeRefundResponse();
           
            return response;
        }
        public TradeRefundResponse TradeRoyaltyRefund(TradeRefundRequest request)
        {
            TradeRefundResponse response = new TradeRefundResponse();
           
            return response;
        }
        public TradeTransResponse TradeTrans(TradeTransRequest request)
        {
            throw new NotImplementedException();
        }
        public TradeFreezeResponse TradeFreeze(TradeFreezeRequest request)
        {
            throw new NotImplementedException();
        }
        public TradeUnFreezeResponse TradeUnFreeze(TradeUnFreezeRequest request)
        {
            throw new NotImplementedException();
        }
        public TradeBalanceQueryResponse TradeBalanceQuery(TradeBalanceQueryRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
