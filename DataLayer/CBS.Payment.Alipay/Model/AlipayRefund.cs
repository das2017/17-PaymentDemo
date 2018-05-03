using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBS.Payment.Alipay.Model
{
    /// <summary>
    /// 请求数据实体--无密退款 
    /// </summary>
    public class AlipayRefund : AlipayRequestBase
    {
        /// <summary>
        /// 请求参数-退款批次号
        /// 格式为：退款日期（8 位当天日期）+流水号（3～24 位，流水号可以接受数字或英文字符，建议使用数字，但不可接受“000”）。
        /// </summary>
        public string Batch_no { get; set; }

        /// <summary>
        /// 请求参数-退款请求时间
        /// yyyy-MM-dd hh:mm:ss
        /// </summary>
        public string Refund_date { get; set; }

        /// <summary>
        /// 请求参数-退款总笔数
        /// </summary>
        public string Batch_num { get; set; }

        /// <summary>
        /// 请求参数-退款明细
        /// </summary>
        public string Detail_data { get; set; }

        /// <summary>
        /// 请求参数-是否使用冻结金额退款
        /// Y：可以使用冻结金额退款
        /// N：不可使用冻结金额退款
        /// </summary>
        public string Use_freeze_amount { get; set; }
        /// <summary>
        /// 响应-解冻结果明细
        /// </summary>
        public string Unfreezed_details { get; set; }
        /// <summary>
        /// 请求参数-充退通知地址
        /// </summary>
        public string Dback_notify_url { get; set; }
    }
}
