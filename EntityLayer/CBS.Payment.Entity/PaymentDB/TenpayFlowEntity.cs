using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBS.Payment.Entity.PaymentDB
{
    /// <summary>
    /// 财付通流水实体类
    /// <summary>
    public class TenpayFlowEntity
    {
        /// <summary>
        /// 自增长编号
        /// <summary>
        public int PayID { get; set; }
        /// <summary>
        /// 处理状态 T 成功，F 失败
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// 同步 sync,异步async
        /// </summary>
        public string MsgType { get; set; }
        /// <summary>
        /// 信息
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 应用系统Id
        /// <summary>
        public string AppID { get; set; }
        /// <summary>
        /// 平台分配的账号
        /// <summary>
        public string PayAccount { get; set; }
        /// <summary>
        /// 平台分配的唯一流水号
        /// <summary>
        public string PayNo { get; set; }
        /// <summary>
        /// 交易类型 1支付 2分润 3退分润 4退款
        /// <summary>
        public string PayType { get; set; }
        /// <summary>
        /// 支付子类型
        /// </summary>
        public string PaySubType { get; set; }
        /// <summary>
        /// 支付宝返回结果信息
        /// </summary>
        public string RequestResult { get; set; }
        /// <summary>
        /// 财付通交易号
        /// <summary>
        public string Transaction_Id { get; set; }
        /// <summary>
        /// 用户(买方)的财付通账号(QQ或EMAIL)
        /// <summary>
        public string Purchaser_Id { get; set; }
        /// <summary>
        /// 收款方账号（退款、分润时的收款方）
        /// <summary>
        public string Trans_Account_In { get; set; }
        /// <summary>
        /// 商家订单号
        /// <summary>
        public string Sp_BillNo { get; set; }
        /// <summary>
        /// 总金额
        /// <summary>
        public decimal Total_Fee { get; set; }
        /// <summary>
        /// 支付币种
        /// <summary>
        public string Fee_Type { get; set; }
        /// <summary>
        /// 支付通知url
        /// <summary>
        public string Return_Url { get; set; }
        /// <summary>
        /// 交易日期
        /// <summary>
        public string Date { get; set; }
        /// <summary>
        /// 银行类型
        /// <summary>
        public string Bank_Type { get; set; }
        /// <summary>
        /// 交易的商品名称
        /// </summary>
        public string Desc { get; set; }
        /// <summary>
        /// 附加信息
        /// <summary>
        public string Attach { get; set; }
        /// <summary>
        /// 用户IP
        /// <summary>
        public string Spbill_Create_Ip { get; set; }
        /// <summary>
        /// 业务类型
        /// <summary>
        public string Bus_Type { get; set; }
        /// <summary>
        /// 业务参数
        /// <summary>
        public string Bus_Args { get; set; }
        /// <summary>
        /// 业务描述
        /// <summary>
        public string Bus_Desc { get; set; }
        /// <summary>
        /// 退款单号
        /// <summary>
        public string Refund_Id { get; set; }
        /// <summary>
        /// 退款金额
        /// <summary>
        public decimal Refund_Fee { get; set; }
        /// <summary>
        /// 平台退款-允许垫退标记  0不允许(默认)，1允许
        /// </summary>
        public string Advance_Refund_Flag { get; set; }
        /// <summary>
        /// 平台退款-本次允许的最大垫退金额
        /// </summary>
        public decimal Max_Advance_Refund_Fee { get; set; }
        /// <summary>
        /// 退款说明
        /// <summary>
        public string Refund_Desc { get; set; }
        /// <summary>
        /// 支付结果，详见“返回码”, 0—成功
        /// </summary>
        public string Pay_Result { get; set; }
        /// <summary>
        /// 支付结果信息，支付成功时可以为空
        /// </summary>
        public string Pay_Inf { get; set; }
        /// <summary>
        /// 写入日期
        /// <summary>
        public Nullable<DateTime> ReqDate { get; set; }
    }
}
