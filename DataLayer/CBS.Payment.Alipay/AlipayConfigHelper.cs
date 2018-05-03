using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace CBS.Payment.Alipay
{
    /// <summary>
    /// 基础配置类
    /// </summary>
    public class AlipayConfigHelper
    {
        #region 字段
        private static string _gateway = "";
        private static string _input_charset = "";
        private static string _sign_type = "";
        private static int _timeout = 60;
        #endregion

        static AlipayConfigHelper()
        {
            _gateway = "https://mapi.alipay.com/gateway.do?";//支付宝网关地址
            _timeout =Convert.ToInt32( ConfigurationManager.AppSettings["Alipay_Timeout"]);//请求的超时时间
            _input_charset = "utf-8";//字符编码格式 目前支持 gbk 或 utf-8
            _sign_type = "MD5";//签名方式，选择项：RSA、DSA、MD5
        }

        #region 属性
        /// <summary>
        /// 支付宝网关地址
        /// </summary>
        public static string Gateway { get { return _gateway; } }

        /// <summary>
        /// 请求的超时时间，单位秒
        /// </summary>
        public static int TimeOut { get { return _timeout; } }

        /// <summary>
        /// 获取字符编码格式
        /// </summary>
        public static string Input_charset{ get { return _input_charset; } }

        /// <summary>
        /// 获取签名方式
        /// </summary>
        public static string Sign_type{ get { return _sign_type; } }
        #endregion
    }
}
