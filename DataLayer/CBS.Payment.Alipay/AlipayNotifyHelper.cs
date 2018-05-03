using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBS.Payment.Alipay
{
    public class AlipayNotifyHelper
    {
        /// <summary>
        /// 验证消息是否是支付宝发出的合法消息
        /// </summary>
        /// <param name="inputPara">通知返回参数数组</param>
        /// <param name="notify_id">通知验证id</param>
        /// <param name="sign">支付宝生成的签名结果</param>
        /// <param name="partner">合作者身份ID</param>
        /// <returns>验证结果</returns>     
        public static bool Verify(SortedDictionary<string, string> inputPara, string notify_id, string sign, string partner, string key)
        {
            string responseTxt = "true";
            bool isSign = GetSignVeryfy(inputPara, sign, partner, key);
            if (!string.IsNullOrEmpty(notify_id))
                responseTxt = GetResponseTxt(notify_id, partner);
            return string.Equals(responseTxt, "true") && isSign;
        }


        /// <summary>
        /// 获取返回时的签名验证结果
        /// </summary>
        /// <param name="inputPara">通知返回参数数组</param>
        /// <param name="sign">对比的签名结果</param>
        /// <param name="partner">合作者身份ID</param>
        /// <returns>签名验证结果</returns>
        private static bool GetSignVeryfy(SortedDictionary<string, string> inputPara, string sign, string partner, string key)
        {
            Dictionary<string, string> sPara = new Dictionary<string, string>();
            //过滤空值、sign与sign_type参数
            sPara = AlipayCoreHelper.FilterPara(inputPara);
            //获得签名结果
            string mysign = AlipayCoreHelper.GetSign(sPara, key);
            if (!string.IsNullOrEmpty(sign) && !string.IsNullOrEmpty(mysign))
                return string.Equals(mysign, sign);
            return false;
        }

        /// <summary>
        /// 获取是否是支付宝服务器发来的请求的验证结果
        /// </summary>
        /// <param name="notify_id">通知验证ID</param>
        /// <param name="partner">合作者身份ID</param>
        /// <returns>验证结果</returns>
        private static string GetResponseTxt(string notify_id, string partner)
        {
            string veryfy_url = string.Format("{0}service=notify_verify&partner={1}&notify_id={2}", AlipayConfigHelper.Gateway, partner, notify_id);
            return AlipayCommon.GetHttp(veryfy_url, AlipayConfigHelper.TimeOut, Encoding.Default);
        }
    }
}
