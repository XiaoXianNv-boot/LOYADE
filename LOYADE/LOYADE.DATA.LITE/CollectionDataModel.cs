using System;
using System.Collections.Generic;
using System.Text;

namespace LOYADE.DATA.LITE
{
    public class CollectionDataModel
    {
        private Dictionary<string, ObjectDataModel> _dic;

        public Dictionary<string, ObjectDataModel> Dic
        {
            get { return _dic; }
            set { _dic = value; }
        }

        private List<ObjectDataModel> _list;

        public List<ObjectDataModel> List
        {
            get { return _list; }
            set { _list = value; }
        }

        public string DataCollectionName { get; set; }

        public CollectionDataModel(string name)
        {
            DataCollectionName = name;
            _list = new List<ObjectDataModel>();
            _dic = new Dictionary<string, ObjectDataModel>();
        }

        public ObjectDataModel this[int index]
        {
            get
            {
                if (_list.Count > index && index > -1)
                {
                    return _list[index];
                }
                else
                    return null;
            }
            set
            {
                if (_list.Count > index && index > -1)
                {
                    _list[index] = value;
                }
            }
        }

        public ObjectDataModel this[string key]
        {
            get
            {
                if (_dic.ContainsKey(key))
                {
                    return _dic[key];
                }
                else
                    return null;
            }
            set
            {
                if (_dic.ContainsKey(key))
                {
                    _dic[key] = value;
                }
            }
        }

        public bool AddDataModel(ObjectDataModel value)
        {
            if (_dic.ContainsKey(value.FieldName))
            {
                return false;
            }
            else
            {
                _list.Add(value);
                _dic.Add(value.FieldName, value);
                return true;
            }
        }

        public bool RemoveDataModel(string key)
        {
            if (_dic.ContainsKey(key))
            {
                _list.Remove(_dic[key]);
                _dic.Remove(key);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveDataModel(int index)
        {
            if (_list.Count > index && index > -1)
            {
                _dic.Remove(_list[index].FieldName);
                _list.RemoveAt(index);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
