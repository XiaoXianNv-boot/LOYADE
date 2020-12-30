using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LOYADE.MODEL
{
    public class SBZC : BPM
    {
        public SBZC()
        {
            SetFieldLabel();
        }

        public void SetFieldLabel()
        {
            //      
        }

      

        [
           Category("1 商标基本信息"),
           DisplayName("[01] 商标名称"),
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
            Category("1 商标基本信息"),
            DisplayName("[02] 商标号"),
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
            Category("1 商标基本信息"),
            DisplayName("[03] 委托人"),
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
            Category("1 商标基本信息"),
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
           Category("1 商标基本信息"),
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
           Category("1 商标基本信息"),
           DisplayName("[07] 业务类型"),
           ReadOnly(true),
        ]
        public string bpm_label
        {
            get
            {
                return base.DicFieldValue["bpm_label"];
            }
            set
            {
                base.DicFieldValue["bpm_label"] = value;
            }
        }

        [
            Category("1 商标基本信息"),
            DisplayName("[08] 商标描述"),
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
