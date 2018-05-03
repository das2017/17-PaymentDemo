using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace CBS.Payment.Utility
{
    public class HttpHelper
    {
        /// <summary>
        /// post请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="data">请求参数</param>
        /// <returns></returns>
        public static string PostData(string url, string data)
        {
            try
            {
                WebRequest req = WebRequest.Create(url);
                req.Method = "POST";
                req.ContentType = "application/x-www-form-urlencoded";// "text/xml";
                byte[] postData = System.Text.Encoding.GetEncoding("utf-8").GetBytes(data);//Post的数据
                int lengthData = postData.Length;
                req.ContentLength = lengthData;
                Stream st = req.GetRequestStream();
                st.Write(postData, 0, lengthData);
                WebResponse resp = req.GetResponse();
                StreamReader sr = new StreamReader(resp.GetResponseStream());
                string content = System.Web.HttpUtility.UrlDecode(sr.ReadToEnd(), Encoding.GetEncoding("utf-8"));
                sr.Close();
                return content;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }
}
