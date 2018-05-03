using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace CBS.Payment.Tenpay
{
    /// <summary>
    /// 基础配置类
    /// </summary>
    public class TenpayConfigHelper
    {
        private static string _input_charset = "";//字符编码格式
        private static string _pay_gateway = "https://www.tenpay.com/cgi-bin/v1.0/pay_gate.cgi";//网关地址（纯网关支付）
        private static string _split_gateway = "https://api.mch.tenpay.com/cgi-bin/split.cgi";//网关地址（分润）
        private static string _splitrollback_gateway = "https://api.mch.tenpay.com/cgi-bin/split_rollback.cgi";//网关地址（分润退款）
        private static string _refund_gateway = "https://api.mch.tenpay.com/cgi-bin/refund_b2c_split.cgi";//网关地址（退款）
        private static int _timeout = 60;//请求的超时时间
        private static string _version = "4";//版本号
        static TenpayConfigHelper()
        {
            _input_charset = "gbk";
            _timeout = Convert.ToInt32(ConfigurationManager.AppSettings["Tenpay_Timeout"]);//请求的超时时间
        }
        /// <summary>
        /// 字符编码格式
        /// </summary>
        public static string Input_charset { get { return _input_charset; } }
        /// <summary>
        /// 网关地址（纯网关支付）
        /// </summary>
        public static string Pay_Gateway { get { return _pay_gateway; } }
        /// <summary>
        /// 网关地址（分润）
        /// </summary>
        public static string Split_Gateway { get { return _split_gateway; } }
        /// <summary>
        /// 网关地址（分润退款）
        /// </summary>
        public static string SplitRollback_Gateway { get { return _splitrollback_gateway; } }
        /// <summary>
        /// 网关地址（退款）
        /// </summary>
        public static string Refund_Gateway { get { return _refund_gateway; } }
        /// <summary>
        /// 请求的超时时间，单位秒
        /// </summary>
        public static int Timeout { get { return _timeout; } }

        /// <summary>
        /// 版本号
        /// </summary>
        public static string Version { get { return _version; } }
    }
}
