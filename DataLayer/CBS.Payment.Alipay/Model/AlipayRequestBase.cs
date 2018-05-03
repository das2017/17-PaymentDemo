using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CBS.Payment.Alipay.Model
{
    /// <summary>
    /// 请求数据实体基类
    /// </summary>
    [DataContract]
    public class AlipayRequestBase
    {
        ///// <summary>
        ///// 请求参数-平台账号 ,每一个平台账号对应一个支付账号
        ///// </summary>
        //public string PaymentAccount { get; set; }
        ///// <summary>
        ///// 平台分配的唯一流水号
        ///// </summary>
        //public string PaymentNo { get; set; }
        /// <summary>
        /// 合作者身份ID
        /// </summary>
        public string Partner { get; set; }
        /// <summary>
        /// 商户的私钥
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// 请求参数-异步通知页面路径
        /// </summary>
        public string Notify_url { get; set; }

        /// <summary>
        /// 请求参数-同步通知页面路径
        /// </summary>
        public string Return_url { get; set; }
        /// <summary>
        /// 请求连接（指的是返回给客户的支付链接或JSON支付链接）
        /// </summary>
        public string RequestUrl { get; set; }
        
    }
}
