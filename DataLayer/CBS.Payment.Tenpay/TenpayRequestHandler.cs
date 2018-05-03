using System;
using System.Collections;
using System.Text;
using System.Web;

namespace CBS.Payment.Tenpay
{
    /// <summary>
    /// 所有请求类的基类
    /// </summary>
    public class TenpayRequestHandler
    {
        protected HttpContext httpContext;

        /// <summary>
        /// 请求的参数
        /// </summary>
        protected Hashtable parameters;

        /// <summary>
        /// debug信息
        /// </summary>
        private string debugInfo;

        /// <summary>
        /// 网关url地址
        /// </summary>
        private string gateUrl;

        /// <summary>
        /// 密钥
        /// </summary>
        private string key;

        public TenpayRequestHandler(HttpContext httpContext)
        {
            parameters = new Hashtable();

            this.httpContext = httpContext;

            this.setGateUrl("https://www.tenpay.com/cgi-bin/v1.0/service_gate.cgi");
        }

        public void doSend()
        {
            this.httpContext.Response.Redirect(this.getRequestURL());
        }

        public Hashtable getAllParameters()
        {
            return this.parameters;
        }

        /// <summary>
        /// 设置debug信息
        /// </summary>
        /// <param name="debugInfo"></param>
        public void setDebugInfo(String debugInfo)
        {
            this.debugInfo = debugInfo;
        }

        /// <summary>
        /// 获取debug信息
        /// </summary>
        /// <returns></returns>
        public String getDebugInfo()
        {
            return debugInfo;
        }

        /// <summary>
        /// 获取入口地址
        /// </summary>
        /// <returns></returns>
        public String getGateUrl()
        {
            return gateUrl;
        }

        /// <summary>
        /// 获取入口地址
        /// </summary>
        /// <param name="gateUrl"></param>
        public void setGateUrl(String gateUrl)
        {
            this.gateUrl = gateUrl;
        }

        /// <summary>
        /// 获取密钥
        /// </summary>
        /// <returns></returns>
        public String getKey()
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
        /// 获取参数值
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public string getParameter(string parameter)
        {
            string s = (string)parameters[parameter];
            return (null == s) ? "" : s;
        }

        /// <summary>
        /// 设置参数值
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
        /// 获取带参数的请求URL
        /// </summary>
        /// <returns></returns>
        public virtual string getRequestURL()
        {
            this.createSign();

            StringBuilder sb = new StringBuilder();
            ArrayList akeys = new ArrayList(parameters.Keys);
            akeys.Sort();
            foreach (string k in akeys)
            {
                string v = (string)parameters[k];
                if (null != v && "key".CompareTo(k) != 0 && "spbill_create_ip".CompareTo(k) != 0)
                {
                    sb.Append(k + "=" + TenpayCoreHelper.UrlEncode(v, getCharset()) + "&");
                }
                else if ("spbill_create_ip".CompareTo(k) == 0)
                {
                    sb.Append(k + "=" + v.Replace(".", "%2E") + "&");
                }
            }

            //去掉最后一个&
            if (sb.Length > 0)
            {
                sb.Remove(sb.Length - 1, 1);
            }

            return this.getGateUrl() + "?" + sb.ToString();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public virtual void init()
        {
            //nothing to do
        }

        /// <summary>
        /// 创建签名
        /// </summary>
        protected virtual void createSign()
        {
            StringBuilder sb = new StringBuilder();

            ArrayList akeys = new ArrayList(parameters.Keys);
            akeys.Sort();

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

            this.setParameter("sign", sign);

            //debug信息
            this.setDebugInfo(sb.ToString() + " => sign:" + sign);
        }

        protected virtual string getCharset()
        {
            return TenpayConfigHelper.Input_charset;
        }
    }
}