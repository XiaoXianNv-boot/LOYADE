using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Web.Security;
using System.Security.Cryptography;
using System.Management;

namespace LOYADE
{
    public class ActionSecurity
    {
        public ActionSecurity()
        {
        }

        /// <summary>
        /// 生成随机字母字符串(数字字母混和)
        /// </summary>
        /// <param name="codeCount">待生成的位数</param>
        public static string GetCheckCode(int codeCount)
        {
            string str = string.Empty;
            int rep = 0;
            long num2 = DateTime.Now.Ticks + rep;
            rep++;
            Random random = new Random(((int)(((ulong)num2) & 0xffffffffL)) | ((int)(num2 >> rep)));
            for (int i = 0; i < codeCount; i++)
            {
                char ch;
                int num = random.Next();
                if ((num % 2) == 0)
                {
                    ch = (char)(0x30 + ((ushort)(num % 10)));
                }
                else
                {
                    ch = (char)(0x41 + ((ushort)(num % 0x1a)));
                }
                str = str + ch.ToString();
            }
            return str;
        }

        public static bool IsSQLInjected(string str)
        {
            string injection = "[|]|(|)|'|exec|insert|select|delete|update|where|count|*|%|master|truncate|declare|;|=|+|,";
            string[] arr = injection.Split('|');
            for (int i = 0; i < arr.Length; i++)
            {
                if (str.IndexOf(arr[i]) > -1)
                {
                    return true;
                }
            }
            return false;
        }

        #region ========加密========

        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        public static string Encrypt(string text)
        {
            if (text == null)
                return "";
            return Encrypt(text, "LOYADE");
        }

        /// <summary> 
        /// 加密数据 
        /// </summary> 
        /// <param name="Text"></param> 
        /// <param name="sKey"></param> 
        /// <returns></returns> 
        public static string Encrypt(string Text, string sKey)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray;
            inputByteArray = Encoding.Default.GetBytes(Text);
            des.Key = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5").Substring(0, 8));
            des.IV = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5").Substring(0, 8));
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            StringBuilder ret = new StringBuilder();
            foreach (byte b in ms.ToArray())
            {
                ret.AppendFormat("{0:X2}", b);
            }
            return ret.ToString();
        }
        #endregion

        #region ========解密========

        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        public static string Decrypt(string text)
        {
            if (text == null)
                return "";
            return Decrypt(text, "LOYADE");
        }
        /// <summary> 
        /// 解密数据 
        /// </summary> 
        /// <param name="Text"></param> 
        /// <param name="sKey"></param> 
        /// <returns></returns> 
        public static string Decrypt(string Text, string sKey)
        {
            if (Text.Trim() == "")
                return "";
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            int len;
            len = Text.Length / 2;
            byte[] inputByteArray = new byte[len];
            int x, i;
            for (x = 0; x < len; x++)
            {
                i = Convert.ToInt32(Text.Substring(x * 2, 2), 16);
                inputByteArray[x] = (byte)i;
            }
            des.Key = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5").Substring(0, 8));
            des.IV = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5").Substring(0, 8));
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            return Encoding.Default.GetString(ms.ToArray());
        }

        #endregion

        public static bool CheckNumberPostedParameter(string paravalue)
        {
            decimal p;
            return decimal.TryParse(paravalue, out p);
        }

        public static bool CheckStringPostedParameter(string paravalue)
        {
            string sqlkeywords = @"and|or|exec|execute|insert|select|delete|update|alter|create|drop|count|\*|chr|char|asc|mid|substring|master|truncate|declare|xp_cmdshell|restore|backup|net +user|net +localgroup +administrators";
            try
            {
                string str_Regex = @"\b(" + sqlkeywords + @")\b";
                Regex Regex = new Regex(str_Regex, RegexOptions.IgnoreCase);
                if (true == Regex.IsMatch(paravalue))
                    return false;
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static string WebEncrypt(string str, WebEncryptFormat wef)
        {
            if (wef == WebEncryptFormat.MD5)
                return FormsAuthentication.HashPasswordForStoringInConfigFile(str, "MD5");
            else
                return FormsAuthentication.HashPasswordForStoringInConfigFile(str, "SHA1");
        }

        public static string MD5(string str)
        {
            byte[] tmpByte;
            MD5 md5 = new MD5CryptoServiceProvider();
            tmpByte = md5.ComputeHash(GetKeyByteArray(str));
            md5.Clear();
            return GetStringValue(tmpByte, true);
        }

        public string SHA1Encrypt(string str)
        {
            byte[] tmpByte;
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            tmpByte = sha1.ComputeHash(GetKeyByteArray(str));
            sha1.Clear();
            return GetStringValue(tmpByte, true);
        }

        public string SHA256Encrypt(string str)
        {
            byte[] tmpByte;
            SHA256 sha256 = new SHA256Managed();
            tmpByte = sha256.ComputeHash(GetKeyByteArray(str));
            sha256.Clear();
            return GetStringValue(tmpByte, true);
        }

        public string SHA512Encrypt(string str)
        {
            byte[] tmpByte;
            SHA512 sha512 = new SHA512Managed();
            tmpByte = sha512.ComputeHash(GetKeyByteArray(str));
            sha512.Clear();
            return GetStringValue(tmpByte, true);
        }

        private static string GetStringValue(byte[] bytes, bool isreturnnum)
        {
            string tmpString = "";
            if (isreturnnum == false)
            {
                ASCIIEncoding Asc = new ASCIIEncoding();
                tmpString = Asc.GetString(bytes);
            }
            else
            {
                int iCounter;
                for (iCounter = 0; iCounter < bytes.Length; iCounter++)
                {
                    tmpString = tmpString + bytes[iCounter].ToString("X2");
                }
            }
            return tmpString;
        }

        private static byte[] GetKeyByteArray(string str)
        {
            ASCIIEncoding asc = new ASCIIEncoding();
            int tmpStrLen = str.Length;
            byte[] tmpByte = asc.GetBytes(str);
            return tmpByte;
        }


        public static string StrengthenMD5(string pwd)
        {
            string md5 = MD5(pwd);
            string key = "SAKI128LOVELISA076";
            char[] keybyte = key.ToCharArray();
            StringBuilder sb = new StringBuilder();
            char[] md5byte = md5.ToCharArray();
            for (int i = 0; i < md5byte.Length; i++)
            {
                sb.Append(md5byte[i]);
                if (i < 18)
                    sb.Append(keybyte[i]);
            }
            return sb.ToString();
        }

        /// <summary>
        /// 64位密钥加密
        /// </summary>
        /// <param name="data">被加密数据</param>
        /// <param name="key64">是8个字符，64位</param>
        /// <param name="iv64">是8个字符，64位</param>
        /// <returns></returns>
        public static string Encode64(string data, string key64, string iv64)
        {
            byte[] byKey = System.Text.ASCIIEncoding.ASCII.GetBytes(key64);
            byte[] byIV = System.Text.ASCIIEncoding.ASCII.GetBytes(iv64);

            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            int i = cryptoProvider.KeySize;
            MemoryStream ms = new MemoryStream();
            CryptoStream cst = new CryptoStream(ms, cryptoProvider.CreateEncryptor(byKey, byIV), CryptoStreamMode.Write);

            StreamWriter sw = new StreamWriter(cst);
            sw.Write(data);
            sw.Flush();
            cst.FlushFinalBlock();
            sw.Flush();
            return Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length);
        }

        private const string _key64 = "SakiLisa";
        private const string _iv64 = "SakiLisa";

        public static string Encode64(string data)
        {
            byte[] byKey = System.Text.ASCIIEncoding.ASCII.GetBytes(_key64);
            byte[] byIV = System.Text.ASCIIEncoding.ASCII.GetBytes(_iv64);

            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            int i = cryptoProvider.KeySize;
            MemoryStream ms = new MemoryStream();
            CryptoStream cst = new CryptoStream(ms, cryptoProvider.CreateEncryptor(byKey, byIV), CryptoStreamMode.Write);

            StreamWriter sw = new StreamWriter(cst);
            sw.Write(data);
            sw.Flush();
            cst.FlushFinalBlock();
            sw.Flush();
            return Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length);
        }

        /// <summary>
        /// 64位密钥解密
        /// </summary>
        /// <param name="data">被加密数据</param>
        /// <param name="key64">是8个字符，64位</param>
        /// <param name="iv64">是8个字符，64位</param>
        /// <returns></returns>
        public static string Decode64(string data, string key64, string iv64)
        {
            byte[] byKey = System.Text.ASCIIEncoding.ASCII.GetBytes(key64);
            byte[] byIV = System.Text.ASCIIEncoding.ASCII.GetBytes(iv64);

            byte[] byEnc;
            try
            {
                byEnc = Convert.FromBase64String(data);
            }
            catch
            {
                return null;
            }

            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            MemoryStream ms = new MemoryStream(byEnc);
            CryptoStream cst = new CryptoStream(ms, cryptoProvider.CreateDecryptor(byKey, byIV), CryptoStreamMode.Read);
            StreamReader sr = new StreamReader(cst);
            return sr.ReadToEnd();
        }

        public static string Decode64(string data)
        {
            byte[] byKey = System.Text.ASCIIEncoding.ASCII.GetBytes(_key64);
            byte[] byIV = System.Text.ASCIIEncoding.ASCII.GetBytes(_iv64);

            byte[] byEnc;
            try
            {
                byEnc = Convert.FromBase64String(data);
            }
            catch
            {
                return null;
            }

            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            MemoryStream ms = new MemoryStream(byEnc);
            CryptoStream cst = new CryptoStream(ms, cryptoProvider.CreateDecryptor(byKey, byIV), CryptoStreamMode.Read);
            StreamReader sr = new StreamReader(cst);
            return sr.ReadToEnd();
        }

        /// <summary> 
        /// 获取网卡硬件地址 
        /// </summary> 
        /// <returns>string</returns> 
        public static string GetMoAddress()
        {
            string MoAddress = "";
            try
            {
                using (ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration"))
                {
                    ManagementObjectCollection moc2 = mc.GetInstances();
                    foreach (ManagementObject mo in moc2)
                    {
                        if ((bool)mo["IPEnabled"] == true)
                            MoAddress = mo["MacAddress"].ToString();
                        mo.Dispose();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return MoAddress.ToString();
        }

        /// <summary>
        /// 取得设备硬盘的卷标号
        /// </summary>
        /// <returns>string</returns>
        public static string GetDiskVolumeSerialNumber()
        {
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObject disk = new ManagementObject("win32_logicaldisk.deviceid=\"c:\"");
            disk.Get();
            return disk.GetPropertyValue("VolumeSerialNumber").ToString();
        }

        /// <summary>
        /// 获得CPU的序列号
        /// </summary>
        /// <returns>string</returns>
        public static string GetCPUCode()
        {
            string strCpu = null;
            ManagementClass myCpu = new ManagementClass("win32_Processor");
            ManagementObjectCollection myCpuConnection = myCpu.GetInstances();
            foreach (ManagementObject myObject in myCpuConnection)
            {
                strCpu = myObject.Properties["Processorid"].Value.ToString();
                break;
            }
            return strCpu;
        }

        /// <summary>
        /// 生成机器码
        /// </summary>
        /// <returns>string</returns>
        public static string GetMachineNumber()
        {
            string strNum = GetCPUCode() + GetDiskVolumeSerialNumber() + GetMoAddress();
            return Encrypt(strNum);
        }

        private static int[] _keycode = new int[127];//存储密钥
        private static int[] _ascnumber = new int[25];//存机器码的Ascii值
        private static char[] _charcode = new char[25];//存储机器码字
        public static void SetKeyCode()//给数组赋值小于10的数
        {
            for (int i = 1; i < _keycode.Length; i++)
            {
                _keycode[i] = i % 9;
            }
        }

        /// <summary>
        /// 生成注册码
        /// </summary>
        /// <returns></returns>
        public static string GetRegisterNumber()
        {
            SetKeyCode();//初始化127位数组
            string MNum = GetMachineNumber();//获取注册码
            for (int i = 1; i < _charcode.Length; i++)//把机器码存入数组中
            {
                _charcode[i] = Convert.ToChar(MNum.Substring(i - 1, 1));
            }
            for (int j = 1; j < _ascnumber.Length; j++)//把字符的ASCII值存入一个整数组中。
            {
                _ascnumber[j] = _keycode[Convert.ToInt32(_charcode[j])] + Convert.ToInt32(_charcode[j]);
            }
            string strAsciiName = "";//用于存储注册码
            for (int j = 1; j < _ascnumber.Length; j++)
            {
                if (_ascnumber[j] >= 48 && _ascnumber[j] <= 57)//判断字符ASCII值是否0－9之间
                {
                    strAsciiName += Convert.ToChar(_ascnumber[j]).ToString();
                }
                else if (_ascnumber[j] >= 65 && _ascnumber[j] <= 90)//判断字符ASCII值是否A－Z之间
                {
                    strAsciiName += Convert.ToChar(_ascnumber[j]).ToString();
                }
                else if (_ascnumber[j] >= 97 && _ascnumber[j] <= 122)//判断字符ASCII值是否a－z之间
                {
                    strAsciiName += Convert.ToChar(_ascnumber[j]).ToString();
                }
                else//判断字符ASCII值不在以上范围内
                {
                    if (_ascnumber[j] > 122)//判断字符ASCII值是否大于z
                    {
                        strAsciiName += Convert.ToChar(_ascnumber[j] - 10).ToString();
                    }
                    else
                    {
                        strAsciiName += Convert.ToChar(_ascnumber[j] - 9).ToString();
                    }
                }
            }
            return strAsciiName;//返回注册码
        }
    }
}
