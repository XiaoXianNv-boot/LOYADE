using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LOYADE
{
    public class ActionVerify
    {
        public ActionVerify()
        {
        }

        public static bool IsContentString(string value)
        {
            if (value == null)
                return false;
            else if (value.Trim() == "")
                return false;
            return true;
        }

        public static bool IsIntString(string value)
        {
            int temp;
            return int.TryParse(value, out temp);
        }

        public static bool IsPositiveNumberString(string value)
        {
            int temp;
            if (int.TryParse(value, out temp))
            {
                if (temp > 0)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public static bool IsDecimalString(string value)
        {
            decimal temp;
            return decimal.TryParse(value, out temp);
        }

    }
}
