using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBS.Payment.Entity.PaymentDB
{
    public class AppNotifyUrlEntity
    {
        /// <summary>
        /// 自增长编号
        /// </summary>
        public int NofifyUrlID{get;set;}
        /// <summary>
        /// 应用ID
        /// </summary>
        public string AppID{get;set;}
        /// <summary>
        /// 应用描述
        /// </summary>
        public string AppName{get;set;}
        /// <summary>
        /// ALL 表示所有信息都通知到同一页面路径
        /// </summary>
        public string NotifyType{get;set;}
        /// <summary>
        /// 通知的页面路径
        /// </summary>
        public string NotifyUrl{get;set;}
        /// <summary>
        /// 通知路径启用状态： 0 停用，1 启用
        /// </summary>
        public string Status { get; set; }
    }
}
