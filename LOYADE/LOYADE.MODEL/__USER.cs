using System;

namespace LOYADE.MODEL
{
    /// <summary>
    /// 会员主表
    /// </summary>
    [Serializable]
    public partial class __USER
    {
        public __USER()
        { }
        #region Model
        private long _id;
        private int _group_id = 0;
        private string _user_name;
        private string _salt;
        private string _password;
        private string _mobile = string.Empty;
        private string _email = string.Empty;
        private string _avatar = string.Empty;
        private string _nick_name = string.Empty;
        private string _sex = string.Empty;
        private DateTime? _birthday;
        private string _telphone;
        private string _area = string.Empty;
        private string _address = string.Empty;
        private string _qq = string.Empty;
        private string _msn = string.Empty;
        private decimal _amount = 0M;
        private decimal _profit_ratio = 0M;
        private int _point = 0;
        private int _exp = 0;
        private int _status = 0;
        private DateTime _reg_time = DateTime.Now;
        private string _reg_ip;
        private bool _is_dealer = false;
        private string _contact = "";
        private string _company = "";
        private bool _is_company = false;
        private int _bp_wx_user_id = 0;
        private int _dealer_id = 0;
        private string _wx_openid;
        private string _dealer_rank = "1";
        private string _area_1_id = "0";
        private string _area_2_id = "0";
        private string _area_3_id = "0";
        private string _area_4_id = "0";

        /// <summary>
        /// 联系人
        /// </summary>
        public string contact
        {
            set { _contact = value; }
            get { return _contact; }
        }

        /// <summary>
        /// 所在单位
        /// </summary>
        public string company
        {
            set { _company = value; }
            get { return _company; }
        }

        /// <summary>
        /// 国
        /// </summary>
        public string area_1_id
        {
            set { _area_1_id = value; }
            get { return _area_1_id; }
        }


        /// <summary>
        /// 省
        /// </summary>
        public string area_2_id
        {
            set { _area_2_id = value; }
            get { return _area_2_id; }
        }


        /// <summary>
        /// 城市
        /// </summary>
        public string area_3_id
        {
            set { _area_3_id = value; }
            get { return _area_3_id; }
        }

        /// <summary>
        /// 区
        /// </summary>
        public string area_4_id
        {
            set { _area_4_id = value; }
            get { return _area_4_id; }
        }
        
        /// <summary>
        /// 战略合伙人等级
        /// </summary>
        public string dealer_rank
        {
            set { _dealer_rank = value; }
            get { return _dealer_rank; }
        }

        /// <summary>
        /// 微信公众号关注ID
        /// </summary>
        public string wx_openid
        {
            set { _wx_openid = value; }
            get { return _wx_openid; }
        }

        /// <summary>
        /// 推广商ID
        /// </summary>
        public int dealer_id
        {
            set { _dealer_id = value; }
            get { return _dealer_id; }
        }

        /// <summary>
        /// 微信关注号对应的平台内部ID
        /// </summary>
        public int bp_wx_user_id
        {
            set { _bp_wx_user_id = value; }
            get { return _bp_wx_user_id; }
        }

        /// <summary>
        /// 是否为企业用户
        /// </summary>
        public bool is_company
        {
            set { _is_company = value; }
            get { return _is_company; }
        }

        /// <summary>
        /// 是否为经销商
        /// </summary>
        public bool is_dealer
        {
            set { _is_dealer = value; }
            get { return _is_dealer; }
        }

        /// <summary>
        /// 自增ID
        /// </summary>
        public long id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 用户组ID
        /// </summary>
        public int group_id
        {
            set { _group_id = value; }
            get { return _group_id; }
        }
        /// <summary>
        /// 用户名
        /// </summary>
        public string user_name
        {
            set { _user_name = value; }
            get { return _user_name; }
        }
        /// <summary>
        /// 6位随机字符串,加密用到
        /// </summary>
        public string salt
        {
            set { _salt = value; }
            get { return _salt; }
        }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string password
        {
            set { _password = value; }
            get { return _password; }
        }
        /// <summary>
        /// 手机号码
        /// </summary>
        public string mobile
        {
            set { _mobile = value; }
            get { return _mobile; }
        }
        /// <summary>
        /// 电子邮箱
        /// </summary>
        public string email
        {
            set { _email = value; }
            get { return _email; }
        }
        /// <summary>
        /// 用户头像
        /// </summary>
        public string avatar
        {
            set { _avatar = value; }
            get { return _avatar; }
        }
        /// <summary>
        /// 真实姓名
        /// </summary>
        public string nick_name
        {
            set { _nick_name = value; }
            get { return _nick_name; }
        }
        /// <summary>
        /// 性别
        /// </summary>
        public string sex
        {
            set { _sex = value; }
            get { return _sex; }
        }
        /// <summary>
        /// 生日
        /// </summary>
        public DateTime? birthday
        {
            set { _birthday = value; }
            get { return _birthday; }
        }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string telphone
        {
            set { _telphone = value; }
            get { return _telphone; }
        }
        /// <summary>
        /// 所属地区
        /// </summary>
        public string area
        {
            set { _area = value; }
            get { return _area; }
        }
        /// <summary>
        /// 详细地址
        /// </summary>
        public string address
        {
            set { _address = value; }
            get { return _address; }
        }
        /// <summary>
        /// QQ号码
        /// </summary>
        public string qq
        {
            set { _qq = value; }
            get { return _qq; }
        }
        /// <summary>
        /// 身份证
        /// </summary>
        public string msn
        {
            set { _msn = value; }
            get { return _msn; }
        }
        /// <summary>
        /// 比例
        /// </summary>
        public decimal profit_ratio
        {
            set { _profit_ratio = value; }
            get { return _profit_ratio; }
        }
        /// <summary>
        /// 账户余额
        /// </summary>
        public decimal amount
        {
            set { _amount = value; }
            get { return _amount; }
        }
        /// <summary>
        /// 积分
        /// </summary>
        public int point
        {
            set { _point = value; }
            get { return _point; }
        }
        /// <summary>
        /// 经验值
        /// </summary>
        public int exp
        {
            set { _exp = value; }
            get { return _exp; }
        }
        /// <summary>
        /// 账户状态,0正常,1待验证,2待审核,3锁定
        /// </summary>
        public int status
        {
            set { _status = value; }
            get { return _status; }
        }
        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime reg_time
        {
            set { _reg_time = value; }
            get { return _reg_time; }
        }
        /// <summary>
        /// 注册IP
        /// </summary>
        public string reg_ip
        {
            set { _reg_ip = value; }
            get { return _reg_ip; }
        }
        #endregion

    }
}