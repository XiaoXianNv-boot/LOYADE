using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace LOYADE.MODEL
{
    /// <summary>
    /// 代理人主表
    /// </summary>
    [Serializable]
    public partial class __ADENT : _BaseModelWithCover
    {
        public __ADENT()
        {
            base._object_type = "inner_user";
            SetFieldLabel();
        }

        public void SetFieldLabel()
        {

        }


        [
            Category("只读"),
            DisplayName("微信公众号关注ID"),
            ReadOnly(true), 
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
            Category("系统数据"),
            DisplayName("好评数"),
            ReadOnly(true), 
        ]
        public string good_count
        {
            get
            {
                return base.DicFieldValue["good_count"];
            }
            set
            {
                base.DicFieldValue["good_count"] = value;
            }
        }

        [
            Category("系统数据"),
            DisplayName("中评数"),
            ReadOnly(true), 
        ]
        public string middle_count
        {
            get
            {
                return base.DicFieldValue["middle_count"];
            }
            set
            {
                base.DicFieldValue["middle_count"] = value;
            }
        }

        [
            Category("系统数据"),
            DisplayName("差评数"),
            ReadOnly(true), 
        ]
        public string bad_count
        {
            get
            {
                return base.DicFieldValue["bad_count"];
            }
            set
            {
                base.DicFieldValue["bad_count"] = value;
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
            DisplayName("是否禁用"),
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
            DisplayName("所在机构系统ID"),
            ReadOnly(true),
            Browsable(false)
        ]
        public string dept_id
        {
            get
            {
                return base.DicFieldValue["dept_id"];
            }
            set
            {
                base.DicFieldValue["dept_id"] = value;
            }
        }

        [
            Category("个人信息"),
            DisplayName("[01] 用户名"),
            ReadOnly(true),
            Browsable(true)
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
            Category("个人信息"),
            DisplayName("[02] 真实姓名"),
            ReadOnly(false),
            Browsable(true)
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
            Category("个人信息"),
            DisplayName("[03] 执业证号"),
            ReadOnly(false),
            Browsable(true)
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
            Category("个人信息"),
            DisplayName("[04] 手机号码"),
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
            DisplayName("[05] 电子邮箱"),
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
            DisplayName("[06] 联系电话"),
            ReadOnly(false),
            Browsable(true)
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
            DisplayName("[07] QQ号码"),
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
            DisplayName("[08] 学历学位"),
            ReadOnly(false),
            Browsable(true)
        ]
        public Education education
        {
            get
            {
                Education edu;
                Enum.TryParse<Education>(base.DicFieldValue["education"], out edu);
                return edu;
            }
            set
            {
                base.DicFieldValue["education"] = value.ToString();
            }
        }

        
        [
            Category("个人信息"),
            DisplayName("[09] 个人介绍"),
            ReadOnly(false),
            Browsable(false)
        ]
        public string resume_info
        {
            get
            {
                return base.DicFieldValue["resume_info"];
            }
            set
            {
                base.DicFieldValue["resume_info"] = value;
            }
        }

        [
            Category("个人信息"),
            DisplayName("[09] 职称"),
            ReadOnly(false),
            Browsable(true)
        ]
        public CareerLevel career_level
        {
            get
            {
                CareerLevel cl;
                Enum.TryParse<CareerLevel>(base.DicFieldValue["career_level"], out cl);
                return cl;
            }
            set
            {
                base.DicFieldValue["career_level"] = value.ToString();
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
                return base.DicFieldValue["area_1_label"] + " " + base.DicFieldValue["area_2_label"] + " " + base.DicFieldValue["area_3_label"];
            }
        }

        [
            Category("个人信息"),
            DisplayName("[10] 详细地址"),
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
            DisplayName("被禁用日期"),
            ReadOnly(true),
            Browsable(true)
        ]
        public DateTime? delete_dt
        {
            get
            {
                DateTime dt;
                DateTime.TryParse(base.DicFieldValue["delete_dt"], out dt);
                return dt;
            }
            set
            {
                base.DicFieldValue["delete_dt"] = value.ToString();
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
            Category("只读"),
            DisplayName("是否认证"),
            ReadOnly(true),
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
            DisplayName("认证时间"),
            ReadOnly(true),
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
            DisplayName("头像地址"),
            ReadOnly(true),
            Browsable(false)
        ]
        public string photo_file
        {
            get
            {
                return base.DicFieldValue["photo_file"];
            }
            set
            {
                base.DicFieldValue["photo_file"] = value;
            }
        }

        [
            Category("只读"),
            DisplayName("学历专业ID"),
            ReadOnly(true),
            Browsable(false)
        ]
        public string major_id
        {
            get
            {
                return base.DicFieldValue["major_id"];
            }
            set
            {
                base.DicFieldValue["major_id"] = value;
            }
        }

        [
            Category("只读"),
            DisplayName("学历专业名称"),
            ReadOnly(true),
            Browsable(true)
        ]
        public string major_label
        {
            get
            {
                return base.DicFieldValue["major_label"];
            }
            set
            {
                base.DicFieldValue["major_label"] = value;
            }
        }
 

        [
            Category("只读"),
            DisplayName("注册时间"),
            ReadOnly(true),
            Browsable(true)
        ]
        public DateTime create_dt
        {
            get
            {
                DateTime dt;
                DateTime.TryParse(base.DicFieldValue["create_dt"], out dt);
                return dt;
            }
            set
            {
                base.DicFieldValue["create_dt"] = value.ToString();
            }
        }

        [
            Category("只读"),
            DisplayName("所在机构名称"),
            ReadOnly(true),
        ]
        public string dept_label
        {
            get
            {
                return base.DicFieldValue["dept_label"];
            }
            set
            {
                base.DicFieldValue["dept_label"] = value;
            }
        } 

    }
}