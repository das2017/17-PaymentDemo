using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBS.Payment.Alipay.Model
{
    /// <summary>
    /// 请求数据实体--账务明细分页查询明细
    /// </summary>
    public class AlipayAccountQueryDetail
    {
        /// <summary>
        /// 余额
        /// </summary>
        public string Balance { get; set; }
        /// <summary>
        /// 收入金额
        /// </summary>
        public string InCome { get; set; }
        /// <summary>
        /// 支出金额
        /// </summary>
        public string OutCome { get; set; }
        /// <summary>
        /// 交易付款时间
        /// </summary>
        public string Trans_Date { get; set; }
        /// <summary>
        /// 子业务类型
        /// </summary>
        public string Sub_Trans_Code_Msg { get; set; }
        /// <summary>
        /// 业务类型
        /// </summary>
        public string Trans_Code_Msg { get; set; }
        /// <summary>
        /// 商户订单号
        /// </summary>
        public string Merchant_Out_Order_No { get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
        public string Trans_Out_Order_No { get; set; }
        /// <summary>
        /// 银行名称
        /// </summary>
        public string Bank_Name { get; set; }
        /// <summary>
        /// 银行账号
        /// </summary>
        public string Bank_Account_No { get; set; }
        /// <summary>
        /// 银行账户名
        /// </summary>
        public string Bank_Account_Name { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Memo { get; set; }
        /// <summary>
        /// 买家支付宝人民币资金账号
        /// </summary>
        public string Buyer_Account { get; set; }
        /// <summary>
        /// 卖家支付宝人民币资金账号
        /// </summary>
        public string Seller_Account { get; set; }
        /// <summary>
        /// 卖家姓名
        /// </summary>
        public string Seller_Fullname { get; set; }
        /// <summary>
        /// 货币代码
        /// </summary>
        public string Currency { get; set; }
        /// <summary>
        /// 充值网银流水号
        /// </summary>
        public string Deposit_Bank_No { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string Goods_Title { get; set; }
        /// <summary>
        /// 财务序列号
        /// </summary>
        public string Iw_Account_Log_Id { get; set; }
        /// <summary>
        /// 财务本方支付宝人民币资金账号
        /// </summary>
        public string Trans_Account { get; set; }
        /// <summary>
        /// 财务对方邮箱
        /// </summary>
        public string Other_Account_Email { get; set; }
        /// <summary>
        ///  财务对方全称
        /// </summary>
        public string Other_Account_Fullname { get; set; }
        /// <summary>
        /// 财务对方支付宝用户号
        /// </summary>
        public string Other_User_Id { get; set; }
        /// <summary>
        /// 合作者身份ID
        /// </summary>
        public string Partner_Id { get; set; }
        /// <summary>
        /// 交易服务费
        /// </summary>
        public string Service_Fee { get; set; }
        /// <summary>
        /// 交易服务费率
        /// </summary>
        public string Service_Fee_Ratio { get; set; }
        /// <summary>
        /// 交易总金额
        /// </summary>
        public string Total_Fee { get; set; }
        /// <summary>
        /// 支付宝交易号
        /// </summary>
        public string Trade_No { get; set; }
        /// <summary>
        /// 累积退款金额
        /// </summary>
        public string Trade_Refund_Amount { get; set; }
        /// <summary>
        /// 签约产品
        /// </summary>
        public string Sign_Product_Name { get; set; }
        /// <summary>
        /// 费率
        /// </summary>
        public string Rate { get; set; }
        /// <summary>
        /// 拓展字段
        /// </summary>
        public string Ext_Info { get; set; }
    }
}
