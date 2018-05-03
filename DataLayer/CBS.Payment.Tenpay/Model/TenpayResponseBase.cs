using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CBS.Payment.Tenpay.Model
{
    /// <summary>
    /// 响应数据实体基类
    /// </summary>
    [DataContract]
    public class TenpayResponseBase<T>
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

        ///// <summary>
        ///// 财付通返回的支付结果 0—成功
        ///// </summary>
        //public string Pay_Result { get; set; }

        ///// <summary>
        ///// 财付通返回的支付结果信息，支付成功时可以为空
        ///// </summary>
        //public string Pay_Info { get; set; }

        /// <summary>
        /// 财付通支付请求结果
        /// </summary>
        public string RequestResult { get; set; }
        /// <summary>
        /// 信息
        /// </summary>
        public T Data { get; set; }
    }
}
