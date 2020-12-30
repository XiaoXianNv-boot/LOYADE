using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LOYADE.MODEL
{
    public class ZHFW : BPM
    {
        public ZHFW()
        {
            SetFieldLabel();
        }

        public void SetFieldLabel()
        {
            //      
        } 


        [
           Category("1 综合服务基本信息"),
           DisplayName("[1] 综合服务名称"),
           ReadOnly(false),
        ]
        public string label
        {
            get
            {
                return base.DicFieldValue["label"];
            }
            set
            {
                base.DicFieldValue["label"] = value;
            }
        }

        [
            Category("1 综合服务基本信息"),
            DisplayName("[2] 综合服务号"),
            ReadOnly(false),
        ]
        public string certificate_sn
        {
            get
            {
                return base.DicFieldValue["certificate_sn"];
            }
            set
            {
                base.DicFieldValue["certificate_sn"] = value;
            }
        }

        [
            Category("1 综合服务基本信息"),
            DisplayName("[3] 委托人"),
            ReadOnly(false),
        ]
        public string delegate_label
        {
            get
            {
                return base.DicFieldValue["delegate_label"];
            }
            set
            {
                base.DicFieldValue["delegate_label"] = value;
            }
        }

        [
            Category("1 综合服务基本信息"),
            DisplayName("[04] 身份证/信用代码"),
            ReadOnly(false),
        ]
        public string delegate_msn
        {
            get
            {
                return base.DicFieldValue["delegate_msn"];
            }
            set
            {
                base.DicFieldValue["delegate_msn"] = value;
            }
        }

        [
            Category("1 综合服务基本信息"),
            DisplayName("[05] 业务标题"),
            ReadOnly(false),
        ]
        public string title
        {
            get
            {
                return base.DicFieldValue["title"];
            }
            set
            {
                base.DicFieldValue["title"] = value;
            }
        }


        [
           Category("1 综合服务基本信息"),
           DisplayName("[06] 申请日"),
           ReadOnly(false),
        ]
        public DateTime apply_dt
        {
            get
            {
                DateTime dt;
                DateTime.TryParse(base.DicFieldValue["apply_dt"], out dt);
                return dt;
            }
            set
            {
                base.DicFieldValue["apply_dt"] = value.ToString();
            }
        }
 
        [
            Category("1 综合服务基本信息"),
            DisplayName("[08] 综合服务描述"),
            ReadOnly(false),
        ]
        public string more_info
        {
            get
            {
                return base.DicFieldValue["more_info"];
            }
            set
            {
                base.DicFieldValue["more_info"] = value;
            }
        } 
    }
}
