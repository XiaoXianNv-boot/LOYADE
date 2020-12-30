using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.UI;


namespace LOYADE.ACCESS
{
    /// <summary>
    /// 服务器配置
    /// </summary>
    public class __ServerConfig
    {
        public static readonly int LogicServerCountMax = 100;
        public static readonly int SingleLogicServerUserCountMax = 1000000;

        public static readonly int CacheValueSizeMax = 1024;

    }
}