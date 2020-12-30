using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
using System.Web;

namespace LOYADE
{
    public class ActionWeb
    {
        protected static string cookieHeader;

        #region 检查是否为IP地址
        /// <summary>
        /// 是否为ip
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        public static bool IsIP(string ip)
        {
            return Regex.IsMatch(ip, @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)$");
        }
        #endregion


        /// <summary>
        /// 返回指定的服务器变量信息
        /// </summary>
        /// <param name="strName">服务器变量名</param>
        /// <returns>服务器变量信息</returns>
        public static string GetServerString(string strName)
        {
            if (HttpContext.Current.Request.ServerVariables[strName] == null)
                return "";

            return HttpContext.Current.Request.ServerVariables[strName].ToString();
        }
 

        /// <summary>
        /// 获得当前页面客户端的IP
        /// </summary>
        /// <returns>当前页面客户端的IP</returns>
        public static string GetIP()
        {
            string result = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];  
            if (string.IsNullOrEmpty(result))
                result = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            if (string.IsNullOrEmpty(result))
                result = HttpContext.Current.Request.UserHostAddress;
            if (string.IsNullOrEmpty(result) || !IsIP(result))
                return "127.0.0.1";
            return result;
        }

        /**/
        /// <summary>
        /// 功能描述：模拟登录页面，提交登录数据进行登录，并记录Header中的cookie
        /// </summary>
        /// <param name="strURL">登录数据提交的页面地址</param>
        /// <param name="strArgs">用户登录数据</param>
        /// <param name="strReferer">引用地址</param>
        /// <returns>可以返回页面内容或不返回</returns>
        public static string PostLogin(string strURL, string strArgs, string strReferer, string encoding)
        {
            string strResult = "";
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(strURL);
            myHttpWebRequest.AllowAutoRedirect = true;
            myHttpWebRequest.KeepAlive = true;
            myHttpWebRequest.Accept = "image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/vnd.ms-excel, application/msword, application/x-shockwave-flash, */*";
            myHttpWebRequest.Referer = strReferer;

            myHttpWebRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; Maxthon; .NET CLR 2.0.50727)";
            myHttpWebRequest.ContentType = "application/x-www-form-urlencoded";
            myHttpWebRequest.Method = "POST";

            CookieCollection myCookies = null;
            CookieContainer myCookieContainer = new CookieContainer();
            myHttpWebRequest.CookieContainer = myCookieContainer;

            Stream MyRequestStrearm = myHttpWebRequest.GetRequestStream();
            StreamWriter MyStreamWriter = new StreamWriter(MyRequestStrearm, Encoding.ASCII);
            //把数据写入HttpWebRequest的Request流
            MyStreamWriter.Write(strArgs);
            //关闭打开对象 
            MyStreamWriter.Close();
            MyRequestStrearm.Close();

            HttpWebResponse response = null;
            System.IO.StreamReader sr = null;
            response = (HttpWebResponse)myHttpWebRequest.GetResponse();

            cookieHeader = myHttpWebRequest.CookieContainer.GetCookieHeader(new Uri(strURL));
            HttpContext.Current.Application.Lock();
            HttpContext.Current.Application["cookieHeader"] = cookieHeader;
            HttpContext.Current.Application.UnLock();
            myCookies = response.Cookies;

            sr = new System.IO.StreamReader(response.GetResponseStream(), Encoding.GetEncoding(encoding));
            strResult = sr.ReadToEnd();
            return strResult;
        }

        /**/
        /// <summary>
        /// 功能描述：在PostLogin成功登录后记录下Headers中的cookie，然后获取此网站上其他页面的内容
        /// </summary>
        /// <param name="strURL">获取网站的某页面的地址</param>
        /// <param name="strReferer">引用的地址</param>
        ///  <param name="encoding">编码方式（utf-8，gb2312等）</param>
        /// <returns>返回页面内容</returns>
        public static string GetPageAfterLogin(string strURL, string strReferer, string encoding)
        {
            string strResult = "";
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(strURL);
            myHttpWebRequest.ContentType = "text/html";
            myHttpWebRequest.Method = "GET";
            myHttpWebRequest.Referer = strReferer;
            myHttpWebRequest.Headers.Add("cookie:" + cookieHeader);

            HttpWebResponse response = null;
            System.IO.StreamReader sr = null;
            response = (HttpWebResponse)myHttpWebRequest.GetResponse();
            sr = new System.IO.StreamReader(response.GetResponseStream(), Encoding.GetEncoding(encoding));
            strResult = sr.ReadToEnd();
            return strResult;
        }

        public static string GetPageAfterLoginWithPost(string strURL, string strArgs, string strReferer, string encoding)
        {
            string strResult = "";
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(strURL);
            myHttpWebRequest.ContentType = "text/html";
            myHttpWebRequest.Method = "POST";
            myHttpWebRequest.Referer = strReferer;
            myHttpWebRequest.Headers.Add("cookie:" + cookieHeader);

            Stream MyRequestStrearm = myHttpWebRequest.GetRequestStream();
            StreamWriter MyStreamWriter = new StreamWriter(MyRequestStrearm, Encoding.ASCII);
            //把数据写入HttpWebRequest的Request流
            MyStreamWriter.Write(strArgs);
            //关闭打开对象 
            MyStreamWriter.Close();
            MyRequestStrearm.Close();

            HttpWebResponse response = null;
            System.IO.StreamReader sr = null;
            response = (HttpWebResponse)myHttpWebRequest.GetResponse();
            sr = new System.IO.StreamReader(response.GetResponseStream(), Encoding.GetEncoding(encoding));
            strResult = sr.ReadToEnd();
            return strResult;
        }
    }
}
