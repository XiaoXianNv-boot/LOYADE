using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LOYADE.MODEL
{
    public class ACCOUNT : BPM
    {
        public ACCOUNT()
        {
            SetFieldLabel();
        }

        public void SetFieldLabel()
        {
            //      
        } 
         

        [
           Category("1 流水基本信息"),
           DisplayName("[01] 名称"),
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
            Category("1 流水基本信息"),
            DisplayName("[02] 支付方式"),
            ReadOnly(false),
        ]
        public string pay_method
        {
            get
            {
                return base.DicFieldValue["pay_method"];
            }
            set
            {
                base.DicFieldValue["pay_method"] = value;
            }
        }

        [
            Category("1 流水基本信息"),
            DisplayName("[03] 是否支付成功 "),
            ReadOnly(false),
        ]
        public string is_paid
        {
            get
            {
                return base.DicFieldValue["is_paid"];
            }
            set
            {
                base.DicFieldValue["is_paid"] = value;
            }
        }

        [
            Category("1 流水基本信息"),
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
           Category("1 流水基本信息"),
           DisplayName("[06] 业务类型"),
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
            Category("1 流水基本信息"),
            DisplayName("[09] 申请日"),
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
            Category("1 流水基本信息"),
            DisplayName("[10] 备注"),
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
