using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CBS.Payment.Entity.Model
{
    public class AlipayUnFreezeNotifyModel
    {
        public string Sign { get; set; }
        
        public string Amount { get; set; }
        
        public string UnFreeze_Out_Order_No { get; set; }
        
        public string Notify_Id { get; set; }
        
        public string Notify_Time { get; set; }
        
        public string Notify_Type { get; set; }
        
        public string Pay_Date { get; set; }
        
        public string Result_Code { get; set; }
        
        public string Status { get; set; }
        
        public string Trade_No { get; set; }
        
        public string User_Id { get; set; }
        
        public string User_Logon_Id { get; set; }

        public SortedDictionary<string, string> sPara { get; set; }
    }
}
