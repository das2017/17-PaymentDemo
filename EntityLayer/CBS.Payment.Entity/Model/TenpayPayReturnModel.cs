using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CBS.Payment.Entity.Model
{
    public class TenpayPayReturnModel
    {
        public string CmdNo { get; set; }
        
        public string Pay_Result { get; set; }
        
        public string Date { get; set; }
        
        public string Transaction_Id { get; set; }
        
        public string Sp_NillNo { get; set; }
        
        public string Total_Fee { get; set; }
        
        public string Fee_Type { get; set; }
        
        public string Attach { get; set; }

        public string Sign { get; set; }

    }
}
