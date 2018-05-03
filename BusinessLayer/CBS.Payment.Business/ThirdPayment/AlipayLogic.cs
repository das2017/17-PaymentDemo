using CBS.Payment.Alipay.Model;
using CBS.Payment.DTO.Request;
using CBS.Payment.DTO.Response;
using CBS.Payment.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBS.Payment.Business.ThirdPayment
{
    public class AlipayLogic : IPaymentService
    {
        public TradePayResponse TradePay(TradePayRequest request)
        {           
            AlipayResponseBase<AlipayPay> alipayResponseModel = new AlipayResponseBase<AlipayPay>();
            TradePayResponse response = new TradePayResponse();
            //数据验证
            //获取账号信息          
            //生成平台唯一订单号        
            //记录请求日志          
            //第三方支付调用并记录响应结果
            //组织数据返回
            
            return response;
        }
        public TradeAutoPayResponse TradeAutoPay(TradeAutoPayRequest request)
        {
            TradeAutoPayResponse response = new TradeAutoPayResponse();
           
            return response;
        }
        public TradeSupplResponse TradeSuppl(TradeSupplRequest request)
        {
            TradeSupplResponse response = new TradeSupplResponse();
           
            return response;
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
            throw new NotImplementedException();
        }
        public TradeTransResponse TradeTrans(TradeTransRequest request)
        {
            TradeTransResponse response = new TradeTransResponse();
          
            return response;
        }
        public TradeFreezeResponse TradeFreeze(TradeFreezeRequest request)
        {
            TradeFreezeResponse response = new TradeFreezeResponse();
           
            return response;
        }
        public TradeUnFreezeResponse TradeUnFreeze(TradeUnFreezeRequest request)
        {
            TradeUnFreezeResponse response = new TradeUnFreezeResponse();
           
            return response;
        }
        public TradeBalanceQueryResponse TradeBalanceQuery(TradeBalanceQueryRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
