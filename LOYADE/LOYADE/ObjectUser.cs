using System;
using System.Collections.Generic;

namespace LOYADE
{
    public class ObjectUser
    {
        protected Dictionary<string, string> _properties = new Dictionary<string, string>();

        public Dictionary<string, string> Properties
        {
            get { return _properties; }
        }

        public ObjectUser()
        {
        }

        public string this[string key]
        {
            get { return _properties[key]; }
            set { _properties[key] = value; }
        }

        public void UpdateProperty(string key, string value)
        {
            if (_properties.ContainsKey(key))
                _properties[key] = value;
            else
                _properties.Add(key, value);
        }

        public void ClearProperty(string key)
        {
            _properties.Remove(key);
        }

        public void ClearAllProperties()
        {
            _properties.Clear();
        }


    }
}
