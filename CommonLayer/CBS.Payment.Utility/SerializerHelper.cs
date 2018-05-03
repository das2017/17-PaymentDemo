using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CBS.Payment.Utility
{
    public class SerializerHelper
    {
        ///  实体类序列化成xml  
        /// </summary>  
        /// <param name="model">实体</param>  
        /// <returns></returns>  
        public static string SerializerToXml<T>(T model)
        {
            StringBuilder sb = new StringBuilder();
            PropertyInfo[] propinfos = null;
            sb.AppendLine("<?xml version='1.0' encoding='utf-8' ?>");
            sb.AppendLine("<Payment>");
            if (propinfos == null)
            {
                Type objtype = model.GetType();
                propinfos = objtype.GetProperties();
            }
            sb.AppendLine("<Item>");
            foreach (PropertyInfo propinfo in propinfos)
            {
                sb.Append("<");
                sb.Append(propinfo.Name);
                sb.Append(">");
                sb.Append(propinfo.GetValue(model, null));
                sb.Append("</");
                sb.Append(propinfo.Name);
                sb.AppendLine(">");
            }
            sb.AppendLine("</Item>");
            sb.AppendLine("</Payment>");
            return sb.ToString();
        }
    }
}
