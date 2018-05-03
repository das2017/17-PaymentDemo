using System;
using System.Text;
using System.Web;

namespace CBS.Payment.Tenpay
{
    /// <summary>
    /// 网关支付请求类
    /// </summary>
    public class TenpayPayRequestHandler : TenpayRequestHandler
    {
        public TenpayPayRequestHandler(HttpContext httpContext)
            : base(httpContext)
        {
            this.setGateUrl(TenpayConfigHelper.Pay_Gateway);
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public override void init()
        {
            //任务代码
            this.setParameter("cmdno", "1");

            //日期
            this.setParameter("date", DateTime.Now.ToString("yyyyMMdd"));

            //商户号
            this.setParameter("bargainor_id", "");

            //财付通交易单号
            this.setParameter("transaction_id", "");

            //商家订单号
            this.setParameter("sp_billno", "");

            //商品价格，以分为单位
            this.setParameter("total_fee", "");

            //货币类型
            this.setParameter("fee_type", "1");

            //返回url
            this.setParameter("return_url", "");

            //自定义参数
            this.setParameter("attach", "");

            //用户ip
            this.setParameter("spbill_create_ip", "");

            //商品名称
            this.setParameter("desc", "");

            //银行编码
            this.setParameter("bank_type", "0");

            //字符集编码
            this.setParameter("cs",TenpayConfigHelper.Input_charset);

            //摘要
            this.setParameter("sign", "");
        }

        /// <summary>
        /// 签名
        /// </summary>
        protected override void createSign()
        {
            //获取参数
            string cmdno = getParameter("cmdno");
            string date = getParameter("date");
            string bargainor_id = getParameter("bargainor_id");
            string transaction_id = getParameter("transaction_id");
            string sp_billno = getParameter("sp_billno");
            string total_fee = getParameter("total_fee");
            string fee_type = getParameter("fee_type");
            string return_url = getParameter("return_url");
            string attach = getParameter("attach");
            string spbill_create_ip = getParameter("spbill_create_ip");
            string key = getParameter("key");

            //组织签名
            StringBuilder sb = new StringBuilder();
            sb.Append("cmdno=" + cmdno + "&");
            sb.Append("date=" + date + "&");
            sb.Append("bargainor_id=" + bargainor_id + "&");
            sb.Append("transaction_id=" + transaction_id + "&");
            sb.Append("sp_billno=" + sp_billno + "&");
            sb.Append("total_fee=" + total_fee + "&");
            sb.Append("fee_type=" + fee_type + "&");
            sb.Append("return_url=" + return_url + "&");
            sb.Append("attach=" + attach + "&");
            if (!"".Equals(spbill_create_ip))
            {
                sb.Append("spbill_create_ip=" + spbill_create_ip + "&");
            }
            sb.Append("key=" + getKey());

            //算出摘要
            string sign = MD5Helper.GetMD5(sb.ToString(), getCharset());

            setParameter("sign", sign);

            //debug信息
            setDebugInfo(sb.ToString() + " => sign:" + sign);
        }
    }
}
