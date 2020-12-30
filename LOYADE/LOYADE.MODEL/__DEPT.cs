using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LOYADE.MODEL
{
    public class __DEPT : _BaseModelWithCover
    {
        public __DEPT()
        {
            base._object_type = "dept";
            SetFieldLabel();
        }

        public void SetFieldLabel()
        {
            //      
        }

        [
            Category("2 联系人信息"),
            DisplayName("[01] 联系人"),
            ReadOnly(false),
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
            DisplayName("[02] 联系手机"),
            ReadOnly(false),
        ]
        public string mobile
        {
            get
            {
                return base.DicFieldValue["mobile"];
            }
            set
            {
                base.DicFieldValue["mobile"] = value;
            }
        }

        [
            Category("2 联系人信息"),
            DisplayName("[03] 电子邮箱"),
            ReadOnly(false),
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
           Category("只读"),
           DisplayName("进驻审核是否通过"),
           ReadOnly(true),
           Browsable(true)
        ]
        public string is_checked
        {
            get
            {
                return base.DicFieldValue["is_checked"];
            }
            set
            {
                base.DicFieldValue["is_checked"] = value;
            }
        }

        [
           Category("只读"),
           DisplayName("进驻审核时间"),
           ReadOnly(true),
           Browsable(true)
        ]
        public string check_dt
        {
            get
            {
                return base.DicFieldValue["check_dt"];
            }
            set
            {
                base.DicFieldValue["check_dt"] = value;
            }
        }

        [
           Category("只读"),
           DisplayName("进驻审核意见"),
           ReadOnly(true),
           Browsable(true)
        ]
        public string check_info
        {
            get
            {
                return base.DicFieldValue["check_info"];
            }
            set
            {
                base.DicFieldValue["check_info"] = value;
            }
        }

        [
           Category("只读"),
           DisplayName("所在国家ID"),
           ReadOnly(true),
           Browsable(false)
        ]
        public string area_1_id
        {
            get
            {
                return base.DicFieldValue["area_1_id"];
            }
            set
            {
                base.DicFieldValue["area_1_id"] = value;
            }
        }

        [
            Category("只读"),
            DisplayName("所在省份ID"),
            ReadOnly(true),
            Browsable(false)
        ]
        public string area_2_id
        {
            get
            {
                return base.DicFieldValue["area_2_id"];
            }
            set
            {
                base.DicFieldValue["area_2_id"] = value;
            }
        }

        [
            Category("只读"),
            DisplayName("所在城市ID"),
            ReadOnly(true),
            Browsable(false)
        ]
        public string area_3_id
        {
            get
            {
                return base.DicFieldValue["area_3_id"];
            }
            set
            {
                base.DicFieldValue["area_3_id"] = value;
            }
        }


        [
            Category("2 联系人信息"),
            DisplayName("[05] 详细地址"),
            ReadOnly(false),
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
           Category("1 机构基本信息"),
           DisplayName("[00] 登录用户名"),
           ReadOnly(true),
        ]
        public string sn
        {
            get
            {
                return base.DicFieldValue["sn"];
            }
            set
            {
                base.DicFieldValue["sn"] = value;
            }
        }

        [
           Category("1 机构基本信息"),
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
            Category("1 机构基本信息"),
            DisplayName("[02] 统一信用代码"),
            ReadOnly(false),
        ]
        public string msn
        {
            get
            {
                return base.DicFieldValue["msn"];
            }
            set
            {
                base.DicFieldValue["msn"] = value;
            }
        }

        [
            Category("1 机构基本信息"),
            DisplayName("[03] 资质证书编号"),
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
            Category("1 机构基本信息"),
            DisplayName("[04] 开户银行"),
            ReadOnly(false),
        ]
        public string bank
        {
            get
            {
                return base.DicFieldValue["bank"];
            }
            set
            {
                base.DicFieldValue["bank"] = value;
            }
        }

        [
            Category("1 机构基本信息"),
            DisplayName("[05] 银行账号"),
            ReadOnly(false),
        ]
        public string bank_sn
        {
            get
            {
                return base.DicFieldValue["bank_sn"];
            }
            set
            {
                base.DicFieldValue["bank_sn"] = value;
            }
        }

        [
            Category("1 机构基本信息"),
            DisplayName("[06] 机构描述"),
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

        [
            Category("1 机构基本信息"),
            DisplayName("[07] 办公电话"),
            ReadOnly(false),
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
            Category("只读"),
            DisplayName("机构注册时间"),
            ReadOnly(true),
        ]
        public string create_dt
        {
            get
            {
                return base.DicFieldValue["create_dt"];
            }
            set
            {
                base.DicFieldValue["create_dt"] = value;
            }
        }

        [
            Category("只读"),
            DisplayName("进驻申请时间"),
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
            Category("只读"),
            DisplayName("机构类型"),
            ReadOnly(true),
        ]
        public string type_label
        {
            get
            {
                return base.DicFieldValue["type_label"];
            }
            set
            {
                base.DicFieldValue["type_label"] = value;
            }
        }

        [
            Category("只读"),
            DisplayName("账户余额"),
            ReadOnly(true),
        ]
        public string amount
        {
            get
            {
                return base.DicFieldValue["amount"];
            }
            set
            {
                base.DicFieldValue["amount"] = value;
            }
        }

        [
            Category("只读"),
            DisplayName("默认业务分成"),
            ReadOnly(true),
        ]
        public string profit_ratio
        {
            get
            {
                return base.DicFieldValue["profit_ratio"];
            }
            set
            {
                base.DicFieldValue["profit_ratio"] = value;
            }
        }
 

        [
            Category("只读"),
            DisplayName("是否激活"),
            ReadOnly(true),
        ]
        public string is_deleted
        {
            get
            {
                return base.DicFieldValue["is_deleted"];
            }
            set
            {
                base.DicFieldValue["is_deleted"] = value;
            }
        }
 

        [
            Category("只读"),
            DisplayName("关联用户ID"),
            ReadOnly(true),
            BrowsableAttribute(false)
        ]
        public string inner_user_id
        {
            get
            {
                return base.DicFieldValue["inner_user_id"];
            }
            set
            {
                base.DicFieldValue["inner_user_id"] = value;
            }
        }

        [
            Category("只读"),
            DisplayName("关联用户名称"),
            ReadOnly(true),
            BrowsableAttribute(false)
        ]
        public string inner_user_label
        {
            get
            {
                return base.DicFieldValue["inner_user_label"];
            }
            set
            {
                base.DicFieldValue["inner_user_label"] = value;
            }
        }

        [
            Category("只读"),
            DisplayName("关联用户微信ID"),
            ReadOnly(true),
            BrowsableAttribute(false)
        ]
        public string inner_user_wx_openid
        {
            get
            {
                return base.DicFieldValue["inner_user_wx_openid"];
            }
            set
            {
                base.DicFieldValue["inner_user_wx_openid"] = value;
            }
        }



        [
            Category("只读"),
            DisplayName("机构类型ID"),
            ReadOnly(true),
            BrowsableAttribute(false)
        ]
        public string type_id
        {
            get
            {
                return base.DicFieldValue["type_id"];
            }
            set
            {
                base.DicFieldValue["type_id"] = value;
            }
        }

        [
            Category("只读"),
            DisplayName("进驻业务ID"),
            ReadOnly(true),
            BrowsableAttribute(false)
        ]
        public string bpm_id
        {
            get
            {
                return base.DicFieldValue["bpm_id"];
            }
            set
            {
                base.DicFieldValue["bpm_id"] = value;
            }
        }
    }
}
