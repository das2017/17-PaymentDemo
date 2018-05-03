using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CBS.Payment.Tenpay.Model;

namespace CBS.Payment.Tenpay
{
    public class TenpayHelper
    {
        /// <summary>
        /// 纯网关接口
        /// </summary>
        /// <returns></returns>
        public static TenpayResponseBase<TenpayPay> TenTradePay(TenpayPay model)
        {
            
            string status = "F";
            string message = string.Empty;
            TenpayResponseBase<TenpayPay> resultmodel = new TenpayResponseBase<TenpayPay>();
            TenpayPayRequestHandler reqHandler = new TenpayPayRequestHandler(System.Web.HttpContext.Current);
            try
            {
                reqHandler.init();
                reqHandler.setKey(model.Key);
                reqHandler.setParameter("cmdno", TenpayCmdNo.Trade_Pay);
                reqHandler.setParameter("date", model.Date);
                reqHandler.setParameter("bank_type", model.Bank_Type);
                reqHandler.setParameter("desc", model.Desc);
                reqHandler.setParameter("bargainor_id", model.Bargainor_Id);
                reqHandler.setParameter("transaction_id", model.Transaction_Id);
                reqHandler.setParameter("sp_billno", model.Sp_BillNo);
                reqHandler.setParameter("total_fee", Math.Round(Convert.ToDouble(model.Total_Fee) * 100, 0).ToString());
                reqHandler.setParameter("fee_type", model.Fee_Type);
                reqHandler.setParameter("return_url", TenpayCommon.Pay_Return_url);
                reqHandler.setParameter("attach", model.Attach);
                reqHandler.setParameter("spbill_create_ip", model.Spbill_Create_Ip);
                reqHandler.setParameter("cs", TenpayConfigHelper.Input_charset);
                reqHandler.setParameter("version", TenpayConfigHelper.Version);

                if (!string.IsNullOrEmpty(model.Bus_Type))
                    reqHandler.setParameter("bus_type", model.Bus_Type);
                if (!string.IsNullOrEmpty(model.Bus_Args))
                    reqHandler.setParameter("bus_args", model.Bus_Args);
                if (!string.IsNullOrEmpty(model.Bus_Desc))
                    reqHandler.setParameter("bus_desc", model.Bus_Desc);

                model.RequestUrl = reqHandler.getRequestURL();
                string sPara = reqHandler.getDebugInfo();
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
        /// 分润接口
        /// </summary>
        /// <returns></returns>
        public static TenpayResponseBase<TenpayRoyalty> TenTradeRoyalty(TenpayRoyalty model)
        {
            string status = "F";
            string message = string.Empty;
            TenpayResponseBase<TenpayRoyalty> resultmodel = new TenpayResponseBase<TenpayRoyalty>();
            TenpayBaseSplitRequestHandler reqHandler = new TenpayBaseSplitRequestHandler(System.Web.HttpContext.Current);//创建请求对象
            TenpayHttpHelper httpClient = new TenpayHttpHelper();//通信对象
            TenpayScriptClientResponseHandler resHandler = new TenpayScriptClientResponseHandler();//应答对象

            try
            {
                reqHandler.init();
                reqHandler.setKey(model.Key);
                reqHandler.setGateUrl(TenpayConfigHelper.Split_Gateway);
                reqHandler.setParameter("cmdno", TenpayCmdNo.Trade_Royalty);
                reqHandler.setParameter("bargainor_id", model.Bargainor_Id);
                reqHandler.setParameter("transaction_id", model.Transaction_Id);
                reqHandler.setParameter("sp_billno", model.Sp_BillNo);
                reqHandler.setParameter("total_fee", Math.Round(Convert.ToDouble(model.Total_Fee) * 100, 0).ToString());
                reqHandler.setParameter("fee_type", model.Fee_Type);
                reqHandler.setParameter("return_url", TenpayCommon.Royalty_Return_url);
                reqHandler.setParameter("bus_type", model.Bus_Type);
                reqHandler.setParameter("bus_args", model.Bus_Args);
                reqHandler.setParameter("bus_desc", model.Bus_Desc);
                reqHandler.setParameter("version", TenpayConfigHelper.Version);

                //证书路径
                string certPath = model.CertPath;
                //证书密码
                string certPassword = model.CertPassword;

                httpClient.setCertInfo(certPath, certPassword);
                model.RequestUrl = reqHandler.getRequestURL();
                string sPara = reqHandler.getDebugInfo();
                sPara += "&RequestUrl=" + model.RequestUrl;
                //设置请求内容
                httpClient.setReqContent(model.RequestUrl);
                //设置超时
                httpClient.setTimeOut(TenpayConfigHelper.Timeout);
                //后台调用
                if (httpClient.call())
                {
                    //获取结果
                    resultmodel.RequestResult = httpClient.getResContent();
                    resHandler.setKey(model.Key);
                    //设置结果参数
                    resHandler.setContent(resultmodel.RequestResult);
                    //判断签名及结果
                    if (resHandler.isTenpaySign() && resHandler.getParameter("pay_result") == "0")
                    {
                        status = "T";
                    }
                    else
                    {
                        message = resHandler.getParameter("pay_result") + "," + resHandler.getParameter("pay_info");
                    }
                }
                else
                {
                    message = httpClient.getErrInfo() + httpClient.getResponseCode();
                }
            }
            catch(Exception ex)
            {
                message = ex.ToString();
            }
            resultmodel.Status = status;
            resultmodel.Message = message;
            resultmodel.Data = model;
            return resultmodel;
        }

        /// <summary>
        /// 分润退款
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static TenpayResponseBase<TenpayRefund> TenTradeRoyaltyRollBack(TenpayRefund model)
        {
            string status = "F";
            string message = string.Empty;
            TenpayResponseBase<TenpayRefund> resultmodel = new TenpayResponseBase<TenpayRefund>();
            TenpayBaseSplitRequestHandler reqHandler = new TenpayBaseSplitRequestHandler(System.Web.HttpContext.Current);//创建请求对象
            TenpayHttpHelper httpClient = new TenpayHttpHelper();//通信对象
            TenpayScriptClientResponseHandler resHandler = new TenpayScriptClientResponseHandler();//应答对象

            try
            {
                reqHandler.init();
                reqHandler.setKey(model.Key);
                reqHandler.setGateUrl(TenpayConfigHelper.SplitRollback_Gateway);
                reqHandler.setParameter("cmdno", TenpayCmdNo.Trade_RoyaltyRollBack);
                reqHandler.setParameter("bargainor_id", model.Bargainor_Id);
                reqHandler.setParameter("transaction_id", model.Transaction_Id);
                reqHandler.setParameter("sp_billno", model.Sp_BillNo);
                reqHandler.setParameter("total_fee", Math.Round(Convert.ToDouble(model.Total_Fee) * 100, 0).ToString());
                reqHandler.setParameter("fee_type", model.Fee_Type);
                reqHandler.setParameter("return_url", TenpayCommon.RoyaltyRollBack_Return_url);
                reqHandler.setParameter("refund_id", model.Refund_Id);
                reqHandler.setParameter("bus_type", model.Bus_Type);
                reqHandler.setParameter("bus_args", model.Bus_Args);
                reqHandler.setParameter("version", TenpayConfigHelper.Version);
                //reqHandler.setParameter("rollback_desc", model.Refund_Desc);
                //证书路径
                string certPath = model.CertPath;
                //证书密码
                string certPassword = model.CertPassword;
                httpClient.setCertInfo(certPath, certPassword);
                model.RequestUrl = reqHandler.getRequestURL();
                string sPara = reqHandler.getDebugInfo();
                sPara += "&RequestUrl=" + model.RequestUrl;
                //设置请求内容
                httpClient.setReqContent(model.RequestUrl);
                //设置超时
                httpClient.setTimeOut(TenpayConfigHelper.Timeout);
                //后台调用
                if (httpClient.call())
                {
                    //获取结果
                    resultmodel.RequestResult = httpClient.getResContent();
                    resHandler.setKey(model.Key);
                    //设置结果参数
                    resHandler.setContent(resultmodel.RequestResult);
                    //判断签名及结果
                    if (resHandler.isTenpaySign() && resHandler.getParameter("pay_result") == "0")
                    {
                        status = "T";
                    }
                    else
                    {
                        message = resHandler.getParameter("pay_result") + "," + resHandler.getParameter("pay_info");
                    }
                }
                else
                {
                    message = httpClient.getErrInfo() + httpClient.getResponseCode();
                }
            }
            catch(Exception ex)
            {
                message = ex.ToString();
            }
            resultmodel.Status = status;
            resultmodel.Message = message;
            resultmodel.Data = model;
            return resultmodel;
        }

        /// <summary>
        /// 退款接口
        /// </summary>
        /// <returns></returns>
        public static TenpayResponseBase<TenpayRefund> TenTradeRefund(TenpayRefund model)
        {
            string status = "F";
            string message = string.Empty;
            TenpayResponseBase<TenpayRefund> resultmodel = new TenpayResponseBase<TenpayRefund>();
            TenpayBaseSplitRequestHandler reqHandler = new TenpayBaseSplitRequestHandler(System.Web.HttpContext.Current);//创建请求对象
            TenpayHttpHelper httpClient = new TenpayHttpHelper();//通信对象
            TenpayScriptClientResponseHandler resHandler = new TenpayScriptClientResponseHandler();//应答对象
            try
            {
                reqHandler.init();
                reqHandler.setKey(model.Key);
                reqHandler.setGateUrl(TenpayConfigHelper.Refund_Gateway);
                reqHandler.setParameter("cmdno", TenpayCmdNo.Trade_Refund);
                reqHandler.setParameter("version", TenpayConfigHelper.Version);
                reqHandler.setParameter("fee_type", model.Fee_Type);
                reqHandler.setParameter("bargainor_id", model.Bargainor_Id);
                reqHandler.setParameter("sp_billno", model.Sp_BillNo);
                reqHandler.setParameter("transaction_id", model.Transaction_Id);
                reqHandler.setParameter("return_url", TenpayCommon.Refund_Return_url);
                reqHandler.setParameter("total_fee", Math.Round(Convert.ToDouble(model.Total_Fee) * 100, 0).ToString());
                reqHandler.setParameter("refund_id", model.Refund_Id);
                reqHandler.setParameter("refund_fee", Math.Round(Convert.ToDouble(model.Refund_Fee) * 100, 0).ToString());
                reqHandler.setParameter("refund_desc", model.Refund_Desc);
                if (!string.IsNullOrEmpty(model.Advance_Refund_Flag) && model.Advance_Refund_Flag=="1")
                {
                    reqHandler.setParameter("advance_refund_flag", model.Advance_Refund_Flag);
                    reqHandler.setParameter("max_advance_refund_fee", Math.Round(Convert.ToDouble(model.Max_Advance_Refund_Fee) * 100, 0).ToString());
                }
                //证书路径
                string certPath = model.CertPath;
                //证书密码
                string certPassword = model.CertPassword;
                httpClient.setCertInfo(certPath, certPassword);
                model.RequestUrl = reqHandler.getRequestURL();

                string sPara = reqHandler.getDebugInfo();
                sPara += "&RequestUrl=" + model.RequestUrl;

                //设置请求内容
                httpClient.setReqContent(model.RequestUrl);
                //设置超时
                httpClient.setTimeOut(TenpayConfigHelper.Timeout);
                //后台调用
                if (httpClient.call())
                {
                    //获取结果
                    resultmodel.RequestResult = httpClient.getResContent();
                    resHandler.setKey(model.Key);
                    //设置结果参数
                    resHandler.setContent(resultmodel.RequestResult);
                    //判断签名及结果
                    if (resHandler.isTenpaySign() && resHandler.getParameter("pay_result") == "0")
                    {
                        status = "T";
                    }
                    else
                    {
                        message = resHandler.getParameter("pay_result") + "," + resHandler.getParameter("pay_info");
                    }
                }
                else
                {
                    message = httpClient.getErrInfo() + httpClient.getResponseCode();
                }
            }
            catch(Exception ex)
            {
                message = ex.ToString();
            }
            resultmodel.Status = status;
            resultmodel.Message = message;
            resultmodel.Data = model;
            return resultmodel;
        }
    }
}
