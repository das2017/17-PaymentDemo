using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBS.Payment.Alipay.Model
{
    /// <summary>
    /// 请求数据实体--批量转账（充值）接口
    /// </summary>
    public class AlipayTrans : AlipayRequestBase
    {
        /// <summary>
        /// 付款方的支付宝账号
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 付款账户名
        /// 付款方的支付宝账户名
        /// </summary>
        public string Account_Name { get; set; }

        /// <summary>
        /// 支付时间（必须为当前日期）。格式：YYYYMMDD。
        /// </summary>
        public string Pay_Date { get; set; }

        /// <summary>
        /// 批量付款批次号。11～32 位的数字或字母或数字与字母的组合，且区分大小写。
        /// </summary>
        public string Batch_No { get; set; }

        /// <summary>
        /// 付款总金额
        /// 格式：10.01，精确到分
        /// </summary>
        public string Batch_Fee { get; set; }

        /// <summary>
        /// 批量付款笔数（最多 1000笔）
        /// </summary>
        public string Batch_Num { get; set; }

        /// <summary>
        /// 付款详细数据
        /// 付款的详细数据，最多支持1000 笔。
        ///格式为：流水号 1^收款方账 号1^收款账号姓名1^付款金额 1^备注说明 1|流水号 2^收款方账号 2^收款账号姓名2^付款金额 2^备注说明 2。每条记录以“|”间隔。
        /// </summary>
        public string Detail_Data { get; set; }
        /// <summary>
        /// 转账失败的详细信息
        /// 格式为：流水号^收款方账号^收款账号姓名^付款金额^失败标识(F)^失败原因^支付宝内部流水号^完成时间。每条记录以“|”间隔。
        /// </summary>
        public string Fail_Details { get; set; }
        /// <summary>
        /// 业务扩展参数
        /// 用于商户的特定业务信息的传递，只有商户与支付宝约定了传递此参数且约定了参数含义，此参数才有效。
        /// 参数格式：参数名 1^参数值1|参数名 2^参数值 2|……多条数据用“|”间隔。
        /// </summary>
        public string Extend_Param { get; set; }
    }
}
