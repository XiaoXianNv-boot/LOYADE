using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.UI;


namespace LOYADE.ACCESS
{
    /// <summary>
    /// 仅用于用户身份验证和用户关联记录索引值，禁止存放大型变量数据
    /// </summary>
    public class __ServerUserPageKeyValue
    {
        //int - 逻辑服务器号
        //string - 用户名（同逻辑服务器不允许多点登录，不同逻辑服务器可以同账号登录）
        //string - 页面名+时间戳（可以打开多个同名页面）
        //string - 变量名
        private static Dictionary<int, Dictionary<string, Dictionary<string, Dictionary<string, string>>>> _dickv = new Dictionary<int, Dictionary<string, Dictionary<string, Dictionary<string, string>>>>();

        /// <summary>
        /// 逻辑服务器的用户登录时间戳，判断是否超时
        /// </summary>
        private static Dictionary<int, Dictionary<string, DateTime>> _dicutc = new Dictionary<int, Dictionary<string, DateTime>>();

        public static bool KVInsert(int serverid, string userkey, string pagetskey, string varkey, string varvalue)
        {
            if (varvalue.Length > 1024)
                return false;

            if (_dickv.ContainsKey(serverid))
            {
                //可控制单台服务器的用户在线数量
                if (_dickv[serverid].Count > 10000)
                    return false;

                if (_dickv[serverid].ContainsKey(userkey))
                {
                    if (_dickv[serverid][userkey].ContainsKey(pagetskey))
                    {
                        if (_dickv[serverid][userkey][pagetskey].ContainsKey(varkey))
                        {
                            _dickv[serverid][userkey][pagetskey][varkey] = varvalue;
                        }
                        else
                        {

                        }
                    }
                }
            }
            else
            {
                _dickv.Add(serverid, new Dictionary<string, Dictionary<string, Dictionary<string, string>>>());
            }
            return true;
        }

        public static bool KVUpdate(int serverid, string userkey, string pagetskey, string varkey, string varvalue)
        {
            bool bret = false;
            if (_dickv.ContainsKey(serverid))
            {
                if (_dickv[serverid].ContainsKey(userkey))
                {
                    if (_dickv[serverid][userkey].ContainsKey(pagetskey))
                    {
                        if (_dickv[serverid][userkey][pagetskey].ContainsKey(varkey))
                        {
                            _dickv[serverid][userkey][pagetskey][varkey] = varvalue;
                            bret = true;
                        }
                    }
                }
            }
            return bret;
        }

        public static bool KVDelete()
        {
            return false;
        }

        public static string KVSelect()
        {
            return "";
        }

    }
}