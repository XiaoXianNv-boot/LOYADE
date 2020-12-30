using System;

namespace LOYADE
{
    public class ObjectPair
    {
        public string Key { get; set; }
        public object Value { get; set; }
        public object Tag { get; set; }

        public ObjectPair()
        {
        }

        public ObjectPair(string key)
        {
            this.Key = key;
        }

        public ObjectPair(string key, object value)
        {
            this.Key = key;
            this.Value = value;
        }

        public ObjectPair(string key, object value, object tag)
        {
            this.Key = key;
            this.Value = value;
            this.Tag = tag;
        }

        public override string ToString()
        {
            return this.Key;
        }
    }
}
