using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace LOYADE.MODEL
{
    /// <summary>
    /// 用户/战略合伙人主表
    /// </summary>
    [Serializable]
    public partial class __DTUSER : _BaseModel
    {
        public __DTUSER()
        {
            SetFieldLabel();
        }

        public void SetFieldLabel()
        {

        }


        [
            Category("只读"),
            DisplayName("微信公众号关注ID"),
            ReadOnly(true),
            Browsable(false)
        ]
        public string wx_openid
        {
            get
            {
                return base.DicFieldValue["wx_openid"];
            }
            set
            {
                base.DicFieldValue["wx_openid"] = value;
            }
        }


        [
            Category("只读"),
            DisplayName("微信系统ID"),
            ReadOnly(true),
            Browsable(false)
        ]
        public string bp_wx_user_id
        {
            get
            {
                return base.DicFieldValue["bp_wx_user_id"];
            }
            set
            {
                base.DicFieldValue["bp_wx_user_id"] = value;
            }
        }


        [
            Category("只读"),
            DisplayName("用户名"),
            ReadOnly(true),
            Browsable(true)
        ]
        public string user_name
        {
            get
            {
                return base.DicFieldValue["user_name"];
            }
            set
            {
                base.DicFieldValue["user_name"] = value;
            }
        }

        [
            Category("个人信息"),
            DisplayName("[01] 真实姓名"),
            ReadOnly(false),
            Browsable(true)
        ]
        public string nick_name
        {
            get
            {
                return base.DicFieldValue["nick_name"];
            }
            set
            {
                base.DicFieldValue["nick_name"] = value;
            }
        }

        [
            Category("只读"),
            DisplayName("组号"),
            ReadOnly(true),
            Browsable(false)
        ]
        public string group_id
        {
            get
            {
                return base.DicFieldValue["group_id"];
            }
            set
            {
                base.DicFieldValue["group_id"] = value;
            }
        }


        [
            Category("个人信息"),
            DisplayName("[02] 手机号码"),
            ReadOnly(false),
            Browsable(true)
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
            Category("个人信息"),
            DisplayName("[03] 电子邮箱"),
            ReadOnly(false),
            Browsable(true)
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
            Category("个人信息"),
            DisplayName("[04] 联系电话"),
            ReadOnly(false),
            Browsable(true)
        ]
        public string telphone
        {
            get
            {
                return base.DicFieldValue["telphone"];
            }
            set
            {
                base.DicFieldValue["telphone"] = value;
            }
        }

        [
            Category("只读"),
            DisplayName("密码"),
            ReadOnly(true),
            Browsable(false)
        ]
        public string password
        {
            get
            {
                return base.DicFieldValue["password"];
            }
            set
            {
                base.DicFieldValue["password"] = value;
            }
        }

        [
            Category("个人信息"),
            DisplayName("[05] QQ号码"),
            ReadOnly(false),
            Browsable(true)
        ]
        public string qq
        {
            get
            {
                return base.DicFieldValue["qq"];
            }
            set
            {
                base.DicFieldValue["qq"] = value;
            }
        }


        [
            Category("个人信息"),
            DisplayName("[06] 身份证"),
            ReadOnly(false),
            Browsable(true)
        ]
        public Education msn
        {
            get
            {
                Education edu;
                Enum.TryParse<Education>(base.DicFieldValue["msn"], out edu);
                return edu;
            }
            set
            {
                base.DicFieldValue["msn"] = value.ToString();
            }
        }

        [
            Category("只读"),
            DisplayName("加密KEY"),
            ReadOnly(true),
            Browsable(false),
        ]
        public string salt
        {
            get
            {
                return base.DicFieldValue["salt"];
            }
            set
            {
                base.DicFieldValue["salt"] = value;
            }
        }

        [
            Category("只读"),
            DisplayName("所在地区"),
            ReadOnly(true),
        ]
        public string area
        {
            get
            {
                return base.DicFieldValue["area"];
            }
        }

        [
            Category("个人信息"),
            DisplayName("[07] 详细地址"),
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
            DisplayName("是否战略合伙人"),
            ReadOnly(true),
        ]
        public string is_dealer
        {
            get
            {
                return base.DicFieldValue["is_dealer"];
            }
            set
            {
                base.DicFieldValue["is_dealer"] = value;
            }
        }


        [
            Category("个人信息"),
            DisplayName("[08] 积分"),
            ReadOnly(false),
        ]
        public string point
        {
            get
            {
                return base.DicFieldValue["point"];
            }
            set
            {
                base.DicFieldValue["point"] = value;
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
            Category("个人信息"),
            DisplayName("[09] 账户余额"),
            ReadOnly(false),
            Browsable(true)
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
            Category("个人信息"),
            DisplayName("[10] 联系人"),
            ReadOnly(false),
            Browsable(true)
        ]
        public string contact
        {
            get
            {
                return base.DicFieldValue["contact"];
            }
            set
            {
                base.DicFieldValue["contact"] = value;
            }
        }

        [
            Category("只读"),
            DisplayName("战略合伙人升级时间"),
            ReadOnly(true),
            Browsable(true)
        ]
        public string dealer_set_dt
        {
            get
            {
                return base.DicFieldValue["dealer_set_dt"];
            }
            set
            {
                base.DicFieldValue["dealer_set_dt"] = value;
            }
        }


        [
            Category("只读"),
            DisplayName("注册时间"),
            ReadOnly(true),
            Browsable(true)
        ]
        public DateTime reg_time
        {
            get
            {
                DateTime dt;
                DateTime.TryParse(base.DicFieldValue["reg_time"], out dt);
                return dt;
            }
            set
            {
                base.DicFieldValue["reg_time"] = value.ToString();
            }
        }

        [
            Category("个人信息"),
            DisplayName("[11] 所在单位名称"),
            ReadOnly(false),
        ]
        public string company
        {
            get
            {
                return base.DicFieldValue["company"];
            }
            set
            {
                base.DicFieldValue["company"] = value;
            }
        }

        [
            Category("只读"),
            DisplayName("战略合伙人等级"),
            ReadOnly(true),
        ]
        public string dealer_rank
        {
            get
            {
                return base.DicFieldValue["dealer_rank"];
            }
            set
            {
                base.DicFieldValue["dealer_rank"] = value;
            }
        }

        [
            Category("个人信息"),
            DisplayName("[12] 推广分成"),
            ReadOnly(false),
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

    }
}