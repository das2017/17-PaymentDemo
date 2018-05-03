using System;
using System.Text;
using System.Web;

namespace CBS.Payment.Tenpay
{
    public class TenpayPayResponseHandler : TenpayResponseHandler
    {
        public TenpayPayResponseHandler(HttpContext httpContext)
            : base(httpContext)
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

        /// <summary>
        /// 是否财付通签名
        /// </summary>
        /// <returns></returns>
        public override Boolean isTenpaySign()
        {
            //获取参数
            string cmdno = getParameter("cmdno");
            string pay_result = getParameter("pay_result");
            string date = getParameter("date");
            string transaction_id = getParameter("transaction_id");
            string sp_billno = getParameter("sp_billno");
            string total_fee = getParameter("total_fee");
            string fee_type = getParameter("fee_type");
            string attach = getParameter("attach");
            string tenpaySign = getParameter("sign").ToUpper();
            string key = this.getKey();

            //组织签名串
            StringBuilder sb = new StringBuilder();
            sb.Append("cmdno=" + cmdno + "&");
            sb.Append("pay_result=" + pay_result + "&");
            sb.Append("date=" + date + "&");
            sb.Append("transaction_id=" + transaction_id + "&");
            sb.Append("sp_billno=" + sp_billno + "&");
            sb.Append("total_fee=" + total_fee + "&");
            sb.Append("fee_type=" + fee_type + "&");
            sb.Append("attach=" + attach + "&");
            sb.Append("key=" + key);

            //算出摘要
            string sign = MD5Helper.GetMD5(sb.ToString(), getCharset());

            //debug信息
            setDebugInfo(sb.ToString() + " => sign:" + sign +
                " tenpaySign:" + tenpaySign);

            return sign.Equals(tenpaySign);
        }
    }
}
