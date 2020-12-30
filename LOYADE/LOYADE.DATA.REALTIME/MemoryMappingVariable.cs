using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;

namespace LOYADE.DATA.REALTIME
{
    public class MemoryMappingVariable
    {
        private string _devicesn = "";

        public string DeviceSN
        {
            get
            {
                return _devicesn;
            }

            set
            {
                _devicesn = value;
            }
        }

        /// <summary>
        /// 并发字典：一个变量ID对应一个变量值对象队列
        /// </summary>
        public ConcurrentDictionary<string, ConcurrentQueue<VariableValue>> CurrentVariables;

        
        public MemoryMappingVariable()
        {
            CurrentVariables = new ConcurrentDictionary<string, ConcurrentQueue<VariableValue>>();
        }

        public MemoryMappingVariable(string devicesn)
        {
            _devicesn = devicesn;
            CurrentVariables = new ConcurrentDictionary<string, ConcurrentQueue<VariableValue>>();
        }

        /// <summary>
        /// 直接出队取变量值对象
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public VariableValue GetVaraibleValue(string key)
        {
            VariableValue vv = null;
            if (CurrentVariables.ContainsKey(key))
            {
                CurrentVariables[key].TryDequeue(out vv);
            }
            return vv;
        }

        /// <summary>
        /// 测试型取队列顶部变量值对象，一般需要配合 RemovePeekVaraibleValue 异步完成一次出队
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public VariableValue GetVaraibleValueByTest(string key)
        {
            VariableValue vv = null;
            if (CurrentVariables.ContainsKey(key))
            {
                CurrentVariables[key].TryPeek(out vv);
            }
            return vv;
        }

        public void RemovePeekVaraibleValue(string key)
        {
            VariableValue vv = null;
            if (CurrentVariables.ContainsKey(key))
            {
                CurrentVariables[key].TryDequeue(out vv);
            } 
        }

        /// <summary>
        /// 新变量值对象入队
        /// </summary>
        /// <param name="key"></param>
        /// <param name="vv"></param>
        public void SetVaraibleValue(string key, VariableValue vv)
        {
            if (CurrentVariables.ContainsKey(key))
                CurrentVariables[key].Enqueue(vv);
            else
            {
                ConcurrentQueue<VariableValue> cq = new ConcurrentQueue<VariableValue>();
                cq.Enqueue(vv);
                CurrentVariables.TryAdd(key, cq);
            }
        }
    }
}
