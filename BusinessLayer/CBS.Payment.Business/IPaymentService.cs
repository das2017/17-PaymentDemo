using CBS.Payment.DTO.Request;
using CBS.Payment.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CBS.Payment.Business
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IPaymentService”。
    [ServiceContract]
    public interface IPaymentService
    {
        /// <summary>
        /// 支付
        /// </summary>
        /// <param name="request">支付请求实体参数</param>
        /// <returns>支付结果</returns>
        [OperationContract]
        TradePayResponse TradePay(TradePayRequest request);

        /// <summary>
        /// 代扣
        /// </summary>
        /// <param name="request">代扣请求实体参数</param>
        /// <returns></returns>
        [OperationContract]
        TradeAutoPayResponse TradeAutoPay(TradeAutoPayRequest request);

        /// <summary>
        /// 补差
        /// </summary>
        /// <param name="request">补差请求实体参数</param>
        /// <returns></returns>
        [OperationContract]
        TradeSupplResponse TradeSuppl(TradeSupplRequest request);

        /// <summary>
        /// 分润
        /// </summary>
        /// <param name="request">分润请求实体参数</param>
        /// <returns></returns>
        [OperationContract]
        TradeRoyaltyResponse TradeRoyalty(TradeRoyaltyRequest request);

        /// <summary>
        /// 退款
        /// </summary>
        /// <param name="request">退款请求实体参数</param>
        /// <returns></returns>
        [OperationContract]
        TradeRefundResponse TradeRefund(TradeRefundRequest request);

        /// <summary>
        /// 退分润
        /// </summary>
        /// <param name="request">退分润请求实体参数</param>
        /// <returns></returns>
        [OperationContract]
        TradeRefundResponse TradeRoyaltyRefund(TradeRefundRequest request);

        /// <summary>
        /// 转账
        /// </summary>
        /// <param name="request">转账请求实体参数</param>
        /// <returns></returns>
        [OperationContract]
        TradeTransResponse TradeTrans(TradeTransRequest request);
        
        /// <summary>
        /// 冻结
        /// </summary>
        /// <param name="request">冻结请求实体参数</param>
        /// <returns></returns>
        [OperationContract]
        TradeFreezeResponse TradeFreeze(TradeFreezeRequest request);
        
        /// <summary>
        /// 解冻
        /// </summary>
        /// <param name="request">解冻请求实体参数</param>
        /// <returns></returns>
        [OperationContract]
        TradeUnFreezeResponse TradeUnFreeze(TradeUnFreezeRequest request);
        
        /// <summary>
        /// 余额查询
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [OperationContract]
        TradeBalanceQueryResponse TradeBalanceQuery(TradeBalanceQueryRequest request);
    }
}
