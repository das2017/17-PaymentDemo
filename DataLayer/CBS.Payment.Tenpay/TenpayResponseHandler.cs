using System;
using System.Collections;
using System.Collections.Specialized;
using System.Text;
using System.Web;

namespace CBS.Payment.Tenpay
{
    /// <summary>
    /// 页面交互模式的应答基类
    /// </summary>
    public class TenpayResponseHandler
    {
        protected HttpContext httpContext;
        protected Hashtable parameters;
        private string debugInfo;
        private string key;

        public TenpayResponseHandler(HttpContext httpContext)
        {
            parameters = new Hashtable();

            this.httpContext = httpContext;
            NameValueCollection collection;
            if (this.httpContext.Request.HttpMethod == "POST")
            {
                collection = this.httpContext.Request.Form;
            }
            else
            {
                collection = this.httpContext.Request.QueryString;
            }

            foreach (string k in collection)
            {
                string v = (string)collection[k];
                this.setParameter(k, v);
            }
        }

        /// <summary>
        /// 验证签名
        /// </summary>
        /// <param name="akeys"></param>
        /// <returns></returns>
        public virtual Boolean _isTenpaySign(ArrayList akeys)
        {
            StringBuilder sb = new StringBuilder();

            foreach (string k in akeys)
            {
                string v = (string)parameters[k];
                if (null != v && "".CompareTo(v) != 0
                    && "sign".CompareTo(k) != 0 && "key".CompareTo(k) != 0)
                {
                    sb.Append(k + "=" + v + "&");
                }
            }

            sb.Append("key=" + this.getKey());
            string sign = MD5Helper.GetMD5(sb.ToString(), getCharset()).ToLower();

            //debug信息
            this.setDebugInfo(sb.ToString() + " => sign:" + sign);
            return getParameter("sign").ToLower().Equals(sign);
        }

        /// <summary>
        /// 显示处理结果
        /// </summary>
        /// <param name="show_url"></param>
        public void doShow(string show_url)
        {
            string strHtml = "<html><head>\r\n" +
                "<meta name=\"TENCENT_ONLINE_PAYMENT\" content=\"China TENCENT\">\r\n" +
                "<script language=\"javascript\">\r\n" +
                "window.location.href='" + show_url + "';\r\n" +
                "</script>\r\n" +
                "</head><body></body></html>";

            this.httpContext.Response.Write(strHtml);

            this.httpContext.Response.End();
        }

        /// <summary>
        /// 获取debug信息
        /// </summary>
        /// <returns></returns>
        public string getDebugInfo()
        {
            return debugInfo;
        }

        /// <summary>
        /// 设置debug信息
        /// </summary>
        /// <param name="debugInfo"></param>
        protected void setDebugInfo(String debugInfo)
        {
            this.debugInfo = debugInfo;
        }

        /// <summary>
        /// 获取密钥
        /// </summary>
        /// <returns></returns>
        public string getKey()
        {
            return key;
        }

        /// <summary>
        /// 设置密钥
        /// </summary>
        /// <param name="key"></param>
        public void setKey(string key)
        {
            this.key = key;
        }

        /// <summary>
        ///  获取参数
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public string getParameter(string parameter)
        {
            string s = (string)parameters[parameter];
            return (null == s) ? "" : s;
        }

        /// <summary>
        /// 设置参数
        /// </summary>
        /// <param name="parameter"></param>
        /// <param name="parameterValue"></param>
        public void setParameter(string parameter, string parameterValue)
        {
            if (parameter != null && parameter != "")
            {
                if (parameters.Contains(parameter))
                {
                    parameters.Remove(parameter);
                }

                parameters.Add(parameter, parameterValue);
            }
        }

        /// <summary>
        /// 验证签名
        /// </summary>
        /// <returns></returns>
        public virtual Boolean isTenpaySign()
        {
            StringBuilder sb = new StringBuilder();

            ArrayList akeys = new ArrayList(parameters.Keys);
            akeys.Sort();

            foreach (string k in akeys)
            {
                string v = (string)parameters[k];
                if (null != v && "".CompareTo(v) != 0
                    && "sign".CompareTo(k) != 0 && "key".CompareTo(k) != 0 && "bankname".CompareTo(k) != 0)
                {
                    sb.Append(k + "=" + v + "&");
                }
            }

            sb.Append("key=" + this.getKey());
            string sign = MD5Helper.GetMD5(sb.ToString(), getCharset()).ToLower();

            //debug信息
            this.setDebugInfo(sb.ToString() + " => sign:" + sign + " TenpaySign:" + getParameter("sign").ToLower());
            return getParameter("sign").ToLower().Equals(sign);
        }

        /// <summary>
        /// 获取字符编码
        /// </summary>
        /// <returns></returns>
        protected virtual string getCharset()
        {
            return TenpayConfigHelper.Input_charset;
        }

    }
}