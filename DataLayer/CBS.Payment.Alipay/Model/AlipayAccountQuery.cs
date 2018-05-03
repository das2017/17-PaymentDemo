using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBS.Payment.Alipay.Model
{
    /// <summary>
    /// 请求数据实体--账务明细分页查询
    /// </summary>
    public class AlipayAccountQuery : AlipayRequestBase
    {
        /// <summary>
        /// 查询页号
        /// </summary>
        public string Page_No { get; set; }
        /// <summary>
        /// 分页大小
        /// </summary>
        public string Page_Size { get; set; }
        /// <summary>
        /// 账务查询开始时间
        /// </summary>
        public string Gmt_Start_Time { get; set; }
        /// <summary>
        /// 账务查询结束时间
        /// </summary>
        public string Gmt_End_Time { get; set; }
        /// <summary>
        /// 交易收款账户
        /// </summary>
        public string Logon_Id { get; set; }
        /// <summary>
        /// 账务流水号
        /// </summary>
        public string Iw_Account_Log_Id { get; set; }
        /// <summary>
        /// 业务流水号
        /// </summary>
        public string Trade_No { get; set; }
        /// <summary>
        /// 商户订单号
        /// </summary>
        public string Merchant_Out_Order_No { get; set; }
        /// <summary>
        /// 充值网银流水号
        /// </summary>
        public string Deposit_Bank_No { get; set; }

        /// <summary>
        /// 交易类型代码
        /// </summary>
        public string Trans_Code { get; set; }
    }
}
