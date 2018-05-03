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
    public partial class Alipay_UnFreezeNotify : System.Web.UI.Page
    {
        private static PaymentNotifyLogic payNotifyClient = new PaymentNotifyLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            AlipayUnFreezeNotifyModel model = new AlipayUnFreezeNotifyModel();
            SortedDictionary<string, string> sPara = AlipayCoreHelper.GetRequestPost(Request.Form);
            string tmpPara = AlipayCoreHelper.GetPreSignStr(sPara);
            Log.Inf("[Alipay_UnFreezeNotify_Request]：" + tmpPara + "|" + Request.Form["sign"]);

            if (sPara != null && sPara.Count > 0)
            {
                model.Sign = Request.Form["sign"];
                model.Amount = Request.Form["amount"];
                model.UnFreeze_Out_Order_No = Request.Form["unfreeze_out_order_no"];
                model.Notify_Id = Request.Form["notify_id"];
                model.Notify_Time = Request.Form["notify_time"];
                model.Notify_Type = Request.Form["notify_type"];
                model.Pay_Date = Request.Form["pay_date"];
                model.Result_Code = Request.Form["result_code"];
                model.Status = Request.Form["status"];
                model.Trade_No = Request.Form["trade_no"];
                model.User_Id = Request.Form["user_id"];
                model.User_Logon_Id = Request.Form["user_logon_id"];
                model.sPara = sPara;

                TradePayResponse result = payNotifyClient.AlipayUnFreezeNotify(model);

                Log.Inf("[Alipay_UnFreezeNotify_Response]：" + SerializerHelper.SerializerToXml<TradePayResponse>(result));
                Response.Write("success");

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