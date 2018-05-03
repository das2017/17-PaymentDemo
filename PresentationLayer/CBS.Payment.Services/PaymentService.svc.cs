using CBS.Payment.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CBS.Payment.DTO;
using CBS.Payment.DTO.Response;
using CBS.Payment.DTO.Request;

namespace CBS.Payment.Services
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“PaymentService”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 PaymentService.svc 或 PaymentService.svc.cs，然后开始调试。
    public class PaymentService : IPaymentService
    {
        
        private PaymentFacade _payFacade = new PaymentFacade();

        /// <summary>
        /// 支付
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public TradePayResponse TradePay(TradePayRequest request)
        {
            return _payFacade.TradePay(request);
        }

        /// <summary>
        /// 代扣
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public TradeAutoPayResponse TradeAutoPay(TradeAutoPayRequest request)
        {
            return _payFacade.TradeAutoPay(request);
        }

        /// <summary>
        /// 分润
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public TradeRoyaltyResponse TradeRoyalty(TradeRoyaltyRequest request)
        {
            return _payFacade.TradeRoyalty(request);
        }

        /// <summary>
        /// 退款
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public TradeRefundResponse TradeRefund(TradeRefundRequest request)
        {
            return _payFacade.TradeRefund(request);
        }

        /// <summary>
        /// 退分润
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public TradeRefundResponse TradeRoyaltyRefund(TradeRefundRequest request)
        {
            return _payFacade.TradeRoyaltyRefund(request);
        }

        /// <summary>
        /// 补差
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public TradeSupplResponse TradeSuppl(TradeSupplRequest request)
        {
            return _payFacade.TradeSuppl(request);
        }

        /// <summary>
        /// 转账
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public TradeTransResponse TradeTrans(TradeTransRequest request)
        {
            return _payFacade.TradeTrans(request);
        }

        /// <summary>
        /// 冻结
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public TradeFreezeResponse TradeFreeze(TradeFreezeRequest request)
        {
            return _payFacade.TradeFreeze(request);
        }

        /// <summary>
        /// 解冻
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public TradeUnFreezeResponse TradeUnFreeze(TradeUnFreezeRequest request)
        {
            return _payFacade.TradeUnFreeze(request);
        }

        /// <summary>
        /// 余额查询--仅预付款
        /// </summary>
        /// <param name="request"></param>
        /// <param name="channels"></param>
        /// <returns></returns>
        public TradeBalanceQueryResponse TradeBalanceQuery(TradeBalanceQueryRequest request)
        {
            return _payFacade.TradeBalanceQuery(request);
        }
    }
}
