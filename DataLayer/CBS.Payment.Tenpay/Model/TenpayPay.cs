using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBS.Payment.Tenpay.Model
{
    /// <summary>
    /// 请求数据实体--支付、支付并分账接口
    /// </summary>
    public class TenpayPay : TenpayRequestBase
    {
        /// <summary>
        /// 商户日期：如20051212
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// 银行类型:财付通支付填0
        /// </summary>
        public string Bank_Type { get; set; }

        /// <summary>
        /// 交易的商品名称,128个字符,不包含特殊符号
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 商家数据包，原样返回
        /// </summary>
        public string Attach { get; set; }

        /// <summary>
        /// 用户IP（非商户服务器IP），为了防止欺诈，支付时财付通会校验此IP
        /// </summary>
        public string Spbill_Create_Ip { get; set; }

        /// <summary>
        /// 业务类型 暂固定为97
        /// 调用支付并分账接口时使用
        /// </summary>
        public string Bus_Type { get; set; }

        /// <summary>
        /// 业务参数，特定格式的字符串，最多支持5方分润，格式为：账户^金额^角色[|(账户^金额^角色)]
        /// 调用支付并分账接口时使用
        /// </summary>
        public string Bus_Args { get; set; }

        /// <summary>
        /// 业务描述,特定格式的字符串，格式为：PNR^航程^机票张数^机票销售商在机票平台的id^联系人姓名^联系电话
        /// 调用支付并分账接口时使用
        /// </summary>
        public string Bus_Desc { get; set; }
    }
}
