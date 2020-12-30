using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LOYADE.DATA.LITE
{
    public class DBConnector
    {
        public DBConnector()
        {
        }

        public DBConnector(string dstype)
        {
            _dstype = dstype;
            _datasource = "127.0.0.1";
            _userid = "";
            _password = "";
            _port = "";
            _defaultdatabase = "";
            _databaseowner = "";
            _startyear = "";
        }

        protected string _dstype;

        protected string _startyear;

        protected string _datasource;

        protected string _userid;

        protected string _password;

        protected string _port;

        protected string _defaultdatabase;

        protected string _databaseowner;
 
        public string DSType
        {
            get { return _dstype; }
            set { _dstype = value; }
        }

        public string DataSource
        {
            get { return _datasource; }
            set { _datasource = value; }
        }

        public string StartYear
        {
            get { return _startyear; }
            set { _startyear = value; }
        }

        public string UserID
        {
            get { return _userid; }
            set { _userid = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string Port
        {
            get { return _port; }
            set { _port = value; }
        }

        public string DefaultDatabase
        {
            get { return _defaultdatabase; }
            set { _defaultdatabase = value; }
        }
        public string DatabaseOwner
        {
            get { return _databaseowner; }
            set { _databaseowner = value; }
        }
    }
}
