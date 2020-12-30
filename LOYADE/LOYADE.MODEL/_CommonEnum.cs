using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LOYADE.MODEL
{
    public enum Status
    {
        好 = 1,
        不好 = 2,

    }

    public enum Education
    {
        未设定 = 0,
        大专 = 1,
        本科_学士 = 2,
        研究生_硕士 = 3,
        研究生_博士 = 4,
        国内_博士后 = 5,
        海归_硕士 = 6,
        海归_博士 = 7,
        海归_博士后 = 8,
    }

    public enum IPMajor
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

    public enum CareerLevel
    {
        未设定 = -1,
        初级 = 0,
        高级 = 1,
        中级 = 2, 
    }


    public enum Major
    {
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

    public enum Role
    {
        DEV = -1,//开发者
        NONE = 0,//未设定,默认通用
        SA = 1,//超级管理员
        BA = 2,//业务管理员
        AA = 3,//财务管理员
        AGENT = 4,//服务商,代理人
        DEPT = 5,//服务机构,机构管理员
        TQC = 6,//区域质量管理员
        DEALER = 7,//战略合伙人
        DTUSER = 8,//用户
    }
}
