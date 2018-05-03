using CBS.Payment.Business.ThirdPayment;
using CBS.Payment.DTO.Request;
using CBS.Payment.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBS.Payment.Business
{
    public class PaymentFacade : IPaymentService
    {
        public TradePayResponse TradePay(TradePayRequest request)
        {
            IPaymentService paymentService = ThirdPaymentFactory.Create(request.payChannels);
            return paymentService.TradePay(request);
        }

        public TradeAutoPayResponse TradeAutoPay(TradeAutoPayRequest request)
        {
            IPaymentService paymentService = ThirdPaymentFactory.Create(request.payChannels);
            return paymentService.TradeAutoPay(request);
        }

        public TradeSupplResponse TradeSuppl(TradeSupplRequest request)
        {
            IPaymentService paymentService = ThirdPaymentFactory.Create(request.payChannels);
            return paymentService.TradeSuppl(request);
        }

        public TradeRoyaltyResponse TradeRoyalty(TradeRoyaltyRequest request)
        {
            IPaymentService paymentService = ThirdPaymentFactory.Create(request.payChannels);
            return paymentService.TradeRoyalty(request);
        }

        public TradeRefundResponse TradeRefund(TradeRefundRequest request)
        {
            IPaymentService paymentService = ThirdPaymentFactory.Create(request.payChannels);
            return paymentService.TradeRefund(request);
        }

        public TradeRefundResponse TradeRoyaltyRefund(TradeRefundRequest request)
        {
            IPaymentService paymentService = ThirdPaymentFactory.Create(request.payChannels);
            return paymentService.TradeRoyaltyRefund(request);
        }

        public TradeTransResponse TradeTrans(TradeTransRequest request)
        {
            IPaymentService paymentService = ThirdPaymentFactory.Create(request.payChannels);
            return paymentService.TradeTrans(request);
        }

        public TradeFreezeResponse TradeFreeze(TradeFreezeRequest request)
        {
            IPaymentService paymentService = ThirdPaymentFactory.Create(request.payChannels);
            return paymentService.TradeFreeze(request);
        }

        public TradeUnFreezeResponse TradeUnFreeze(TradeUnFreezeRequest request)
        {
            IPaymentService paymentService = ThirdPaymentFactory.Create(request.payChannels);
            return paymentService.TradeUnFreeze(request);
        }

        public TradeBalanceQueryResponse TradeBalanceQuery(TradeBalanceQueryRequest request)
        {
            IPaymentService paymentService = ThirdPaymentFactory.Create(request.payChannels);
            return paymentService.TradeBalanceQuery(request);
        }
    }
}
