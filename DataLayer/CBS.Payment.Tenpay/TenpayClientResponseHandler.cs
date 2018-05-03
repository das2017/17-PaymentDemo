using System;
using System.Collections;
using System.Text;
using System.Xml;


namespace CBS.Payment.Tenpay
{
    /// <summary>
    /// 后台系统调用模式的应答基类，支持XML格式
    /// </summary>
    public class TenpayClientResponseHandler
    {
        //原始内容
        protected string content;

        protected Hashtable parameters;
        private string charset =TenpayConfigHelper.Input_charset;
        private string debugInfo;
        private string key;

        public TenpayClientResponseHandler()
        {
            parameters = new Hashtable();
        }

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

        public string getContent()
        {
            return this.content;
        }


        public virtual void setContent(string content)
        {
            this.content = content;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(content);
            XmlNode root = xmlDoc.SelectSingleNode("root");
            XmlNodeList xnl = root.ChildNodes;

            foreach (XmlNode xnf in xnl)
            {
                this.setParameter(xnf.Name, xnf.InnerXml);
            }
        }

        public string getDebugInfo()
        { return debugInfo; }

        protected void setDebugInfo(String debugInfo)
        { 
            this.debugInfo = debugInfo; 
        }

        public string getKey()
        { 
            return key; 
        }

        public void setKey(string key)
        { 
            this.key = key; 
        }

        public string getParameter(string parameter)
        {
            string s = (string)parameters[parameter];
            return (null == s) ? "" : s;
        }

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

        public virtual Boolean isTenpaySign()
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

            //debug信息
            this.setDebugInfo(sb.ToString() + " => sign:" + sign);
            return getParameter("sign").ToLower().Equals(sign);
        }

        public void setCharset(String charset)
        {
            this.charset = charset;
        }
        protected virtual string getCharset()
        {
            return this.charset;
        }
    }
}
