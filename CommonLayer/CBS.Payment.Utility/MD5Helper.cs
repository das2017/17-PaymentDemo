using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBS.Payment.Utility
{
    public class MD5Helper
    {
        /// <summary>
        /// 密钥
        /// </summary>
        private static string key = "test";
        /// <summary>
        /// 获取HASH摘要
        /// </summary>
        /// <param name="value">待加密字符串</param>
        /// <returns>HASH摘要</returns>
        private static string GetHashCode(string value)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider MD5CSP = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bytValue = System.Text.Encoding.UTF8.GetBytes(value);
            byte[] bytHash = MD5CSP.ComputeHash(bytValue);
            string hashedValue = "";
            foreach (byte b in bytHash)
            {
                hashedValue += b.ToString("x2");
            }
            return hashedValue;
        }

        /// <summary>
        /// 对字符串进行MD5加密
        /// </summary>
        /// <param name="value">待加密字符串</param>
        /// <returns>MD5密文</returns>
        private static String GetMD5(String value)
        {
            char[] hexDigits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
					'A', 'B', 'C', 'D', 'E', 'F' };
            try
            {
                byte[] btInput = System.Text.Encoding.Default.GetBytes(value);
                // 获得MD5摘要算法的 MessageDigest 对象
                System.Security.Cryptography.MD5 mdInst = System.Security.Cryptography.MD5.Create();
                // 使用指定的字节更新摘要
                mdInst.ComputeHash(btInput);
                // 获得密文
                byte[] md = mdInst.Hash;
                // 把密文转换成十六进制的字符串形式
                int j = md.Length;
                char[] str = new char[j * 2];
                int k = 0;
                for (int i = 0; i < j; i++)
                {
                    byte byte0 = md[i];
                    str[k++] = hexDigits[(int)(((byte)byte0) >> 4) & 0xf];
                    str[k++] = hexDigits[byte0 & 0xf];
                }
                return new string(str);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        /// <summary>
        /// 签名
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetSign(string value)
        {
            if (string.IsNullOrEmpty(value)) return "";

            string data = value+"&key="+key;
            string dataHash = GetHashCode(data);
            return GetMD5(dataHash);
        }

    }
}
