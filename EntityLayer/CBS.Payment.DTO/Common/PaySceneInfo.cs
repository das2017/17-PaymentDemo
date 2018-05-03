using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBS.Payment.DTO
{
    public class PaySceneInfo
    {
        /// <summary>
        /// 场景类型
        /// </summary>
        public SceneType Type { get; set; }
        /// <summary>
        /// 应用名
        /// </summary>
        public string AppName { get; set; }
        /// <summary>
        /// bundle_id、包名、URL
        /// </summary>
        public string AppValue { get; set; }
    }

    public enum SceneType
    {
        IOS,
        Android,
        WAP
    }
}
