using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Web;

namespace CBS.Payment.Alipay
{
    public class AlipayCoreHelper
    {
        /// <summary>
        /// 构造请求链接
        /// </summary>
        /// <param name="sParaTemp"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string CreateRequestUrl(SortedDictionary<string, string> sParaTemp, string key)
        {
            Encoding code = Encoding.GetEncoding(AlipayConfigHelper.Input_charset);
            Dictionary<string, string> sPara = new Dictionary<string, string>();
            sPara = AddSignPara(sParaTemp, key);
            return AlipayConfigHelper.Gateway + CreateLinkStringUrlencode(sPara, code);
        }

        /// <summary>
        /// 构造支付请求连接
        /// </summary>
        /// <param name="sParaTemp">请求参数数组</param>		
        /// <param name="key">获取或设交易安全校验码</param>
        /// <returns>要请求的参数数组</returns>
        private static Dictionary<string, string> AddSignPara(SortedDictionary<string, string> sParaTemp, string key)
        {
            Dictionary<string, string> sPara = new Dictionary<string, string>();
            //过滤签名参数数组
            sPara = FilterPara(sParaTemp);
            //获得签名结果
            string mysign = GetSign(sPara, key);
            sPara.Add("sign", mysign);
            sPara.Add("sign_type", AlipayConfigHelper.Sign_type);
            return sPara;
        }

        /// <summary>
        /// 除去数组中的空值和签名参数并以字母a到z的顺序排序
        /// </summary>
        /// <param name="dicArrayPre">过滤前的参数组</param>
        /// <returns>过滤后的参数组</returns>
        public static Dictionary<string, string> FilterPara(SortedDictionary<string, string> dicArrayPre)
        {
            Dictionary<string, string> dicArray = new Dictionary<string, string>();
            foreach (KeyValuePair<string, string> temp in dicArrayPre)
            {
                if (temp.Key.ToLower() != "sign" && temp.Key.ToLower() != "sign_type" && temp.Value != "" && temp.Value != null)
                {
                    dicArray.Add(temp.Key, temp.Value);
                }
            }

            return dicArray;
        }


        /// <summary>
        /// 生成请求时的签名
        /// </summary>
        /// <param name="sPara">请求给支付宝的参数数组</param>        
        /// <param name="key">获取或设交易安全校验码</param>
        /// <returns>签名结果</returns>
        public static string GetSign(Dictionary<string, string> sPara, string key)
        {
            string mysign = string.Empty;
            string prestr = CreateSignString(sPara, key);
            switch (AlipayConfigHelper.Sign_type)
            {
                case "MD5":
                    mysign = MD5Helper.Sign(prestr, key, AlipayConfigHelper.Input_charset);
                    break;
                default:
                    break;
            }
            return mysign;
        }

        /// <summary>
        /// 构造签名字符串
        /// </summary>
        /// <param name="sPara">需要签名的数组</param>
        /// <returns>返回拼接后的数组</returns>
        public static string CreateSignString(Dictionary<string, string> sPara, string key)
        {
            StringBuilder prestr = new StringBuilder();
            foreach (KeyValuePair<string, string> temp in sPara)
            {
                prestr.Append(temp.Key + "=" + temp.Value + "&");
            }

            //移除最后一个&
            prestr.Remove(prestr.Length - 1, 1);
            return prestr.ToString();
        }

        /// <summary>
        /// 把数组所有元素，按照“参数=参数值”的模式用“&”字符拼接成字符串
        /// </summary>
        /// <param name="sArray">需要拼接的数组</param>
        /// <returns>拼接完成以后的字符串</returns>
        public static string CreateLinkString(Dictionary<string, string> dicArray)
        {
            StringBuilder prestr = new StringBuilder();
            foreach (KeyValuePair<string, string> temp in dicArray)
            {
                prestr.Append(temp.Key + "=" + temp.Value + "&");
            }

            //去掉最後一個&字符
            int nLen = prestr.Length;
            prestr.Remove(nLen - 1, 1);

            return prestr.ToString();
        }

        /// <summary>
        /// 把数组所有元素，按照“参数=参数值”的模式用“&”字符拼接成字符串，并对参数值做urlencode
        /// </summary>
        /// <param name="dicArray">需要拼接的数组</param>
        /// <param name="code">字符编码</param>
        /// <returns>拼接完成以后的字符串</returns>
        public static string CreateLinkStringUrlencode(Dictionary<string, string> dicArray, Encoding code)
        {
            StringBuilder prestr = new StringBuilder();
            foreach (KeyValuePair<string, string> temp in dicArray)
            {
                prestr.Append(temp.Key + "=" + HttpUtility.UrlEncode(temp.Value, code) + "&");
            }

            //去掉最後一個&字符
            int nLen = prestr.Length;
            prestr.Remove(nLen - 1, 1);

            return prestr.ToString();
        }

        /// <summary>
        /// 组成代签名字符串
        /// </summary>
        /// <param name="inputPara">回调信息组成的数组</param>
        /// <returns></returns>
        public static string GetPreSignStr(SortedDictionary<string, string> inputPara)
        {
            Dictionary<string, string> sPara = new Dictionary<string, string>();

            //过滤空值、sign与sign_type参数
            sPara = FilterPara(inputPara);

            //获取待签名字符串
            string preSignStr = CreateLinkString(sPara);

            return preSignStr;
        }

        /// <summary>
        /// 获取支付宝POST过来通知消息，并以“参数名=参数值”的形式组成数组
        /// </summary>
        /// <returns>request回来的信息组成的数组</returns>
        public static SortedDictionary<string, string> GetRequestPost(NameValueCollection RequestForm)
        {
            int i = 0;
            SortedDictionary<string, string> sArray = new SortedDictionary<string, string>();
            NameValueCollection coll;
            //Load Form variables into NameValueCollection variable.
            coll = RequestForm;

            // Get names of all forms into a string array.
            String[] requestItem = coll.AllKeys;

            for (i = 0; i < requestItem.Length; i++)
            {
                sArray.Add(requestItem[i], RequestForm[requestItem[i]]);
            }

            return sArray;
        }

        /// <summary>
        /// 获取支付宝GET过来通知消息，并以“参数名=参数值”的形式组成数组
        /// </summary>
        /// <returns>request回来的信息组成的数组</returns>
        public static SortedDictionary<string, string> GetRequestGet(NameValueCollection RequestQueryString)
        {
            int i = 0;
            SortedDictionary<string, string> sArray = new SortedDictionary<string, string>();
            NameValueCollection coll;
            //Load Form variables into NameValueCollection variable.
            coll = RequestQueryString;

            // Get names of all forms into a string array.
            String[] requestItem = coll.AllKeys;

            for (i = 0; i < requestItem.Length; i++)
            {
                sArray.Add(requestItem[i], RequestQueryString[requestItem[i]]);
            }

            return sArray;
        }
    }
}
