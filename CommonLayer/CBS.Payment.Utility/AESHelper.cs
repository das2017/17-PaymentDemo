using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace CBS.Payment.Utility
{
    public class AESHelper
    {
        private static string _aesKey = "aa01223344556677";
        private static string _aesIV = "aa01223344556677";

        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="value">待加密字符串</param>
        /// <returns>Base64转码后的密文</returns>
        public static string AES_Encrypt(string value)
        {
            byte[] keyArray = UTF8Encoding.UTF8.GetBytes(_aesKey);
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(value);
            byte[] ivArray = UTF8Encoding.UTF8.GetBytes(_aesIV);
            RijndaelManaged rDel = new RijndaelManaged();
            rDel.Key = keyArray;
            rDel.IV = ivArray;
            rDel.Mode = CipherMode.CBC;
            rDel.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = rDel.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="value">待解密字符串</param>
        /// <returns>解密后的明文</returns>
        public static string AES_Decrypt(string value)
        {
            byte[] keyArray = UTF8Encoding.UTF8.GetBytes(_aesKey);
            byte[] toEncryptArray = Convert.FromBase64String(value);
            byte[] ivArray = UTF8Encoding.UTF8.GetBytes(_aesIV);
            RijndaelManaged rDel = new RijndaelManaged();
            rDel.Key = keyArray;
            rDel.IV = ivArray;
            rDel.Mode = CipherMode.CBC;
            rDel.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = rDel.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return UTF8Encoding.UTF8.GetString(resultArray);
        }
    }
}
