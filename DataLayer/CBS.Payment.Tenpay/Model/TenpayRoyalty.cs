using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBS.Payment.Tenpay.Model
{
    /// <summary>
    /// 分账
    /// </summary>
    public class TenpayRoyalty : TenpayRequestBase
    {
        ///// <summary>
        ///// 分账订单号
        ///// </summary>
        //public string Split_No { get; set; }

        /// <summary>
        /// 业务类型 暂固定为97
        /// </summary>
        public string Bus_Type { get; set; }

        /// <summary>
        /// 业务参数，特定格式的字符串，最多支持5方分润，格式为：账户^金额^角色[|(账户^金额^角色)]
        /// </summary>
        public string Bus_Args { get; set; }

        /// <summary>
        /// 业务描述，特定格式的字符串，格式为：PNR^航程^机票张数^机票销售商在机票平台的id^联系人姓名^联系电话
        /// </summary>
        public string Bus_Desc { get; set; }
    }
}
