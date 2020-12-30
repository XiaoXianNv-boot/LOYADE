using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LOYADE.MODEL
{
    public class _BaseModel
    {
        public _BaseModel()
        {
        }
 
        public Dictionary<string, string> DicFieldValue = new Dictionary<string, string>();

        [
            Category("只读"),
            DisplayName("系统ID"),
            ReadOnly(true),
        ]
        public string id
        {
            get
            {
                return DicFieldValue["id"];
            }
            set
            {
                DicFieldValue["id"] = value;
            }
        }

        [
            Category("只读"),
            DisplayName("当前对象版本系统ID"),
            BrowsableAttribute(false),
            ReadOnly(true),
        ]
        public string version_id
        {
            get
            {
                return DicFieldValue["version_id"];
            }
            set
            {
                DicFieldValue["version_id"] = value;
            }
        }         
    }
}
