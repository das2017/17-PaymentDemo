using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CBS.Payment.Entity.Model
{
    public class AlipayRefundNotifyModel
    {
        public string Sign { get; set; }
        
        public string Batch_No { get; set; }
        
        public string Notify_Id { get; set; }
        
        public string Notify_Time { get; set; }
        
        public string Notify_Type { get; set; }
        
        public string Success_Num { get; set; }
        
        public string Result_Details { get; set; }
        
        public string Unfreezed_Details { get; set; }

        public SortedDictionary<string, string> sPara { get; set; }
    }
}
