using CBS.Payment.Alipay;
using CBS.Payment.Business;
using CBS.Payment.DTO.Response;
using CBS.Payment.Entity.Model;
using CBS.Payment.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CBS.Payment.Notify.Alipay
{
    public partial class Alipay_PayReturn : System.Web.UI.Page
    {
        private static PaymentNotifyLogic payNotifyClient = new PaymentNotifyLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            AlipayPayReturnModel model = new AlipayPayReturnModel();
            SortedDictionary<string, string> sPara = AlipayCoreHelper.GetRequestGet(Request.QueryString);
            string tmpPara = AlipayCoreHelper.GetPreSignStr(sPara);
            Log.Inf("[Alipay_PayReturn_Request]：" + tmpPara + "|" + Request.Form["sign"]);

            if (sPara != null && sPara.Count > 0)
            {
                model.Sign = sPara["sign"];
                model.Body = sPara["body"];
                model.Buyer_Email = sPara["buyer_email"];
                model.Buyer_Id = sPara["buyer_id"];
                model.Notify_Id = sPara["notify_id"];
                model.Notify_Time = sPara["notify_time"];
                model.Notify_Type = sPara["notify_type"];
                model.Out_Trade_No = sPara["out_trade_no"];
                model.Payment_Type = sPara["payment_type"];
                model.Seller_Email = sPara["seller_email"];
                model.Seller_Id = sPara["seller_id"];
                model.Subject = sPara["subject"];
                model.Total_Fee = sPara["total_fee"];
                model.Trade_No = sPara["trade_no"];
                model.Trade_Status = sPara["trade_status"];
                model.sPara = sPara;
                TradePayResponse result = payNotifyClient.AlipayPayReturn(model);
                Log.Inf("[Alipay_PayReturn_Response]：" + SerializerHelper.SerializerToXml<TradePayResponse>(result));

                if (!(result.Status == "-1"))
                {

                    if (!string.IsNullOrEmpty(result.RequestUrl))
                    {
                        Response.Redirect(result.RequestUrl);
                    }
                    else
                    {
                        Response.Write("验证成功");
                    }
                }
                else
                {
                    Response.Write("验证失败");
                }
            }
            else
            {
                Response.Write("无返回参数");
            }
        }
    }
}