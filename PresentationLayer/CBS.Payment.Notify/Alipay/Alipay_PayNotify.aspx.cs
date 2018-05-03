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
    public partial class Alipay_PayNotify : System.Web.UI.Page
    {
        private static PaymentNotifyLogic payNotifyClient = new PaymentNotifyLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            AlipayPayNotifyModel model = new AlipayPayNotifyModel();
            SortedDictionary<string, string> sPara = AlipayCoreHelper.GetRequestPost(Request.Form);
            string tmpPara = AlipayCoreHelper.GetPreSignStr(sPara);
            Log.Inf("[Alipay_PayNotify_Request]：" + tmpPara + "|" + Request.Form["sign"]);

            if (sPara != null && sPara.Count > 0)
            {
                model.Sign = Request.Form["sign"];
                model.Body = Request.Form["body"];
                model.Buyer_Email = Request.Form["buyer_email"];
                model.Buyer_Id = Request.Form["buyer_id"];
                model.Notify_Id = Request.Form["notify_id"];
                model.Notify_Time = Request.Form["notify_time"];
                model.Notify_Type = Request.Form["notify_type"];
                model.Out_Trade_No = Request.Form["out_trade_no"];
                model.Payment_Type = Request.Form["payment_type"];
                model.Seller_Email = Request.Form["seller_email"];
                model.Seller_Id = Request.Form["seller_id"];
                model.Subject = Request.Form["subject"];
                model.Total_Fee = Request.Form["total_fee"];
                model.Trade_No = Request.Form["trade_no"];
                model.Trade_Status = Request.Form["trade_status"];
                model.Gmt_Create = Request.Form["gmt_create"];
                model.Gmt_payment = Request.Form["gmt_payment"];
                model.sPara = sPara;

                TradePayResponse result = payNotifyClient.AlipayPayNotify(model);
                Log.Inf("[Alipay_PayNotify_Response]：" + SerializerHelper.SerializerToXml<TradePayResponse>(result));
                if (!(result.Status == "-1"))
                {
                    string[] data = result.RequestUrl.Split('|');

                    if (!(string.IsNullOrEmpty(data[0]) || string.IsNullOrEmpty(data[1])))
                    {
                        string tmp = HttpHelper.PostData(data[0], data[1]);
                    }
                    Response.Write("success");
                }
                else
                {
                    Response.Write("fail");
                }
            }
            else
            {
                Response.Write("无通知参数");
            }
        }
    }
}