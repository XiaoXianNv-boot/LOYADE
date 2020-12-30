using System;
using System.Collections.Generic;
using System.Text;

namespace LOYADE.VEHICLE
{
    public class VIN
    {
        protected VIN()
        {
        }

        protected static VIN _vin;

        public static VIN GetInstance()
        {
            if (_vin == null)
            {
                _vin = new VIN();
                _vin.InitializeData();
            }
            return _vin;
        }

        public bool CheckVIN(string vin)
        {
            bool bret = false;
            if (vin.IndexOf("O") > -1 || vin.IndexOf("o") > -1 || vin.IndexOf("I") > -1 || vin.IndexOf("i") > -1 || vin.IndexOf("Q") > -1 || vin.IndexOf("q") > -1)
                return false;
            if (vin.Length == 17)
            {
                int valid;
                if (int.TryParse(vin.Substring(8, 1), out valid))
                {
                    if (valid == CalculateValidatingCode(vin))
                        bret = true;
                }
            }
            return bret;
        }

        public int CalculateValidatingCode(string vin)
        {
            int iret = -1;
            if (vin.Length == 17)
            {
                vin = vin.ToLower();
                char[] cs = vin.ToCharArray();

                int total = 0;
                char code;
                for (int i = 1; i < 18; i++)
                {
                    if (i == 9)
                        continue;
                    code = cs[i - 1];
                    if (_kv.ContainsKey(code))
                    {
                        total += _kv[code] * _wv[i];
                    }
                    else
                    {
                        return -1;
                    }
                }
                iret = total % 11;
            }
            return iret;
        }

        public int CalculateValidatingCode(string left8, string right8)
        {
            int iret = -1;
            if (left8.Length == 8 && right8.Length == 8)
            {
                left8 = left8.ToLower();
                right8 = right8.ToLower();
                char[] left8cs = left8.ToCharArray();
                char[] right8cs = right8.ToCharArray();

                int total = 0;
                char code;
                for (int i = 1; i < 9; i++)
                {
                    code = left8cs[i - 1];
                    if (_kv.ContainsKey(code))
                    {
                        total += _kv[code] * _wv[i];
                    }
                    else
                    {
                        return -1;
                    }
                }
                for (int i = 10; i < 18; i++)
                {
                    code = right8[i - 10];
                    if (_kv.ContainsKey(code))
                    {
                        total += _kv[code] * _wv[i];
                    }
                    else
                    {
                        return -1;
                    }
                }
                iret = total % 11;
            }
            return iret;
        }

        private Dictionary<char, int> _kv = new Dictionary<char, int>();

        private Dictionary<int, int> _wv = new Dictionary<int, int>();

        private void InitializeData()
        {
            for (int i = 0; i < 10; i++)
            {
                _kv.Add(i.ToString().ToCharArray()[0], i);
            }

            _kv.Add('a', 1);
            _kv.Add('b', 2);
            _kv.Add('c', 3);
            _kv.Add('d', 4);
            _kv.Add('e', 5);
            _kv.Add('f', 6);
            _kv.Add('g', 7);
            _kv.Add('h', 8);
            _kv.Add('j', 1);
            _kv.Add('k', 2);
            _kv.Add('l', 3);
            _kv.Add('m', 4);
            _kv.Add('n', 5);
            _kv.Add('p', 7);
            _kv.Add('q', 8);
            _kv.Add('r', 9);
            _kv.Add('s', 2);
            _kv.Add('t', 3);
            _kv.Add('u', 4);
            _kv.Add('v', 5);
            _kv.Add('w', 6);
            _kv.Add('x', 7);
            _kv.Add('y', 8);
            _kv.Add('z', 9);

            _wv.Add(1, 8);
            _wv.Add(2, 7);
            _wv.Add(3, 6);
            _wv.Add(4, 5);
            _wv.Add(5, 4);
            _wv.Add(6, 3);
            _wv.Add(7, 2);
            _wv.Add(8, 10);
            _wv.Add(10, 9);
            _wv.Add(11, 8);
            _wv.Add(12, 7);
            _wv.Add(13, 6);
            _wv.Add(14, 5);
            _wv.Add(15, 4);
            _wv.Add(16, 3);
            _wv.Add(17, 2);

        }
    }
}
