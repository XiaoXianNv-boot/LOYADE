using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

using LOYADE;

namespace LOYADE.DATA
{
    public abstract class ActionDBSQL
    { 
        public string ExceptionInfo = "";
 
        private ServiceType _servicetype;

        public ServiceType ServiceType
        {
            get { return _servicetype; }
            set { _servicetype = value; }
        }

        private Dictionary<string, ObjectPair> _connections = new Dictionary<string, ObjectPair>();

        public Dictionary<string, ObjectPair> Connections
        {
            get { return _connections; }
        }

        public void UseDynamicConnection(string file)
        {
            string key = Guid.NewGuid().ToString();
            AddConnection(key, new ObjectPair(key, "Data Source=" + file));
        }

        /// <summary>
        /// 连接Access文件
        /// </summary>
        /// <param name="file">文件路径</param>
        /// <param name="version">文件版本，1997至2003为8，XP、2007至2013为12</param> 
        public void UseDynamicConnection(string file, int version )
        {
            string key = Guid.NewGuid().ToString();
            if (version == 8)
                AddConnection(key, new ObjectPair(key, "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + file));
            else
                AddConnection(key, new ObjectPair(key, "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + file));
        }

        /// <summary>
        /// 连接Excel文件
        /// </summary>
        /// <param name="file">文件路径</param>
        /// <param name="version">文件版本，1997至2003为8，XP、2007至2013为12</param>
        /// <param name="hdr">YES-首行为列名读取首行数据，NO-首行不是列名，读取首行数据</param>
        /// <param name="imex">0-写入，1-读取，2-读写</param>
        public void UseDynamicConnection(string file, int version, string hdr, int imex)
        {
            string key = Guid.NewGuid().ToString();
            if (version == 8)
                AddConnection(key, new ObjectPair(key, "Provider=Microsoft.Jet.OLEDB.4.0;Extended Properties='Excel 8.0;HDR=" + hdr + ";IMEX=" + imex + "';Data Source=" + file));
            else
                AddConnection(key, new ObjectPair(key, "Provider=Microsoft.ACE.OLEDB.12.0;Extended Properties='Excel 12.0;HDR=" + hdr + ";IMEX=" + imex + "';Data Source=" + file));
        }

        public void UseDynamicConnection(string key, string connstr)
        {
            AddConnection(key, new ObjectPair(key, connstr));
        }

        /// <summary>
        /// 连接Excel文件
        /// </summary>
        /// <param name="key">连接池键值</param>
        /// <param name="file">文件路径</param>
        /// <param name="version">文件版本，1997至2003为8，XP、2007至2013为12</param>
        /// <param name="hdr">YES-首行为列名读取首行数据，NO-首行不是列名，读取首行数据</param>
        /// <param name="imex">0-写入，1-读取，2-读写</param>        
        public void UseDynamicConnection(string key, string file, string version, string hdr, int imex)
        {
            if (version == "1997-2003")
                AddConnection(key, new ObjectPair(key, "Provider=Microsoft.Jet.OLEDB.4.0;Extended Properties='Excel 8.0;HDR=" + hdr + ";IMEX=" + imex + "';Data Source=" + file));
            else
                AddConnection(key, new ObjectPair(key, "Provider=Microsoft.ACE.OLEDB.12.0;Extended Properties='Excel 12.0;HDR=" + hdr + ";IMEX=" + imex + "';Data Source=" + file));
        }

        /// <summary>
        /// MSSQL
        /// </summary>
        /// <param name="key"></param>
        /// <param name="ip"></param>
        /// <param name="uid"></param>
        /// <param name="pwd"></param>
        /// <param name="db"></param>
        public void UseDynamicConnection(string key, string ip, string uid, string pwd, string db)
        {
            AddConnection(key, new ObjectPair(key, "Data Source=" + ip + ";Initial Catalog=" + db + ";User ID=" + uid + ";Password=" + pwd));
        }

        /// <summary>
        /// MSSQL 以外的数据库
        /// </summary>
        /// <param name="key"></param>
        /// <param name="ip"></param>
        /// <param name="uid"></param>
        /// <param name="pwd"></param>
        /// <param name="db"></param>
        /// <param name="charset"></param>
        public void UseDynamicConnection(string key, string ip, string uid, string pwd, string db, string charset)
        {
            AddConnection(key, new ObjectPair(key, "Data Source=" + ip + ";Initial Catalog=" + db + ";User ID=" + uid + ";Password=" + pwd + ";charset=" + charset));
        }

        /// <summary>
        /// MSSQL
        /// </summary>
        /// <param name="key"></param>
        /// <param name="ip"></param>
        /// <param name="uid"></param>
        /// <param name="pwd"></param>
        /// <param name="db"></param>
        /// <param name="port"></param>
        public void UseDynamicConnection(string key, string ip, string uid, string pwd, string db, int port)
        {
            AddConnection(key, new ObjectPair(key, "Data Source=" + ip + ","+ port + ";Initial Catalog=" + db + ";User ID=" + uid + ";Password=" + pwd));
        }

        /// <summary>
        /// MSSQL 以外的数据库
        /// </summary>
        /// <param name="key"></param>
        /// <param name="ip"></param>
        /// <param name="uid"></param>
        /// <param name="pwd"></param>
        /// <param name="db"></param>
        /// <param name="charset"></param>
        /// <param name="port"></param>
        public void UseDynamicConnection(string key, string ip, string uid, string pwd, string db, string charset, int port)
        {
            AddConnection(key, new ObjectPair(key, "Data Source=" + ip + ";Initial Catalog=" + db + ";User ID=" + uid + ";Password=" + pwd + ";charset=" + charset + ";Port=" + port));
        }

        public void UseDynamicConnection(string key, string server, string db)
        {
            AddConnection(key, new ObjectPair(key, server + "Initial Catalog=" + db));
        }

        public void UseDynamicConnection(string key, string ip, string account, string db)
        {
            AddConnection(key, new ObjectPair(key, "Data Source=" + ip + ";Initial Catalog=" + db + ";" + account));
        }

        public abstract object OpenConnection(string connstr);
        
        public abstract void CloseConnection(object connobj); 

        public abstract DataSet GetDataSetBySQLWithConnectionOpen(string sql, object connobj);

        public abstract int OperateBySQLWithConnectionOpen(string sql, object connobj);

        public abstract string[] GetOneRecordBySQLWithConnectionOpen(string sql, object connobj);
 
        public void AddConnection(string key, ObjectPair sp)
        {
            if (_connections.ContainsKey(key))
                _connections[key] = sp;
            else
                _connections.Add(key, sp);
            _currentconnectionkey = key; 
        }

        public void RemoveConnection(string key)
        {
            if (_connections.ContainsKey(key))
                _connections.Remove(key);
        }

        public void RemoveCurrentConnection()
        {
            if (_connections.ContainsKey(_currentconnectionkey))
                _connections.Remove(_currentconnectionkey);
            _currentconnectionkey = null;
        }

        public void RemoveAllConnections()
        {
            _connections.Clear();
            _currentconnectionkey = null;
        }

        public virtual string TestConnection(string key)
        {
            return "";
        }

        private string _currentconnectionkey;

        public string CurrentConnectionKey
        {
            get { return _currentconnectionkey; }
            set { _currentconnectionkey = value; }
        }

        protected ActionDBSQL()
        {
            //这个设计模式用于多类型数据库服务情况下，稳定性未知！
            //假设某个系统同时运行Oracle和MSSQL，一批用户需要访问Oracle库，另一批需要访问MSSQL，
            //那么就需要不停的切换并新建adbs，这个单件模式不再是单件模式了！
        }

        public static ActionDBSQL GetInstance(string servicetype)
        {
            ActionDBSQL adbs;
            switch (servicetype)
            {
                default:
                    adbs = new ActionDBMSSQL();
                    break;
                case "MSSQL":
                    adbs = new ActionDBMSSQL();
                    break;
                case "OleDb":
                    adbs = new ActionDBOleDb();
                    break;
                case "Oracle":
                    adbs = new ActionDBOracle();
                    break;
                case "MySQL":
                    adbs = new ActionDBMySQL();
                    break;
                case "SQLite":
                    adbs = new ActionDBSQLite();
                    break;
            }
            adbs.ServiceType = (ServiceType)Enum.Parse(typeof(ServiceType), servicetype);
            return adbs;
        }

        public static ActionDBSQL GetInstance(ServiceType servicetype)
        {
            ActionDBSQL adbs;
            switch (servicetype)
            {
                default:
                    adbs = new ActionDBMSSQL();
                    break;
                case ServiceType.MSSQL:
                    adbs = new ActionDBMSSQL();
                    break;
                case ServiceType.OleDb:
                    adbs = new ActionDBOleDb();
                    break;
                case ServiceType.Oracle:
                    adbs = new ActionDBOracle();
                    break;
                case ServiceType.MySQL:
                    adbs = new ActionDBMySQL();
                    break;
                case ServiceType.SQLite:
                    adbs = new ActionDBSQLite();
                    break;
            }
            adbs.ServiceType = servicetype;
            return adbs;
        }

        public abstract bool CreateDataTable(string engine, string charset, string tablename, List<ObjectDataModel> odms);

        public virtual string GetCreateDataTableString(string engine, string charset, string tablename, List<ObjectDataModel> odms)
        {
            return "";
        }

        public abstract bool AlterDataTable(string tablename, string fieldname, string action, ObjectDataModel newodm);

        public abstract DataSet GetDataSetBySQL(string sql);

        public abstract string GetDataSetXMLBySQL(string sql);

        public abstract int OperateBySQL(string sql);


        public abstract object GetScalarBySQL(string sql);

        public abstract string[] GetOneRecordBySQL(string sql);

        public virtual Dictionary<string, string> GetOneRecordBySQL(string[] fields, string table, string where)
        {
            return new Dictionary<string, string>();
        }

        public virtual Dictionary<string, string> GetOneRecordBySQL(List<string> fields, string table, string where)
        {
            return new Dictionary<string, string>();
        }

        public virtual long OperateBySQL(string sql, bool needidreturn)
        {
            return 0;
        }

        public virtual void OperateBySQLBulkCopy(string targetdt, DataTable dtsource)
        {
            
        }

        public virtual void OperateBySQLBulkCopy(string targetdt, DataTable dtsource, Dictionary<string, string> dictargetcolumns)
        {

        }

        public virtual int OperateBySQL(string sql, string[] paranames, object[] paravalues)
        {
            return 0;
        }

        public virtual int OperateBySQL(string sql, string[] paranames, string[] paravalues)
        {
            return 0;
        }

        public virtual int OperateByTransaction(string[] arrsql)
        {
            return 0;
        }

        public virtual int OperateBinaryBySQL(string sql, Dictionary<string, byte[]> binaryobjects)
        {
            return 0;
        }

        public virtual int OperateByScript(string script)
        {
            return 0;
        }

        public virtual int OperateByScriptWithConnectionOpen(string script, object connobj)
        {
            return 0;
        }

        public virtual int OperateByMultiSQL(List<ObjectSQL> listsql)
        {
            return 0;
        }

        public virtual DataSet GetDataSetBySP(string spname, string[] spparanames, string[] spparavalues)
        {
            return new DataSet();
        }

        public virtual DataSet GetDataSetBySP(string spname)
        {
            return new DataSet();
        }

        public virtual string GetDataSetXMLBySP(string spname, string[] spparanames, string[] spparavalues)
        {
            return "";
        }

        public virtual int OperateBySP(string spname, string[] spparanames, string[] spparavalues)
        {
            return 0;
        }

        public virtual int OperateBySP(string spname)
        {
            return 0;
        }

        public virtual object GetScalarBySP(string spname, string[] spparanames, string[] spparavalues)
        {
            return new object();
        }

        public virtual object GetScalarBySP(string spname)
        {
            return new object();
        }

        public virtual string[] GetOneRecordBySP(string spname, string[] spparanames, string[] spparavalues)
        {
            return new string[0];
        }
    }
}
