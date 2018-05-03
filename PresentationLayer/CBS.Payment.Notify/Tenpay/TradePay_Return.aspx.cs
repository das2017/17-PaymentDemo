using CBS.Payment.Tenpay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using CBS.Payment.DTO.Response;
using CBS.Payment.Entity.Model;
using CBS.Payment.Utility;
using CBS.Payment.Business;

namespace CBS.Payment.Notify.Tenpay
{
    public partial class TradePay_Return : System.Web.UI.Page
    {
        private static PaymentNotifyLogic payNotifyClient = new PaymentNotifyLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            //创建PayResponseHandler实例
            TenpayPayResponseHandler resHandler = new TenpayPayResponseHandler(Context);

            TenpayPayReturnModel model = new TenpayPayReturnModel();
            model.CmdNo = resHandler.getParameter("cmdno");
            model.Pay_Result = resHandler.getParameter("pay_result");
            model.Date = resHandler.getParameter("date");
            model.Transaction_Id = resHandler.getParameter("transaction_id");
            model.Sp_NillNo = resHandler.getParameter("sp_billno");
            model.Total_Fee = resHandler.getParameter("total_fee");
            model.Fee_Type = resHandler.getParameter("fee_type");
            model.Attach = resHandler.getParameter("attach");
            model.Sign = resHandler.getParameter("sign").ToUpper();
            Log.Inf("[TradePay_Return_Request]：" + SerializerHelper.SerializerToXml<TenpayPayReturnModel>(model));
            TradePayResponse res = payNotifyClient.TenpayPayReturn(model);
            Log.Inf("[TradePay_Return_Response]：" + SerializerHelper.SerializerToXml<TradePayResponse>(res));
            if (!(res.Status == "-1"))
            {

                if ("0".Equals(model.Pay_Result))
                {
                    if (!string.IsNullOrEmpty(res.NotifyUrl) || !string.IsNullOrEmpty(res.RequestUrl))
                    {
                        string[] data = res.NotifyUrl.Split('?');
                        string tmp = HttpHelper.PostData(data[0], data[1]);
                        resHandler.doShow(res.RequestUrl);
                    }
                    else
                    {
                        string url = "http://" + Request.Url.Host + "/Tenpay/DoSuccess.aspx";
                        resHandler.doShow(url);
                    }
                }
                else
                {
                    Response.Write("支付失败");
                }
            }
            else
            {
                Response.Write("认证签名失败");
            }
        }
    }
}