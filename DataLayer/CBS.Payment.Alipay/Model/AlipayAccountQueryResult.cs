using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBS.Payment.Alipay.Model
{
    /// <summary>
    /// 响应数据实体--账务明细分页查询
    /// </summary>
    public class AlipayAccountQueryResult
    {
        /// <summary>
        /// 是否有下一页
        /// </summary>
        public string Has_next_page { get; set; }
        /// <summary>
        /// 当前页号
        /// </summary>
        public string Page_No { get; set; }
        /// <summary>
        /// 分页大小
        /// </summary>
        public string Page_Size { get; set; }
        /// <summary>
        /// 账务明细列表
        /// </summary>
        public List<AlipayAccountQueryDetail> Account_Query_List { get; set; }
    }
}
