using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;

namespace LOYADE.DATA.REALTIME
{
    public class MemoryMappingDATA
    {
        public ConcurrentDictionary<string, string> CurrentData;

        public MemoryMappingDATA()
        {
            CurrentData = new ConcurrentDictionary<string, string>();
        }

        public string GetVaraibleValue(string key)
        {
            if (CurrentData.ContainsKey(key))
                return CurrentData[key];
            else
                return "NULL";
        }

        public void SetVaraibleValue(string key, string value)
        {
            if (CurrentData.ContainsKey(key))
                CurrentData[key] = value;
            else
                CurrentData.TryAdd(key, value);
        }
    }
}
