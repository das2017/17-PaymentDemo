using CBS.Payment.DB.PaymentDB;
using CBS.Payment.DTO.Request;
using CBS.Payment.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBS.Payment.Business.ThirdPayment
{
    public class AlipayVerify
    {
        static readonly PaymentDBFacade _PaymentDBFacade = new PaymentDBFacade();
        public static TradePayResponse TradePay(TradePayRequest request)
        {
            throw new NotImplementedException();
        }

        public static TradeAutoPayResponse TradeAutoPay(TradeAutoPayRequest request)
        {
            throw new NotImplementedException();
        }

        public static TradeSupplResponse TradeSuppl(TradeSupplRequest request)
        {
            throw new NotImplementedException();
        }

        public static TradeRoyaltyResponse TradeRoyalty(TradeRoyaltyRequest request)
        {
            throw new NotImplementedException();
        }

        public static TradeRefundResponse TradeRefund(TradeRefundRequest request)
        {
            throw new NotImplementedException();
        }

        public static TradeRefundResponse TradeRoyaltyRefund(TradeRefundRequest request)
        {
            throw new NotImplementedException();
        }

        public static TradeTransResponse TradeTrans(TradeTransRequest request)
        {
            throw new NotImplementedException();
        }

        public static TradeFreezeResponse TradeFreeze(TradeFreezeRequest request)
        {
            throw new NotImplementedException();
        }

        public static TradeUnFreezeResponse TradeUnFreeze(TradeUnFreezeRequest request)
        {
            throw new NotImplementedException();
        }

        public static TradeBalanceQueryResponse TradeBalanceQuery(TradeBalanceQueryRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
