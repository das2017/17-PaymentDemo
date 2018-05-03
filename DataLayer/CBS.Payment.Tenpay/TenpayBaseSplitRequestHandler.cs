using System.Web;

namespace CBS.Payment.Tenpay
{
    /// <summary>
    /// 分账、支付并分账、冻结、解冻、分账回退、平台退款、订单查询的请求类
    /// </summary>
    class TenpayBaseSplitRequestHandler : TenpayRequestHandler
    {
        public TenpayBaseSplitRequestHandler(HttpContext httpContext)
            : base(httpContext)
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

        protected override void createSign()
        {
            base.createSign();

            this.setParameter("sign", this.getParameter("sign").ToUpper());
        }
    }
}
