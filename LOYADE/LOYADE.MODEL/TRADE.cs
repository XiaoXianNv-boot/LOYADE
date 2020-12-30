using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LOYADE.MODEL
{
    public class TRADE : BPM
    {
        public TRADE()
        {
            SetFieldLabel();
        }

        public void SetFieldLabel()
        {
            //      
        }

        [
            Category("2 联系人信息"),
            DisplayName("[01] 联系人"),
            ReadOnly(true),
        ]
        public string contact_label
        {
            get
            {
                return base.DicFieldValue["contact_label"];
            }
            set
            {
                base.DicFieldValue["contact_label"] = value;
            }
        }

        [
            Category("2 联系人信息"),
            DisplayName("[02] 联系方式"),
            ReadOnly(true),
        ]
        public string tel
        {
            get
            {
                return base.DicFieldValue["tel"];
            }
            set
            {
                base.DicFieldValue["tel"] = value;
            }
        }

        [
            Category("2 联系人信息"),
            DisplayName("[03] 电子邮箱"),
            ReadOnly(true),
        ]
        public string email
        {
            get
            {
                return base.DicFieldValue["email"];
            }
            set
            {
                base.DicFieldValue["email"] = value;
            }
        }

        [
            Category("2 联系人信息"),
            DisplayName("[04] 所在地区"),
            ReadOnly(true),
        ]
        public string area
        {
            get
            {
                return base.DicFieldValue["area_1_label"] + " " + base.DicFieldValue["area_2_label"] + " " + base.DicFieldValue["area_3_label"];
            }
        }

        [
            Category("2 联系人信息"),
            DisplayName("[05] 联系地址"),
            ReadOnly(true),
        ]
        public string address
        {
            get
            {
                return base.DicFieldValue["address"];
            }
            set
            {
                base.DicFieldValue["address"] = value;
            }
        } 



        [
           Category("1 交易基本信息"),
           DisplayName("[1] 交易名称"),
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
            Category("1 交易基本信息"),
            DisplayName("[2] 交易号"),
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
            Category("1 交易基本信息"),
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
           Category("1 交易基本信息"),
           DisplayName("[4] 所需费用"),
           ReadOnly(true),
        ]
        public string price
        {
            get
            {
                return base.DicFieldValue["price"];
            }
            set
            {
                base.DicFieldValue["price"] = value;
            }
        }


        [
           Category("1 交易基本信息"),
           DisplayName("[6] 业务类型"),
           ReadOnly(false),
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
           Category("1 交易基本信息"),
           DisplayName("[7] 发布日"),
           ReadOnly(true),
        ]
        public string apply_dt
        {
            get
            {
                return base.DicFieldValue["apply_dt"];
            }
            set
            {
                base.DicFieldValue["apply_dt"] = value;
            }
        }

        [
            Category("1 交易基本信息"),
            DisplayName("[8] 交易描述"),
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
