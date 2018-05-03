using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBS.Payment.Alipay.Model
{
    /// <summary>
    /// 请求数据实体--解冻接口
    /// </summary>
    public class AlipayUnFreeze : AlipayRequestBase
    {
        /// <summary>
        /// 解冻结订单号^冻结订单号^解冻结金额， 多条信息使用“|”连接
        /// </summary>
        public string Unfreeze_Details { get; set; }
    }
}
