using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CBS.Payment.Alipay.Model
{
    /// <summary>
    /// 响应数据实体基类
    /// </summary>
    [DataContract]
    public class AlipayResponseBase<T>
    {
        /// <summary>
        /// 处理结果状态 T 成功，F 失败
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 处理结果描述
        /// </summary>
        public string Message { get; set; }
        ///// <summary>
        ///// 平台分配的账号
        ///// </summary>
        //public string PaymentAccount { get; set; }
        ///// <summary>
        ///// 平台分配的唯一流水号
        ///// </summary>
        //public string PaymentNo { get; set; }

        /// <summary>
        /// 支付宝支付请求结果
        /// </summary>
        public string RequestResult { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        public string Trade_no { get; set; }

        /// <summary>
        /// 交易状态
        /// </summary>
        public string Trade_status { get; set; }

        /// <summary>
        /// 通知校验ID
        /// </summary>
        public string Notify_id { get; set; }

        /// <summary>
        /// 通知时间
        /// </summary>
        public DateTime Notify_time { get; set; }

        /// <summary>
        /// 通知类型
        /// </summary>
        public string Notify_type { get; set; }

        /// <summary>
        /// 信息
        /// </summary>
        public T Data { get; set; }
    }
}
