using System;
using System.Collections.Generic;
using System.Text;

namespace LOYADE.BPM
{
    public class ActionSNManager
    {
        private static ActionSNManager _snm;

        protected ActionSNManager()
        {

        }

        public static ActionSNManager GetInstance()
        {
            if (_snm == null)
            {
                _snm = new ActionSNManager();
            }
            return _snm;
        }

        /// <summary>
        /// 生成新的业务编号
        /// </summary>
        /// <param name="prefix">3位前缀</param>
        /// <param name="currentmaxsn">当前最大编号</param>
        /// <param name="numbercount">流水号位数，即X值</param>
        /// <returns></returns>
        public static string GenerateNewSN_3_8_X(string prefix, string currentmaxsn, int numbercount)
        {
            string newsn = "";
            string zero = "";
            for (int i = 0; i < numbercount - 1; i++)
                zero += "0";
            string datestring = DateTime.Now.ToString("yyyyMMdd");
            if (currentmaxsn == "" || int.Parse(currentmaxsn.Substring(3, 8)) < int.Parse(datestring))
            {
                newsn = prefix + datestring + zero + "1";
            }
            else
            {
                long sn = Convert.ToInt64(currentmaxsn) + 1;
                newsn = sn.ToString();
            }
            return newsn;
        }
 
    }
}
