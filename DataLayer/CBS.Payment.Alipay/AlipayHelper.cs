using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CBS.Payment.Alipay.Model;
using System.Data;

namespace CBS.Payment.Alipay
{
    public class AlipayHelper
    {
        /// <summary>
        /// 支付宝纯网关接口,即时到帐交易接口
        /// </summary>
        /// <returns></returns>
        public static AlipayResponseBase<AlipayPay> AliTradePay(AlipayPay model)
        {
            string status = "F";
            string message = string.Empty;
            AlipayResponseBase<AlipayPay> resultmodel = new AlipayResponseBase<AlipayPay>();
            SortedDictionary<string, string> sParaTemp = new SortedDictionary<string, string>();

            try
            {
                sParaTemp.Add("service", AlipayServiceName.Trade_Pay);
                sParaTemp.Add("partner", model.Partner);
                sParaTemp.Add("notify_url", AlipayCommon.Pay_Notify_url);
                sParaTemp.Add("return_url", model.Return_url);
                sParaTemp.Add("out_trade_no", model.Out_trade_no);
                sParaTemp.Add("subject", model.Subject);
                sParaTemp.Add("body", model.Body);
                sParaTemp.Add("show_url", model.Show_url);
                sParaTemp.Add("total_fee", model.Total_fee);
                sParaTemp.Add("payment_type", model.Payment_type);
                sParaTemp.Add("paymethod", model.Paymethod);
                sParaTemp.Add("defaultbank", model.Defaultbank);
                if (!string.IsNullOrEmpty(model.Seller_email))
                    sParaTemp.Add("seller_email", model.Seller_email);
                if (!string.IsNullOrEmpty(model.Seller_id))
                    sParaTemp.Add("seller_id", model.Seller_id);
                if (!string.IsNullOrEmpty(model.Royalty_type) && string.Equals(model.Royalty_type, "10"))
                {
                    sParaTemp.Add("royalty_type", model.Royalty_type);
                    if (!string.IsNullOrEmpty(model.Royalty_parameters))
                        sParaTemp.Add("royalty_parameters", model.Royalty_parameters);
                }
                if (!string.IsNullOrEmpty(model.Extend_param))
                    sParaTemp.Add("extend_param", model.Extend_param);
                if (!string.IsNullOrEmpty(model.It_b_pay))
                    sParaTemp.Add("it_b_pay", model.It_b_pay);
                sParaTemp.Add("_input_charset", AlipayConfigHelper.Input_charset);

                string sPara = AlipayCoreHelper.GetPreSignStr(sParaTemp);
                model.RequestUrl = AlipayCoreHelper.CreateRequestUrl(sParaTemp, model.Key);
                sPara += "&RequestUrl=" + model.RequestUrl;


                if (!string.IsNullOrEmpty(model.RequestUrl))
                {
                    status = "T";
                    message = "";
                }

            }
            catch (Exception ex)
            {
                message = ex.ToString();

            }
            resultmodel.Status = status;
            resultmodel.Message = message;
            resultmodel.Data = model;
            return resultmodel;
        }

        /// <summary>
        /// 支付宝机票无密支付(CAE代扣)接口
        /// </summary>
        /// <returns></returns>
        public static AlipayResponseBase<AlipayCaePayResult> AliTradeCAEPay(AlipayCaePay model)
        {
            AlipayResponseBase<AlipayCaePayResult> resultmodel = new AlipayResponseBase<AlipayCaePayResult>();
   
            return resultmodel;
        }

        /// <summary>
        /// 支付宝分润接口
        /// </summary>
        /// <returns></returns>
        public static AlipayResponseBase<AlipayRoyalty> AliTradeRoyalty(AlipayRoyalty model)
        {
            AlipayResponseBase<AlipayRoyalty> resultmodel = new AlipayResponseBase<AlipayRoyalty>();
          
            return resultmodel;
        }

        /// <summary>
        /// 支付宝即时到账批量退款无密接口
        /// </summary>
        /// <returns></returns>
        public static AlipayResponseBase<AlipayRefund> AliTradeRefund(AlipayRefund model)
        {
            AlipayResponseBase<AlipayRefund> resultmodel = new AlipayResponseBase<AlipayRefund>();
           
            return resultmodel;
        }

        /// <summary>
        ///支付宝子交易补差接口
        /// </summary>
        /// <returns></returns>
        public static AlipayResponseBase<AlipaySuppl> AliTradeSuppl(AlipaySuppl model)
        {
            AlipayResponseBase<AlipaySuppl> resultmodel = new AlipayResponseBase<AlipaySuppl>();
           
            return resultmodel;
        }

        /// <summary>
        /// 批量转账（充值）接口
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static AlipayResponseBase<AlipayTrans> AliTradeTrans(AlipayTrans model)
        {
            AlipayResponseBase<AlipayTrans> resultmodel = new AlipayResponseBase<AlipayTrans>();
           
            return resultmodel;
        }

        /// <summary>
        /// 冻结接口
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static AlipayResponseBase<AlipayFreeze> AliTradeFreeze(AlipayFreeze model)
        {
            AlipayResponseBase<AlipayFreeze> resultmodel = new AlipayResponseBase<AlipayFreeze>();
          
            return resultmodel;

        }

        /// <summary>
        /// 解冻接口
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static AlipayResponseBase<AlipayUnFreeze> AliTradeUnFreeze(AlipayUnFreeze model)
        {
            AlipayResponseBase<AlipayUnFreeze> resultmodel = new AlipayResponseBase<AlipayUnFreeze>();
          
            return resultmodel;
        }

        /// <summary>
        /// 财务明细查询接口
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static AlipayResponseBase<AlipayAccountQueryResult> AliTradeAccountQuery(AlipayAccountQuery model)
        {
            AlipayResponseBase<AlipayAccountQueryResult> resultmodel = new AlipayResponseBase<AlipayAccountQueryResult>();
          
            return resultmodel;
        }
    }
}
