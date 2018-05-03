using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CBS.Payment.Tenpay.Model
{
    /// <summary>
    /// 请求数据实体基类
    /// </summary>
    [DataContract]
    public class TenpayRequestBase
    {
        /// <summary>
        /// 支付网关地址
        /// 支付接口--https://www.tenpay.com/cgi-bin/v1.0/pay_gate.cgi
        /// 平台退款接口--https://api.mch.tenpay.com/cgi-bin/refund_b2c_split.cgi
        /// 分账接口--https://api.mch.tenpay.com/cgi-bin/split.cgi
        /// </summary>
        public string Gateway { get; set; }

        /// <summary>
        /// 版本号
        /// 填 4
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// 业务代码
        /// 支付接口  1
        /// 平台退款接口  93
        /// 分账接口  3 
        /// 分账回退  95
        /// </summary>
        public string Cmdno { get; set; }

        ///// <summary>
        ///// 请求参数-平台账号 ,每一个平台账号对应一个支付账号
        ///// </summary>
        //public string PaymentAccount { get; set; }
        ///// <summary>
        ///// 交易号--由支付平台统一生成分配
        ///// 28位长的数值（10位SPID+8位日期+10位流水号）
        ///// 10位SPID:商户网站编号，由财付通统一分配；
        ///// 8位日期，如20050415；
        ///// 10位流水号:商户需要保证一天内不同的事务（用户订购一次商品或购买一次服务），其ID不相同。
        ///// </summary>
        //public string PaymentNo { get; set; }
        /// <summary>
        /// 财付通交易号
        /// </summary>
        public string Transaction_Id { get; set; }

        /// <summary>
        /// 商家的商户号,由腾讯公司唯一分配
        /// </summary>
        public string Bargainor_Id { get; set; }

        /// <summary>
        /// 商户密钥
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 证书文件路径
        /// </summary>
        public string CertPath { get; set; }

        /// <summary>
        /// 证书密码
        /// </summary>
        public string CertPassword { get; set; }

        /// <summary>
        /// 订单号:商户系统内部的定单号，此参数仅在对账时提供,28个字符内
        /// </summary>
        public string Sp_BillNo { get; set; }

        /// <summary>
        /// 总金额:以元为单位
        /// </summary>
        public string Total_Fee { get; set; }

        /// <summary>
        /// 现金支付币种(人民币 1)
        /// </summary>
        public string Fee_Type { get; set; }

        /// <summary>
        /// 接收财付通返回结果的URL
        /// </summary>
        public string Return_Url { get; set; }
        /// <summary>
        /// 构造请求连接
        /// </summary>
        public string RequestUrl { get; set; }
    }
}
