using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBS.Payment.DTO
{
    public class PaySubMch
    {
        /// <summary>
        /// 子商户公众号
        /// </summary>
        public string SubAppID { get; set; }
        /// <summary>
        /// 子商户号
        /// </summary>
        public string SubMchID { get; set; }
        /// <summary>
        /// 子用户标识
        /// </summary>
        public string SubOpenID { get; set; }
    }
}
