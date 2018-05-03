using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CBS.Payment.Entity.Model
{
    public class AlipayPayReturnModel
    {
        public string Sign { get; set; }
        
        public string Body { get; set; }
        
        public string Buyer_Email { get; set; }
        
        public string Buyer_Id { get; set; }
        
        public string Notify_Id { get; set; }
        
        public string Notify_Time { get; set; }
        
        public string Notify_Type { get; set; }
        
        public string Out_Trade_No { get; set; }
        
        public string Payment_Type { get; set; }
        
        public string Seller_Email { get; set; }
        
        public string Seller_Id { get; set; }
        
        public string Subject { get; set; }
        
        public string Total_Fee { get; set; }
        
        public string Trade_No { get; set; }
        
        public string Trade_Status { get; set; }

        public SortedDictionary<string, string> sPara { get; set; }
    }
}
