using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LOYADE.MODEL
{
    public class BHWQ : BPM
    {
        public BHWQ()
        {
            SetFieldLabel();
        }

        public void SetFieldLabel()
        {
            //      
        }


        [
            Category("2 对方当事人信息"),
            DisplayName("[01] 对方当事人"),
            ReadOnly(false),
        ]
        public string target_label
        {
            get
            {
                return base.DicFieldValue["target_label"];
            }
            set
            {
                base.DicFieldValue["target_label"] = value;
            }
        }

        [
            Category("2 对方当事人信息"),
            DisplayName("[02] 当事人电话"),
            ReadOnly(false),
        ]
        public string target_tel
        {
            get
            {
                return base.DicFieldValue["target_tel"];
            }
            set
            {
                base.DicFieldValue["target_tel"] = value;
            }
        }
         

        [
            Category("2 对方当事人信息"),
            DisplayName("[03] 当事人所在地区"),
            ReadOnly(true),
        ]
        public string target_area
        {
            get
            {
                return base.DicFieldValue["t_area_1_label"] + " " + base.DicFieldValue["t_area_2_label"] + " " + base.DicFieldValue["t_area_3_label"];
            }          
        } 
        

        [
           Category("1 保护维权信息"),
           DisplayName("[01] 管辖法院"),
           ReadOnly(false),
        ]
        public string law_label
        {
            get
            {
                return base.DicFieldValue["law_label"];
            }
            set
            {
                base.DicFieldValue["law_label"] = value;
            }
        }

        [
           Category("1 保护维权信息"),
           DisplayName("[02] 案由"),
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
            Category("1 保护维权信息"),
            DisplayName("[02] 业务编号"),
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
            Category("1 保护维权信息"),
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
            Category("1 保护维权信息"),
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
           Category("1 保护维权信息"),
           DisplayName("[06] 立案日"),
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
           Category("1 保护维权信息"),
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
            Category("1 保护维权信息"),
            DisplayName("[08] 案情描述"),
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
