using System;


namespace LOYADE.BPM
{
    public enum BPMExceptionInfo
    {
        NoExceptionButWXError = -1,//操作成功但是微信消息发送失败
        NoException = 0,//无错误
        NoLogin = 1,//未登录
        NoAuthorization = 2,//无权限
        NoParameter = 3,//无参数
        ParameterException = 4,//参数错误
        SQLException = 5,//SQL语法错误
        SystemException = 6,//系统错误
        SQLKeyRepeatedException = 7,//索引重复性错误
        Timeout = 8,//操作超时
        LackParameter = 9,//缺参数
    }

    public enum BPMSessionKey
    {
        VerifyCodeForWebPage = -2,
        VerifyCodeForSMS = -1,
        UserID = 1,
        UserSN = 2,
        UserLabel = 3,
        UserLoginName = 4,
        UserType = 5,
        UserWeiXinOpenID = 6,
        UserTargetPage = 7,
        UserTerminalType = 8,
        UserCurrentPlatformSN = 9,
        UserCurrentOrgSN = 10,
        UserCurrentRoleSN = 11,
        UserTemplate = 12,
        UserCSSFont = 13,
        UserCSSColor = 14,
        UserTempTag = 15,
        UserAuthIP = 16,
        UserAuthMac = 17,
        UserAuthMachine = 18,
        UserOwnerSN = 19,
        UserHumanSN = 20,
        UserNickName = 21,
        UserPowerType = 22,
        UserPasswordEncrypt = 99,
        UserStaffSN = 100,
    }

    public enum BPMUserType
    {
        Dev = 0,//开发级（开发平台功能模块）
        Platform = 1,//平台运营商级（购买、运营平台功能模块）
        SA = 2,//系统管理员级（管理平台功能模块及用户）
        Dept = 3,//内部单位级（部门用户）
        Inner = 4,//内部成员级（个人用户）
        Outfit = 5,//外部单位级（单位供应商、单位客户）
        Outer = 6,//外部用户级（个人供应商、个人客户）
        Agent = 7,//机器人代理用户级（程序、服务等）
    }


    public enum PetriNetObjectStatus
    {
        /// <summary>
        /// 使能
        /// </summary>
        Enabled = 1,
        /// <summary>
        /// 可激发
        /// </summary>
        Firing = 2,
        /// <summary>
        /// 正常
        /// </summary>
        Normal = 0,
    }

    public enum ArcType
    {
        /// <summary>
        /// 正常
        /// </summary>
        Normal = 0,
        /// <summary>
        /// 抑制
        /// </summary>
        Inhibitor = 1,
        /// <summary>
        /// 测控
        /// </summary>
        ObserveControl = 2,
    }

    public enum ArcFlowType
    {
        NotSet = 0,
        /// <summary>
        /// 输入，从库所到变迁
        /// </summary>
        Input = 1,
        /// <summary>
        /// 输出，从变迁到库所
        /// </summary>
        Output = 2,
    }

    public enum PNObjectType
    {
        /// <summary>
        /// 无
        /// </summary>
        None = 0,
        /// <summary>
        /// 库所
        /// </summary>
        Place = 1,
        /// <summary>
        /// 变迁
        /// </summary>
        Transition = 2,
        /// <summary>
        /// 弧
        /// </summary>
        Arc = 3,
        /// <summary>
        /// 弧路径点
        /// </summary>
        ArcPath = 4,
    }

    public enum MessageType
    {
        BPMEngine = 0,//业务过程管理系统引擎
        UserPrivate = 1,//用户单发
        UserOrg = 2,//用户对组织级群发
        UserDept = 3,//用户对部门级群发
        UserGroup = 4,//用户对好友组群发

    }

    public enum UserEducation
    {
        未设定 = -1,
        大专 = 1,
        本科_学士 = 2,
        本科_双学士 = 3,
        研究生_硕士 = 4,
        研究生_双硕士 = 5,
        研究生_博士 = 6,
        研究生_双博士 = 7,
        博士后 = 8,
    }

    public enum UserIPMajor
    {
        不限专业 = -1,
        机械 = 1,
        光电技术 = 2,
        材料工程 = 3,
        医药生物 = 4,
        化学 = 5,
        电学 = 6,
        通信 = 7,
    }

    public enum UserCareer
    {
        未设定 = -1,
        其他 = 0,
        评估师 = 1,
        专利代理人 = 2,
        律师 = 3,
        会计师 = 4,
        审计师 = 5,
        商标代理人 = 6
    }

    public enum UserCareerLevel
    {
        未设定 = -1,
        初级 = 0,
        高级 = 1,
        中级 = 2,
    }


    public enum UserMajor
    {
        未设定 = -1,
        法学 = 1,
        工学 = 2,
        理学 = 3,
        农学 = 4,
        文学 = 5,
        经济学 = 6,
        管理学 = 7,
        教育学 = 8,
        医学 = 9,
        哲学 = 10,
        历史学 = 11,
        军事学 = 12,
    }
}
