﻿using System;
using System.Collections.Generic;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Text; 

namespace LOYADE.DATA
{
    /*
        打开文件夹%ORACLE_HOME%\Network\Admin在这个下面建立一个tnsnames.ora的文件，其内容可以参考其下的Sample目录下面的配置
        Oracle.RACE =
        (DESCRIPTION=
           (ADDRESS_LIST=
             (ADDRESS=
               (PROTOCOL=TCP)
               (HOST=127.0.0.1)
               (PORT=1521)
             )
           )
           (CONNECT_DATA=
             (SID=RACE)
             (SERVER=DEDICATED)
           )
        )

        string connString = "DATA SOURCE=Oracle.RACE;PERSIST SECURITY INFO=True;USER ID=xiaole;password=xiaole";
    */
    public class ActionDBOracle : ActionDBSQL
    {
        public override string TestConnection(string key)
        {
            string res = "";
            OracleConnection.ClearAllPools();
            try
            {
                OracleConnection conn = new OracleConnection(base.Connections[key].Value.ToString());
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {
                res = ex.Message;
            }
            return res;
        }

        public override bool CreateDataTable(string engine, string charset, string tablename, List<ObjectDataModel> odms)
        {
            bool ret = true;
            StringBuilder strbui = new StringBuilder();
            try
            {
                strbui.Append("CREATE TABLE [");
                strbui.Append(tablename);
                strbui.Append("](");
                string primarykey = "";
                foreach (ObjectDataModel odm in odms)
                {
                    if (odm.IsPrimaryKey)
                        primarykey = odm.FieldName;
                    strbui.Append("[");
                    strbui.Append(odm.FieldName);
                    strbui.Append("] ");
                    strbui.Append(odm.DataType);
                    strbui.Append("(");
                    strbui.Append(odm.MaxLength);
                    if (odm.Precision > -1)
                        strbui.Append(odm.Precision);
                    strbui.Append(") ");
                    if (odm.DefaultValue != "")
                    {
                        if (odm.DataType == "bit")
                            strbui.Append("DEFAULT b'");
                        else
                            strbui.Append("DEFAULT '");
                        strbui.Append(odm.DefaultValue);
                        strbui.Append("' ");
                    }
                    if (odm.IsAllowNull)
                        strbui.Append("NULL,");
                    else
                        strbui.Append("NOT NULL,");
                }
                strbui.Append("PRIMARY KEY ([");
                strbui.Append(primarykey);
                strbui.Append("]))");
                if (engine != "")
                    strbui.Append("ENGINE=");
                strbui.Append(engine);
                strbui.Append(" DEFAULT CHARSET=");
                strbui.Append(charset);
                strbui.Append(";");
                OperateBySQL(strbui.ToString());
            }
            catch
            {
                ret = false;
            }
            return ret;
        }

        public override bool AlterDataTable(string tablename, string fieldname, string action, ObjectDataModel newodm)
        {
            bool ret = true;
            StringBuilder strbui = new StringBuilder();
            try
            {
                strbui.Append("ALTER TABLE [");//ALTER COLUMN column_name datatype
                strbui.Append(tablename);
                strbui.Append("] ");
                strbui.Append(action);//add, alter column（不允许drop column）
                strbui.Append(" ");
                strbui.Append(newodm.FieldName);
                strbui.Append(" ");
                strbui.Append(newodm.DataType);
                strbui.Append("(");
                strbui.Append(newodm.MaxLength);
                if (newodm.Precision > -1)
                    strbui.Append(newodm.Precision);
                strbui.Append(") ");
                if (newodm.DefaultValue != "")
                {
                    if (newodm.DataType == "bit")
                        strbui.Append("DEFAULT b'");
                    else
                        strbui.Append("DEFAULT '");
                    strbui.Append(newodm.DefaultValue);
                    strbui.Append("' ");
                }
                if (newodm.IsAllowNull)
                    strbui.Append("NULL");
                else
                    strbui.Append("NOT NULL");
                OperateBySQL(strbui.ToString());
            }
            catch
            {
                ret = false;
            }
            return ret;
        }

        public override string GetDataSetXMLBySQL(string sql)
        {
            DataSet ds = new DataSet();
            OracleConnection.ClearAllPools();
            using (OracleConnection conn = new OracleConnection(base.Connections[base.CurrentConnectionKey].Value.ToString()))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(sql, conn);
                OracleDataAdapter adp = new OracleDataAdapter(cmd);
                adp.Fill(ds);
                ds.Tables[0].TableName = "DefaultTable";
                conn.Close();
            }
            return ActionDTS.GetXMLFromDataSet(ds);
        }

        public override string[] GetOneRecordBySQL(string sql)
        {
            string[] sRet = new string[0];
            OracleConnection.ClearAllPools();
            using (OracleConnection conn = new OracleConnection(base.Connections[base.CurrentConnectionKey].Value.ToString()))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(sql, conn);
                OracleDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    sRet = new string[rdr.FieldCount];
                    for (int i = 0; i < rdr.FieldCount; i++)
                    {
                        sRet[i] = rdr.GetValue(i).ToString();
                    }
                }
                rdr.Close();
                conn.Close();
            }
            return sRet;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fields"></param>
        /// <param name="table"></param>
        /// <param name="where">可自定义where和order等筛选条件，需要引用方加where关键字</param>
        /// <returns></returns>
        public override Dictionary<string, string> GetOneRecordBySQL(string[] fields, string table, string where)
        {
            Dictionary<string, string> dicr = new Dictionary<string, string>();
            string sql = "select ";
            if (fields.Length == 0)
            {
                return dicr;
            }
            else
            {
                if (fields[0].Trim() != "")
                {
                    dicr.Add(fields[0], "");
                    sql += fields[0];
                }
            }
            for (int i = 1; i < fields.Length; i++)
            {
                if (fields[i].Trim() != "")
                {
                    dicr.Add(fields[i], "");
                    sql += "," + fields[i];
                }
            }
            sql += " from " + table + " " + where;
            OracleConnection.ClearAllPools();
            using (OracleConnection conn = new OracleConnection(base.Connections[base.CurrentConnectionKey].Value.ToString()))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(sql, conn);
                OracleDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    for (int i = 0; i < rdr.FieldCount; i++)
                    {
                        dicr[fields[i]] = rdr.GetValue(i).ToString();
                    }
                }
                rdr.Close();
                conn.Close();
            }
            return dicr;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fields"></param>
        /// <param name="table"></param>
        /// <param name="where">可自定义where和order等筛选条件，需要引用方加where关键字</param>
        /// <returns></returns>
        public override Dictionary<string, string> GetOneRecordBySQL(List<string> fields, string table, string where)
        {
            Dictionary<string, string> dicr = new Dictionary<string, string>();
            string sql = "select ";
            if (fields.Count == 0)
            {
                return dicr;
            }
            else
            {
                if (fields[0].Trim() != "")
                {
                    dicr.Add(fields[0], "");
                    sql += fields[0];
                }
            }
            for (int i = 1; i < fields.Count; i++)
            {
                if (fields[i].Trim() != "")
                {
                    dicr.Add(fields[i], "");
                    sql += "," + fields[i];
                }
            }
            sql += " from " + table + " " + where;
            OracleConnection.ClearAllPools();
            using (OracleConnection conn = new OracleConnection(base.Connections[base.CurrentConnectionKey].Value.ToString()))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(sql, conn);
                OracleDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    for (int i = 0; i < rdr.FieldCount; i++)
                    {
                        dicr[fields[i]] = rdr.GetValue(i).ToString();
                    }
                }
                rdr.Close();
                conn.Close();
            }
            return dicr;
        }

        public override DataSet GetDataSetBySQL(string sql)
        {
            DataSet dsRet = new DataSet();
            OracleConnection.ClearAllPools();
            using (OracleConnection conn = new OracleConnection(base.Connections[base.CurrentConnectionKey].Value.ToString()))
            {
                try
                {
                    ExceptionInfo = ""; conn.Open();
                    OracleCommand cmd = new OracleCommand(sql, conn);
                    OracleDataAdapter adp = new OracleDataAdapter(cmd);
                    adp.Fill(dsRet);
                    dsRet.Tables[0].TableName = "DefaultTable";
                }
                catch (Exception ex)
                {
                    ExceptionInfo = ex.Message;
                }
                finally
                {
                    conn.Close();
                }
            }
            return dsRet;
        }

        public override object OpenConnection(string connstr)
        {
            OracleConnection conn = null;
            try
            {
                conn = new OracleConnection(connstr);
                ExceptionInfo = ""; conn.Open();
            }
            catch (Exception ex)
            {
                ExceptionInfo = ex.Message;
            }
            return conn;
        }

        public override void CloseConnection(object connobj)
        {
            if (connobj != null && connobj is OracleConnection)
            {
                OracleConnection conn = connobj as OracleConnection;
                conn.Close();
            }
        }

        public override string[] GetOneRecordBySQLWithConnectionOpen(string sql, object connobj)
        {
            string[] sRet = new string[0];
            if (connobj != null && connobj is OracleConnection)
            {
                OracleConnection conn = connobj as OracleConnection;
                try
                {
                    ExceptionInfo = "";
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    OracleCommand cmd = new OracleCommand(sql, conn);
                    OracleDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        sRet = new string[rdr.FieldCount];
                        for (int i = 0; i < rdr.FieldCount; i++)
                        {
                            sRet[i] = rdr.GetValue(i).ToString();
                        }
                    }
                    rdr.Close();
                }
                catch (Exception ex)
                {
                    ExceptionInfo = ex.Message;
                }
            }
            return sRet;
        }

        public override DataSet GetDataSetBySQLWithConnectionOpen(string sql, object connobj)
        {
            DataSet dsRet = new DataSet();
            if (connobj != null && connobj is OracleConnection)
            {
                OracleConnection conn = connobj as OracleConnection;
                try
                {
                    ExceptionInfo = "";
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    OracleCommand cmd = new OracleCommand(sql, conn);
                    OracleDataAdapter adp = new OracleDataAdapter(cmd);
                    adp.Fill(dsRet);
                }
                catch (Exception ex)
                {
                    ExceptionInfo = ex.Message;
                }
            }
            return dsRet;
        }

        public override int OperateBySQLWithConnectionOpen(string sql, object connobj)
        {
            int iRet = 0;
            if (connobj != null && connobj is OracleConnection)
            {
                OracleConnection conn = connobj as OracleConnection;
                try
                {
                    ExceptionInfo = "";
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    OracleCommand cmd = new OracleCommand(sql, conn);
                    //cmd.CommandTimeout = 0;
                    iRet = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    ExceptionInfo = ex.Message;
                }
            }
            return iRet;
        }


        public override int OperateByMultiSQL(List<ObjectSQL> listsql)
        {
            int iRet = 0;
            OracleConnection.ClearAllPools();
            using (OracleConnection conn = new OracleConnection(base.Connections[base.CurrentConnectionKey].Value.ToString()))
            {
                try
                {
                    Dictionary<string, object> dicparas = new Dictionary<string, object>();
                    ExceptionInfo = ""; conn.Open();
                    OracleDataReader rdr;
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;

                    for (int i = 0; i < listsql.Count; i++)
                    {
                        ObjectSQL sql = listsql[i];
                        cmd.CommandText = sql.SQLText;
                        object o;
                        bool paraok = true;
                        switch (sql.SQLType)
                        {
                            default:
                                break;
                            case SQLType.Read:
                                rdr = cmd.ExecuteReader();
                                for (int j = 0; j < sql.ListInputParaName.Count; j++)
                                {
                                    if (!dicparas.ContainsKey(sql.ListInputParaName[j]))
                                        dicparas.Add(sql.ListInputParaName[j], rdr.GetValue(j));
                                    else
                                        dicparas[sql.ListInputParaName[j]] = rdr.GetValue(j);
                                }
                                rdr.Close();
                                break;
                            case SQLType.Write:
                                cmd.ExecuteNonQuery();
                                break;
                            case SQLType.WriteWithReadParas:
                                for (int j = 0; j < sql.ListInputParaName.Count; j++)
                                {
                                    if (dicparas.ContainsKey(sql.ListInputParaName[j]) && dicparas[sql.ListInputParaName[j]] != null)
                                    {
                                        cmd.Parameters.Add(sql.ListInputParaName[j], dicparas[sql.ListInputParaName[j]]);
                                    }
                                    else
                                    {
                                        paraok = false;
                                        break;
                                    }
                                }
                                if (paraok)
                                    cmd.ExecuteNonQuery();
                                break;
                            case SQLType.WriteWithReturn:
                                o = cmd.ExecuteScalar();
                                if (!dicparas.ContainsKey(sql.ReturnParaName))
                                    dicparas.Add(sql.ReturnParaName, o);
                                else
                                    dicparas[sql.ReturnParaName] = o;
                                break;
                            case SQLType.WriteWithReadParasReturn:
                                for (int j = 0; j < sql.ListInputParaName.Count; j++)
                                {
                                    if (dicparas.ContainsKey(sql.ListInputParaName[j]) && dicparas[sql.ListInputParaName[j]] != null)
                                    {
                                        cmd.Parameters.Add(sql.ListInputParaName[j], dicparas[sql.ListInputParaName[j]]);
                                    }
                                    else
                                    {
                                        paraok = false;
                                        break;
                                    }
                                }
                                if (paraok)
                                {
                                    o = cmd.ExecuteScalar();
                                    if (!dicparas.ContainsKey(sql.ReturnParaName))
                                        dicparas.Add(sql.ReturnParaName, o);
                                    else
                                        dicparas[sql.ReturnParaName] = o;
                                }
                                break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    ExceptionInfo = ex.Message;
                }
                finally
                {
                    conn.Close();
                }
            }
            return iRet;
        }

        public override int OperateByTransaction(string[] arrsql)
        {
            int iRet = 0;
            OracleConnection.ClearAllPools();
            using (OracleConnection conn = new OracleConnection(base.Connections[base.CurrentConnectionKey].Value.ToString()))
            {
                try
                {
                    ExceptionInfo = ""; conn.Open();
                    OracleTransaction vt = conn.BeginTransaction();
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.Transaction = vt;
                    foreach (string sqlstring in arrsql)
                    {
                        if (sqlstring != null)
                        {
                            cmd.CommandText = sqlstring;
                            cmd.ExecuteNonQuery();
                        }
                    }
                    vt.Commit();
                }
                catch (Exception ex)
                {
                    ExceptionInfo = ex.Message;
                }
                finally
                {
                    conn.Close();
                }
            }
            return iRet;
        }

        public override int OperateBySQL(string sql)
        {
            int iRet = 0;
            OracleConnection.ClearAllPools();
            using (OracleConnection conn = new OracleConnection(base.Connections[base.CurrentConnectionKey].Value.ToString()))
            {
                try
                {
                    ExceptionInfo = ""; conn.Open();
                    OracleCommand cmd = new OracleCommand(sql, conn);
                    //cmd.CommandTimeout = 0;
                    iRet = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    ExceptionInfo = ex.Message;
                }
                finally
                {
                    conn.Close();
                }
            }
            return iRet;
        }

        public override long OperateBySQL(string sql, bool needidreturn)
        {
            long iRet = 0;
            OracleConnection.ClearAllPools();
            using (OracleConnection conn = new OracleConnection(base.Connections[base.CurrentConnectionKey].Value.ToString()))
            {
                try
                {
                    ExceptionInfo = ""; conn.Open();
                    OracleCommand cmd = new OracleCommand(sql, conn);
                    //cmd.CommandTimeout = 0;
                    if (needidreturn)
                        iRet = Convert.ToInt64(cmd.ExecuteScalar());
                    else
                        iRet = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    ExceptionInfo = ex.Message;
                }
                finally
                {
                    conn.Close();
                }
            }
            return iRet;
        }

        public override int OperateBySQL(string sql, string[] paranames, object[] paravalues)
        {
            int iRet = 0;
            OracleConnection.ClearAllPools();
            using (OracleConnection conn = new OracleConnection(base.Connections[base.CurrentConnectionKey].Value.ToString()))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(sql, conn);
                //cmd.CommandTimeout = 0;
                for (int i = 0; i < paranames.Length; ++i)
                {
                    cmd.Parameters.Add("@" + paranames[i], paravalues[i]);
                }
                iRet = cmd.ExecuteNonQuery();
                conn.Close();
            }
            return iRet;
        }

        public override int OperateBySQL(string sql, string[] paranames, string[] paravalues)
        {
            int iRet = 0;
            OracleConnection.ClearAllPools();
            using (OracleConnection conn = new OracleConnection(base.Connections[base.CurrentConnectionKey].Value.ToString()))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(sql, conn);
                //cmd.CommandTimeout = 0;
                for (int i = 0; i < paranames.Length; ++i)
                {
                    cmd.Parameters.Add("@" + paranames[i], paravalues[i]);
                }
                iRet = cmd.ExecuteNonQuery();
                conn.Close();
            }
            return iRet;
        }

        public override object GetScalarBySQL(string sql)
        {
            object oRet = null;
            OracleConnection.ClearAllPools();
            using (OracleConnection conn = new OracleConnection(base.Connections[base.CurrentConnectionKey].Value.ToString()))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(sql, conn);
                oRet = cmd.ExecuteScalar();
                conn.Close();
            }
            return oRet;
        }

        public override int OperateBinaryBySQL(string sql, Dictionary<string, byte[]> binaryobjects)
        {
            int iRet = 0;
            OracleConnection.ClearAllPools();
            using (OracleConnection conn = new OracleConnection(base.Connections[base.CurrentConnectionKey].Value.ToString()))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(sql, conn);
                //cmd.CommandTimeout = 0;
                foreach (string key in binaryobjects.Keys)
                {
                    cmd.Parameters.Add(key, SqlDbType.Image).Value = binaryobjects[key];
                }
                iRet = cmd.ExecuteNonQuery();
                conn.Close();
            }
            return iRet;
        }
    }
}