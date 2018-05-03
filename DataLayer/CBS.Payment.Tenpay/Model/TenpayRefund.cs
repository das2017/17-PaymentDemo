using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBS.Payment.Tenpay.Model
{
    /// <summary>
    /// 请求数据实体--平台退款、分账回退接口
    /// </summary>
    public class TenpayRefund : TenpayRequestBase
    {
        /// <summary>
        /// 退款单ID，生成规则:109＋spid+YYYYMMDD+7位流水号。如果退款单号相同，则视为同一个退款申请
        /// </summary>
        public string Refund_Id { get; set; }

        /// <summary>
        /// 退款金额，以元为单位
        /// </summary>
        public string Refund_Fee { get; set; }

        /// <summary>
        /// 谨慎使用
        /// 允许垫退标记
        /// 0不允许，1允许
        /// 商户需要申请垫退权限后填写1才能生效
        /// 允许垫退表示该订单的平台退款金额可以大于分账退款总金额，请商户谨慎使用
        /// </summary>
        public string Advance_Refund_Flag { get; set; }

        /// <summary>
        /// 本次允许的最大垫退金额,单位为分
        /// </summary>
        public string Max_Advance_Refund_Fee { get; set; }

        /// <summary>
        /// 业务类型 暂固定为97
        /// 分润退款时使用
        /// </summary>
        public string Bus_Type{get;set;}

        /// <summary>
        /// 业务参数，特定格式的字符串，最多支持5方分润，格式为：账户^金额^角色[|(账户^金额^角色)]
        /// 分润退款时使用
        /// </summary>
        public string Bus_Args { get; set; }

        /// <summary>
        /// 退款说明信息
        /// </summary>
        public string Refund_Desc { get; set; }

    }
}
