using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Xml;
using System.Net;
using System.IO;
using System.Configuration;
using System.Data;

namespace CBS.Payment.Alipay
{
    public class AlipayCommon
    {
        #region*******************通知页面参数***********************
        /// <summary>
        /// 支付异步通知页面路径
        /// </summary>
        public static string Pay_Notify_url = "";//"http://testpay.test.***/payNotify/alipay/TradePay_Notify.aspx";

        /// <summary>
        /// 支付同步通知页面路径
        /// </summary>
        public static string Pay_Return_url = "";//"http://testpay.test.***/payNotify/alipay/TradePay_Return.aspx";

        /// <summary>
        /// cae代扣异步通知页面路径
        /// </summary>
        public static string CAEPay_Notify_url = "";//"http://testpay.test.***/payNotify/alipay/TradeCAEPay_Notify.aspx";

        /// <summary>
        /// 退款异步通知页面路径
        /// </summary>
        public static string Refund_Notify_url = "";//"http://testpay.test.***/payNotify/alipay/TradeRefund_Notify.aspx";

        /// <summary>
        /// 充退异步通知页面路径
        /// </summary>
        public static string Dback_Notify_url = "";//"http://testpay.test.***/payNotify/alipay/TradeReceive_Notify.aspx";

        /// <summary>
        /// 分润异步通知页面路径
        /// </summary>
        public static string Royalty_Notify_url = "";

        /// <summary>
        /// 补差异步通知页面路径
        /// </summary>
        public static string Suppl_Notify_url = "";// "http://testpay.test.***/payNotify/alipay/TradeSuppl_Notify.aspx";
        /// <summary>
        /// 批量转账（充值）异步通知页面路径
        /// </summary>
        public static string Trans_Notify_url = "";//http://testpay.test.***/payNotify/alipay/TradeTransNotify.aspx";

        /// <summary>
        /// 冻结异步通知页面路径
        /// </summary>
        public static string Freeze_Notify_url = "";//http://testpay.test.***/payNotify/alipay/FreezeNotify.aspx";

        /// <summary>
        /// 解冻异步通知页面路径
        /// </summary>
        public static string UnFreeze_Notify_url = "";//http://testpay.test.***/payNotify/alipay/UnFreezeNotify.aspx";
        #endregion

        static AlipayCommon()
        {
            if (ConfigurationManager.AppSettings["Alipay_PayNotify_Url"] != null)
            {
                Pay_Notify_url = ConfigurationManager.AppSettings["Alipay_PayNotify_Url"];
            }
            if (ConfigurationManager.AppSettings["Alipay_PayReturn_Url"] != null)
            {
                Pay_Return_url = ConfigurationManager.AppSettings["Alipay_PayReturn_Url"];
            }
            if (ConfigurationManager.AppSettings["Alipay_CAEPayNotify_Url"] != null)
            {
                CAEPay_Notify_url = ConfigurationManager.AppSettings["Alipay_CAEPayNotify_Url"];
            }
            if (ConfigurationManager.AppSettings["Alipay_RefundNotify_Url"] != null)
            {
                Refund_Notify_url = ConfigurationManager.AppSettings["Alipay_RefundNotify_Url"];
            }
            if (ConfigurationManager.AppSettings["Alipay_DbackNotify_Url"] != null)
            {
                Dback_Notify_url = ConfigurationManager.AppSettings["Alipay_DbackNotify_Url"];
            }
            if (ConfigurationManager.AppSettings["Alipay_RoyaltyNotify_Url"] != null)
            {
                Royalty_Notify_url = ConfigurationManager.AppSettings["Alipay_RoyaltyNotify_Url"];
            }
            if (ConfigurationManager.AppSettings["Alipay_SupplNotify_Url"] != null)
            {
                Suppl_Notify_url = ConfigurationManager.AppSettings["Alipay_SupplNotify_Url"];
            }

            if (ConfigurationManager.AppSettings["Alipay_TransNotify_Url"] != null)
            {
                Trans_Notify_url = ConfigurationManager.AppSettings["Alipay_TransNotify_Url"];
            }
            if (ConfigurationManager.AppSettings["Alipay_FreezeNotify_Url"] != null)
            {
                Freeze_Notify_url = ConfigurationManager.AppSettings["Alipay_FreezeNotify_Url"];
            }
            if (ConfigurationManager.AppSettings["Alipay_UnFreezeNotify_Url"] != null)
            {
                UnFreeze_Notify_url = ConfigurationManager.AppSettings["Alipay_UnFreezeNotify_Url"];
            }
        }



        /// <summary>
        /// 获取xml节点值
        /// </summary>
        /// <param name="xmldoc">xml字符串</param>
        /// <param name="nodepath">获取节点路径</param>
        /// <returns>节点值</returns>
        public static string GetXmlNodeValue(string xmldoc, string nodepath)
        {
            string retxml = string.Empty;
            if (xmldoc.Contains("<?xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xmldoc);
                XmlNode d = doc.SelectSingleNode(nodepath);
                retxml = d.InnerText;
            }
            return retxml;
        }

        /// <summary> 
        /// 查找xml数据,返回当前节点的所有下级节点,填充到一个DataSet中 
        /// </summary> 
        /// <param name="xml">xml文档</param> 
        /// <param name="XmlPathNode">节点的路径:根节点/父节点/当前节点</param> 
        /// <returns></returns> 
        public static DataSet GetXmlData(string xml, string XmlPathNode)
        {
            XmlDocument objXmlDoc = new XmlDocument();
            objXmlDoc.LoadXml(xml);
            DataSet ds = new DataSet();
            StringReader read = new StringReader(objXmlDoc.SelectSingleNode(XmlPathNode).OuterXml);
            ds.ReadXml(read);
            return ds;
        }

        /// <summary>
        /// 获取远程服务器ATN结果
        /// </summary>
        /// <param name="url">指定URL路径地址</param>
        /// <param name="timeOut">超时时间设置</param>
        /// <param name="encode"></param>
        /// <returns>服务器ATN结果</returns>
        public static string GetHttp(string strURL, int timeOut, Encoding encode)
        {
            StringBuilder strBuilder = new StringBuilder();
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            StreamReader streamReader = null;
            try
            {
                //strURL = UrlEncodeGB2312(strURL);
                request = (HttpWebRequest)HttpWebRequest.Create(strURL);
                request.Timeout = timeOut;
                response = (HttpWebResponse)request.GetResponse();
                streamReader = new StreamReader(response.GetResponseStream(), encode);
                strBuilder.Append(streamReader.ReadToEnd());
                streamReader.Close();
            }
            catch { }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
                if (response != null)
                {
                    response.Close();
                }
                if (request != null)
                {
                    request.Abort();
                }
            }
            return strBuilder.ToString();
        }
    }
}
