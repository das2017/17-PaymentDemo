using CBS.Payment.Alipay;
using CBS.Payment.Business;
using CBS.Payment.DTO.Response;
using CBS.Payment.Entity.Model;
using CBS.Payment.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CBS.Payment.Notify.Alipay
{
    public partial class Alipay_RefundNotify : System.Web.UI.Page
    {
        private static PaymentNotifyLogic payNotifyClient = new PaymentNotifyLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            AlipayRefundNotifyModel model = new AlipayRefundNotifyModel();
            SortedDictionary<string, string> sPara = AlipayCoreHelper.GetRequestPost(Request.Form);
            string tmpPara = AlipayCoreHelper.GetPreSignStr(sPara);
            Log.Inf("[Alipay_RefundNotify_Request]：" + tmpPara + "|" + Request.Form["sign"]);

            if (sPara != null && sPara.Count > 0)
            {
                model.Sign = Request.Form["sign"];
                model.Batch_No = Request.Form["batch_no"];
                model.Notify_Id = Request.Form["notify_id"];
                model.Notify_Time = Request.Form["notify_time"];
                model.Notify_Type = Request.Form["notify_type"];
                model.Success_Num = Request.Form["success_num"];
                model.Result_Details = Request.Form["result_details"];
                model.Unfreezed_Details = Request.Form["unfreezed_details"];
                model.sPara = sPara;
                TradePayResponse result = payNotifyClient.AlipayRefundNotify(model);
                Log.Inf("[Alipay_RefundNotify_Response]：" + SerializerHelper.SerializerToXml<TradePayResponse>(result));
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