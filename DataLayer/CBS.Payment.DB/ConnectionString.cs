using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using CBS.Payment.Utility;
namespace CBS.Payment.DB
{
    /// <summary>
    /// 数据库连接字符串
    /// </summary>
    public class ConnectionString
    {
        private static string _paymentDB_SELECT;
        private static string _paymentDB_INSERT;

        /// <summary>
        /// PaymentDB库只读连接
        /// </summary>
        public static string PaymentDB_SELECT
        {
            get
            {
                if (string.IsNullOrEmpty(_paymentDB_SELECT))
                {
                    _paymentDB_SELECT = AESHelper.AES_Decrypt(ConfigurationManager.ConnectionStrings["PaymentDB_SELECT"].ConnectionString);
                }
                return _paymentDB_SELECT;
            }
        }

        /// <summary>
        /// PaymentDB库写连接
        /// </summary>
        public static string PaymentDB_INSERT
        {
            get
            {
                if (string.IsNullOrEmpty(_paymentDB_INSERT))
                {
                    _paymentDB_INSERT = AESHelper.AES_Decrypt(ConfigurationManager.ConnectionStrings["PaymentDB_INSERT"].ConnectionString);
                }
                return _paymentDB_INSERT;
            }
        }
    }
}
