using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBS.Payment.Entity.PaymentDB
{
    /// <summary>
    /// 支付宝流水实体类
    /// <summary>
    public class AlipayFlowEntity
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
        /// 合作者ID
        /// </summary>
        public string PartnerID { get; set; }
        /// <summary>
        /// 合作者密钥
        /// </summary>
        public string PartnerKey { get; set; }
        /// <summary>
        /// 平台分配的唯一流水号
        /// <summary>
        public string PayNo { get; set; }
        /// <summary>
        /// 交易类型 1支付 2代扣 3补差 4分润 5退款 6转账 7冻结 8解冻
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
        /// 通知校验ID
        /// <summary>
        public string Notify_Id { get; set; }
        /// <summary>
        /// 通知时间
        /// <summary>
        public Nullable<DateTime> Notify_Time { get; set; }
        /// <summary>
        /// 通知类型
        /// <summary>
        public string Notify_Type { get; set; }
        /// <summary>
        /// 支付宝交易号
        /// <summary>
        public string Trade_No { get; set; }
        /// <summary>
        /// 交易状态
        /// <summary>
        public string Trade_Status { get; set; }
        /// <summary>
        /// 商户网站唯一订单号
        /// <summary>
        public string Out_Trade_No { get; set; }
        /// <summary>
        /// 商品名称
        /// <summary>
        public string Subject { get; set; }
        /// <summary>
        /// 商品描述
        /// <summary>
        public string Body { get; set; }
        /// <summary>
        /// 商品展示网址
        /// <summary>
        public string Show_Url { get; set; }
        /// <summary>
        /// 交易金额
        /// <summary>
        public decimal Total_Fee { get; set; }
        /// <summary>
        /// 支付类型
        /// <summary>
        public string Payment_Type { get; set; }
        /// <summary>
        /// 默认支付方式
        /// <summary>
        public string PayMethod { get; set; }
        /// <summary>
        /// 默认网银
        /// <summary>
        public string DefaultBank { get; set; }
        /// <summary>
        /// 卖家支付宝账号
        /// <summary>
        public string Seller_Email { get; set; }
        /// <summary>
        /// 卖家支付宝账户号
        /// <summary>
        public string Seller_Id { get; set; }
        /// <summary>
        /// 买家帐号
        /// <summary>
        public string Buyer_Email { get; set; }
        /// <summary>
        /// 买家ID
        /// </summary>
        public string Buyer_Id { get; set; }
        /// <summary>
        /// 买家名称
        /// </summary>
        public string Buyer_Name { get; set; }
        /// <summary>
        /// 提成(分账)类型:10(卖家给第三方提成)
        /// <summary>
        public string Royalty_Type { get; set; }
        /// <summary>
        /// 分润账号集，参数:收款方帐号^金额^备注|收款方帐号2^金额2^备注2
        /// <summary>
        public string Royalty_Parameters { get; set; }
        /// <summary>
        /// 公用业务扩展参数
        /// <summary>
        public string Extend_Param { get; set; }
        /// <summary>
        /// 代理业务编码，合作者ID+1000310004
        /// </summary>
        public string Type_Code { get; set; }
        /// <summary>
        /// 代扣模式(trade)
        /// </summary>
        public string Charge_Type { get; set; }
        /// <summary>
        /// 交易创建时间
        /// <summary>
        public Nullable<DateTime> Gmt_Create { get; set; }
        /// <summary>
        /// 交易付款时间
        /// <summary>
        public Nullable<DateTime> Gmt_payment { get; set; }
        /// <summary>
        /// 退款批次号/分润批次号/补差订单号
        /// <summary>
        public string Batch_No { get; set; }
        /// <summary>
        /// 子交易金额
        /// <summary>
        public decimal Suppl_Amount { get; set; }
        /// <summary>
        /// 总补差金额
        /// <summary>
        public decimal Total_Suppl_Amount { get; set; }
        /// <summary>
        /// 退款请求时间
        /// </summary>
        public Nullable<DateTime> Refund_Date { get; set; }
        /// <summary>
        /// 退款总笔数
        /// <summary>
        public int Batch_Num { get; set; }
        /// <summary>
        /// 退款明细
        /// <summary>
        public string Refund_Detail { get; set; }
        /// <summary>
        /// 是否使用冻结金额退款 Y 是，N否
        /// </summary>
        public string Use_Freeze_Amount { get; set; }
        /// <summary>
        /// 冻结明细
        /// <summary>
        public string Freezed_Details { get; set; }
        /// <summary>
        /// 解冻结果明细
        /// <summary>
        public string Unfreezed_Details { get; set; }
        /// <summary>
        /// 转账支付时间（YYYYMMDD）
        /// </summary>
        public string Pay_Date { get; set; }
        /// <summary>
        /// 转账成功的详细信息
        /// </summary>
        public string Success_Details { get; set; }
        /// <summary>
        /// 转账失败的详细信息
        /// <summary>
        public string Fail_Details { get; set; }
        /// <summary>
        /// 冻结单号
        /// <summary>
        public string FreezeNo { get; set; }
        /// <summary>
        /// 解冻单号
        /// <summary>
        public string UnFreezeNo { get; set; }
        /// <summary>
        /// 超时时间
        /// <summary>
        public string It_B_Pay { get; set; }
        /// <summary>
        /// 写入日期
        /// <summary>
        public Nullable<DateTime> ReqDate { get; set; }
    }
}
