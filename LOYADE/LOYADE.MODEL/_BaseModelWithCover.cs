using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LOYADE.MODEL
{
    public class _BaseModelWithCover : _BaseModel
    {
        public _BaseModelWithCover()
        {
        }

        protected string _object_type = "";

        [
            Category("只读"),
            DisplayName("类型"),
            Browsable(false),
            ReadOnly(true),
        ]
        public string object_type
        {
            get
            {
                return _object_type;
            }
            set
            {
                _object_type = value;
            }
        }

        [
            Category("只读"),
            DisplayName("裁剪头像X"),
            ReadOnly(true),
        ]
        public string head_cut_x
        {
            get
            {
                return base.DicFieldValue["head_cut_x"];
            }
            set
            {
                base.DicFieldValue["head_cut_x"] = value;
            }
        }

        [
            Category("只读"),
            DisplayName("裁剪头像Y"),
            ReadOnly(true),
        ]
        public string head_cut_y
        {
            get
            {
                return base.DicFieldValue["head_cut_y"];
            }
            set
            {
                base.DicFieldValue["head_cut_y"] = value;
            }
        }
    }
}
