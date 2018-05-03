using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CBS.Payment.Utility
{
    public class Log
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public static void Inf(string message)
        {
            log.Info(message);
        }

        public static void Error(string message)
        {
            log.Error(message);
        }
    }
}
