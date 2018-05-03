using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace CBS.Payment.Tenpay
{
    /// <summary>
    /// 通讯类，支持http、https、双向https
    /// </summary>
    public class TenpayHttpHelper
    {
        //ca证书文件
        private string caFile;

        //证书文件
        private string certFile;

        //证书密码
        private string certPasswd;

        //字符编码
        private string charset;

        //错误信息
        private string errInfo;

        //请求方法
        private string method;

        //请求内容，无论post和get，都用get方式提供
        private string reqContent;

        //应答内容
        private string resContent;

        //http应答编码
        private int responseCode;

        //超时时间,以秒为单位
        private int timeOut;

        public TenpayHttpHelper()
        {
            this.caFile = "";
            this.certFile = "";
            this.certPasswd = "";

            this.reqContent = "";
            this.resContent = "";
            this.method = "POST";
            this.errInfo = "";
            this.timeOut = TenpayConfigHelper.Timeout;

            this.responseCode = 0;
            this.charset =TenpayConfigHelper.Input_charset;
        }

        //执行http调用
        public bool call()
        {
            StreamReader sr = null;
            HttpWebResponse wr = null;

            HttpWebRequest hp = null;
            try
            {
                string postData = null;
                if (this.method.ToUpper() == "POST")
                {
                    string[] sArray = System.Text.RegularExpressions.Regex.Split(this.reqContent, "\\?");

                    hp = (HttpWebRequest)WebRequest.Create(sArray[0]);

                    if (sArray.Length >= 2)
                    {
                        postData = sArray[1];
                    }
                }
                else
                {
                    hp = (HttpWebRequest)WebRequest.Create(this.reqContent);
                }

                ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(CheckValidationResult);
                if (this.certFile != "")
                {
                    try
                    {
                        hp.ClientCertificates.Add(new X509Certificate2(this.certFile, this.certPasswd, X509KeyStorageFlags.MachineKeySet));
                    }
                    catch (Exception exp)
                    {
                        X509Store store = new X509Store("My", StoreLocation.LocalMachine);
                        store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);

                        X509Certificate2 cert =
                            store.Certificates.Find(X509FindType.FindBySubjectName, this.certPasswd, false)[0];

                        hp.ClientCertificates.Add(cert);
                    }
                }
                hp.Timeout = this.timeOut * 1000;

                System.Text.Encoding encoding = System.Text.Encoding.GetEncoding(this.charset);
                if (postData != null)
                {
                    byte[] data = encoding.GetBytes(postData);

                    hp.Method = "POST";

                    hp.ContentType = "application/x-www-form-urlencoded";

                    hp.ContentLength = data.Length;

                    Stream ws = hp.GetRequestStream();

                    // 发送数据

                    ws.Write(data, 0, data.Length);
                    ws.Close();
                }

                wr = (HttpWebResponse)hp.GetResponse();
                sr = new StreamReader(wr.GetResponseStream(), encoding);

                this.resContent = sr.ReadToEnd();
                sr.Close();
                wr.Close();
            }
            catch (Exception exp)
            {
                this.errInfo += exp.Message;
                if (wr != null)
                {
                    this.responseCode = Convert.ToInt32(wr.StatusCode);
                }

                return false;
            }

            this.responseCode = Convert.ToInt32(wr.StatusCode);

            return true;
        }

        //验证服务器证书
        public bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true;
        }

        //获取错误信息
        public string getErrInfo()
        {
            return this.errInfo;
        }

        //获取结果内容
        public string getResContent()
        {
            return this.resContent;
        }

        //获取http状态码
        public int getResponseCode()
        {
            return this.responseCode;
        }

        //设置ca
        public void setCaInfo(string caFile)
        {
            this.caFile = caFile;
        }

        //设置证书信息
        public void setCertInfo(string certFile, string certPasswd)
        {
            this.certFile = certFile;
            this.certPasswd = certPasswd;
        }

        public void setCharset(string charset)
        {
            this.charset = charset;
        }

        //设置请求方法post或者get
        public void setMethod(string method)
        {
            this.method = method;
        }

        //设置请求内容
        public void setReqContent(string reqContent)
        {
            this.reqContent = reqContent;
        }

        //设置超时时间,以秒为单位

        public void setTimeOut(int timeOut)
        {
            this.timeOut = timeOut;
        }
    }
}
