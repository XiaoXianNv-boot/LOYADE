using System;
using System.Collections.Generic;
using System.Data;

using LOYADE;

namespace LOYADE.BPM
{
    public class ObjectUserBPM : ObjectUser
    { 
        public ObjectUserBPM()
        {
            _properties.Add("SN", "");
            _properties.Add("ID", "");
            _properties.Add("Label", "");//姓名
            _properties.Add("LoginName", "");//登录名
            _properties.Add("Mobile", "");//            
            _properties.Add("WXOpenID", "");//微信            
            _properties.Add("CustomCode", "");//客户编号
            _properties.Add("Type", "");// 
            _properties.Add("StaffSN", "");// 
            _properties.Add("HumanSN", "");// 
            _properties.Add("OrgSN", "");// 
            _properties.Add("PlatformSN", "");//
            _properties.Add("TerminalType", "");//
            _properties.Add("Template", "");//
            _properties.Add("CSSFont", "font-family: 'Microsoft YaHei';");//
            _properties.Add("CSSColor", "blue");//
            _properties.Add("DataFavorite", "");//
            _properties.Add("DataNavLeft", "");//
            _properties.Add("DataTask", "");//
            _properties.Add("DataTaskCount", "0");//
            _properties.Add("DataNotification", "");//
            _properties.Add("DataNotificationCount", "0");//            
        }
 

        public string SN
        {
            get { return _properties["SN"]; }
            set { _properties["SN"] = value; }
        }

        public string ID
        {
            get { return _properties["ID"]; }
            set { _properties["ID"] = value; }
        }

        public string Type
        {
            get { return _properties["Type"]; }
            set { _properties["Type"] = value; }
        }

        public string Label
        {
            get { return _properties["Label"]; }
            set { _properties["Label"] = value; }
        }

        public string LoginName
        {
            get { return _properties["LoginName"]; }
            set { _properties["LoginName"] = value; }
        }

        public string CustomCode
        {
            get { return _properties["CustomCode"]; }
            set { _properties["CustomCode"] = value; }
        }

        public string StaffSN
        {
            get { return _properties["StaffSN"]; }
            set { _properties["StaffSN"] = value; }
        }

        public string HumanSN
        {
            get { return _properties["HumanSN"]; }
            set { _properties["HumanSN"] = value; }
        }

        public string CSSFont
        {
            get { return _properties["CSSFont"]; }
            set { _properties["CSSFont"] = value; }
        }

        public string CSSColor
        {
            get { return _properties["CSSColor"]; }
            set { _properties["CSSColor"] = value; }
        }

        public string WXOpenID
        {
            get { return _properties["WXOpenID"]; }
            set { _properties["WXOpenID"] = value; }
        }

        public string Mobile
        {
            get { return _properties["Mobile"]; }
            set { _properties["Mobile"] = value; }
        }

        public string OrgSN
        {
            get { return _properties["OrgSN"]; }
            set { _properties["OrgSN"] = value; }
        }

        public string PlatformSN
        {
            get { return _properties["PlatformSN"]; }
            set { _properties["PlatformSN"] = value; }
        }

        public string TerminalType
        {
            get { return _properties["TerminalType"]; }
            set { _properties["TerminalType"] = value; }
        }

        public string Template
        {
            get { return _properties["Template"]; }
            set { _properties["Template"] = value; }
        }


        public string DataFavorite
        {
            get { return _properties["DataFavorite"]; }
            set { _properties["DataFavorite"] = value; }
        }

        public string DataNavLeft
        {
            get { return _properties["DataNavLeft"]; }
            set { _properties["DataNavLeft"] = value; }
        }

        public string DataTask
        {
            get { return _properties["DataTask"]; }
            set { _properties["DataTask"] = value; }
        }

        public string DataTaskCount
        {
            get { return _properties["DataTaskCount"]; }
            set { _properties["DataTaskCount"] = value; }
        }

        public string DataNotification
        {
            get { return _properties["DataNotification"]; }
            set { _properties["DataNotification"] = value; }
        }

        public string DataNotificationCount
        {
            get { return _properties["DataNotificationCount"]; }
            set { _properties["DataNotificationCount"] = value; }
        }

     
    }
}
