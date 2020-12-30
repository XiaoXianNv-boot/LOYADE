using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LOYADE.MODEL
{
    public class BPM : _BaseModel
    {
        public BPM()
        {

        }

        public string GetFieldValue(string key)
        {
            if (DicFieldValue.ContainsKey(key))
                return DicFieldValue[key];
            else
                return "";
        }

        public void SetFieldValue(string key, string value)
        {
            if (DicFieldValue.ContainsKey(key))
                DicFieldValue[key] = value;
        }

        [
            Category("只读"),
            DisplayName("当前流程系统ID"),
            BrowsableAttribute(false),
            ReadOnly(true),
        ]
        public string bpm_process_id
        {
            get
            {
                return DicFieldValue["bpm_process_id"];
            }
            set
            {
                DicFieldValue["bpm_process_id"] = value;
            }
        }

        [
            Category("只读"),
            DisplayName("当前流程状态系统ID"),
            BrowsableAttribute(false),
            ReadOnly(true),
        ]
        public string bpm_process_status_id
        {
            get
            {
                return DicFieldValue["bpm_process_status_id"];
            }
            set
            {
                DicFieldValue["bpm_process_status_id"] = value;
            }
        }

        [
        Category("只读"),
        DisplayName("当前流程状态"),
        BrowsableAttribute(true),
        ReadOnly(true),
    ]
        public string bpm_process_status_label
        {
            get
            {
                return DicFieldValue["bpm_process_status_label"];
            }
            set
            {
                DicFieldValue["bpm_process_status_label"] = value;
            }
        }

        [
            Category("只读"),
            DisplayName("前置流程系统ID"),
            BrowsableAttribute(false),
            ReadOnly(true),
        ]
        public string previous_bpm_process_id
        {
            get
            {
                return DicFieldValue["previous_bpm_process_id"];
            }
            set
            {
                DicFieldValue["previous_bpm_process_id"] = value;
            }
        }

        [
            Category("只读"),
            DisplayName("后续流程系统ID"),
            BrowsableAttribute(false),
            ReadOnly(true),
        ]
        public string next_bpm_process_id
        {
            get
            {
                return DicFieldValue["next_bpm_process_id"];
            }
            set
            {
                DicFieldValue["next_bpm_process_id"] = value;
            }
        }

        [
            Category("只读"),
            DisplayName("服务商系统ID"),
            BrowsableAttribute(false),
            ReadOnly(true),
        ]
        public string inner_user_id
        {
            get
            {
                return DicFieldValue["inner_user_id"];
            }
            set
            {
                DicFieldValue["inner_user_id"] = value;
            }
        }

        [
            Category("只读"),
            DisplayName("申请用户系统ID"),
            BrowsableAttribute(false),
            ReadOnly(true),
        ]
        public string apply_dt_user_id
        {
            get
            {
                return DicFieldValue["apply_dt_user_id"];
            }
            set
            {
                DicFieldValue["apply_dt_user_id"] = value;
            }
        }

        [
            Category("只读"),
            DisplayName("申请用户名"),
            ReadOnly(true),
        ]
        public string apply_dt_user_label
        {
            get
            {
                return DicFieldValue["apply_dt_user_label"];
            }
            set
            {
                DicFieldValue["apply_dt_user_label"] = value;
            }
        }

        [
            Category("只读"),
            DisplayName("是否通过质量审核"),
            ReadOnly(true),
        ]
        public string is_quality_ok
        {
            get
            {
                return DicFieldValue["is_quality_ok"];
            }
            set
            {
                DicFieldValue["is_quality_ok"] = value;
            }
        }

        [
            Category("只读"),
            DisplayName("是否处于基本信息只读节点"),
            ReadOnly(true),
        ]
        public string basic_readonly
        {
            get
            {
                return DicFieldValue["basic_readonly"];
            }
            set
            {
                DicFieldValue["basic_readonly"] = value;
            }
        }

        [
            Category("只读"),
            DisplayName("是否处于文件信息只读节点"),
            ReadOnly(true),
        ]
        public string file_readonly
        {
            get
            {
                return DicFieldValue["file_readonly"];
            }
            set
            {
                DicFieldValue["file_readonly"] = value;
            }
        }

        [
            Category("只读"),
            DisplayName("代理价格"),
            ReadOnly(true),
        ]
        public string price
        {
            get
            {
                return DicFieldValue["price"];
            }
            set
            {
                DicFieldValue["price"] = value;
            }
        }

        [
            Category("只读"),
            DisplayName("累计已缴代理费"),
            ReadOnly(true),
        ]
        public string charge_agent
        {
            get
            {
                return DicFieldValue["charge_agent"];
            }
            set
            {
                DicFieldValue["charge_agent"] = value;
            }
        }

        [
            Category("只读"),
            DisplayName("规费"),
            ReadOnly(true),
        ]
        public string price_gov
        {
            get
            {
                return DicFieldValue["price_gov"];
            }
            set
            {
                DicFieldValue["price_gov"] = value;
            }
        }

        [
            Category("只读"),
            DisplayName("业务规费"),
            Browsable(false),
            ReadOnly(true),
        ]
        public string gov_price
        {
            get
            {
                return DicFieldValue["gov_price"];
            }
            set
            {
                DicFieldValue["gov_price"] = value;
            }
        }

        [
            Category("只读"),
            DisplayName("累计已缴规费"),
            ReadOnly(true),
        ]
        public string charge_gov
        {
            get
            {
                return DicFieldValue["charge_gov"];
            }
            set
            {
                DicFieldValue["charge_gov"] = value;
            }
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
            DisplayName("[02] 联系电话"),
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
            DisplayName("[05] 详细地址"),
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
    }
}
