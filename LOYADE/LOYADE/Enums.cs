using System;

namespace LOYADE
{
    public enum AAA
    {
        X = 1,
        Y = 2,
        
    }

    public enum WebEncryptFormat
    {
        MD5 = 1,
        SHA1 = 2,

    }

    public enum DataSourceKey
    {
        DMS = 0,
        Engine = 1,
        Common = 2,
        ORABAC = 3,
        File = 4,
        UserSA = 5,
        UserInner = 6,
        UserDept = 7,
        UserOuter = 8,
        UserOutfit = 9,
        UserPlatform = 10,
        UserAgent = 11,
        UserDev = 12,

        ERP = 14,
        CRM = 15,
        WMS = 16,
        EDU = 17,
        VRM = 18,
        ACC = 19,
        IPRM = 20,
        Fault = 21,
        SNS = 22,
        QUESTIONNAIRE = 221,
        MRO = 23,
        QAR = 24,
        HMI = 25,
        X = 27,
        BSC = 28,
        HRM = 29,
        DM = 30,
        MES = 31,
        SCM = 32,
        WeiXin = 33,

        Biz = 100,
        Log = 101,
        Custom = 102,
        SCADA = 103,
        PI = 104,
        IM = 105,

        Weld = 200,
        Spray = 201,
        Injection = 202,
        PLC = 203,
        BusinessInfo = 204,
        BusinessData = 205,

        NC = 300,
        Digiwin = 301,

        Game = 999,
    }


    public enum LabelPatternType
    {
        QRCode = 1,
        DataMatrix = 2,
        Code128 = 3,
        Code39 = 4,
        String = 5,
        Image = 6,
        DateTime = 7,
        Field = 8,
        Rectangle = 9,
        Ellipse = 10,
        Line = 11,
    }


    public enum FunctionModule
    {
        ERP = 1,
        MES = 2,
        CRM = 3,
        DM = 4,
        OA = 5,
        BSC = 6,
        SCM = 7,
        HRM = 8,
        WMS = 9,
        EDU = 10,
        IPRM = 11,
        VRS = 11,
    }

    public enum ServiceModule
    {
        VideoPush = 1,
        Scada = 2,
        ERPSyn = 3,
        IM = 4,

    }
}
