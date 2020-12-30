using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LOYADE.MODEL
{
    public class BQDJ : BPM
    {
        public BQDJ()
        {
            SetFieldLabel();
        }

        public void SetFieldLabel()
        {
            //      
        }
       
        [
           Category("1 版权信息"),
           DisplayName("[01] 作品名称"),
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
           Category("1 版权信息"),
           DisplayName("[02] 版权号"),
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
            Category("1 版权信息"),
            DisplayName("[03] 著作权人"),
            ReadOnly(false),
        ]
        public string property_label
        {
            get
            {
                return base.DicFieldValue["property_label"];
            }
            set
            {
                base.DicFieldValue["property_label"] = value;
            }
        }

        [
            Category("1 版权信息"),
            DisplayName("[04] 作者"),
            ReadOnly(false),
        ]
        public string authors
        {
            get
            {
                return base.DicFieldValue["authors"];
            }
            set
            {
                base.DicFieldValue["authors"] = value;
            }
        }

        [
            Category("1 版权信息"),
            DisplayName("[05] 委托人"),
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
            Category("1 版权信息"),
            DisplayName("[06] 身份证/信用代码"),
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
           Category("1 版权信息"),
           DisplayName("[08] 申请日"),
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
           Category("1 版权信息"),
           DisplayName("[09] 业务类型"),
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
            Category("1 版权信息"),
            DisplayName("[10] 创作完成日期"),
            ReadOnly(false),
        ]
        public string finish_dt
        {
            get
            {
                return base.DicFieldValue["finish_dt"];
            }
            set
            {
                base.DicFieldValue["finish_dt"] = value;
            }
        }

        [
            Category("1 版权信息"),
            DisplayName("[11] 版权描述"),
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
