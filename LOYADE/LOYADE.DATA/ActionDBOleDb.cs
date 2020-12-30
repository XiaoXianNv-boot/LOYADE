using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Text;

namespace LOYADE.DATA
{
    public class ActionDBOleDb : ActionDBSQL
    {
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
            using (OleDbConnection conn = new OleDbConnection(base.Connections[base.CurrentConnectionKey].Value.ToString()))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
                adp.Fill(ds);
                ds.Tables[0].TableName = "DefaultTable";
                conn.Close();
            }
            return ActionDTS.GetXMLFromDataSet(ds);
        }

        public override string[] GetOneRecordBySQL(string sql)
        {
            string[] sRet = new string[0];
            using (OleDbConnection conn = new OleDbConnection(base.Connections[base.CurrentConnectionKey].Value.ToString()))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                OleDbDataReader rdr = cmd.ExecuteReader();
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

        public override DataSet GetDataSetBySQL(string sql)
        {
            DataSet dsRet = new DataSet();
            using (OleDbConnection conn = new OleDbConnection(base.Connections[base.CurrentConnectionKey].Value.ToString()))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
                adp.Fill(dsRet);
                dsRet.Tables[0].TableName = "DefaultTable";
                conn.Close();
            }
            return dsRet;
        }

        public override object OpenConnection(string connstr)
        {
            OleDbConnection conn = null;
            try
            {
                conn = new OleDbConnection(connstr);
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
            if (connobj != null && connobj is OleDbConnection)
            {
                OleDbConnection conn = connobj as OleDbConnection;
                conn.Close();
            }
        }

        public override string[] GetOneRecordBySQLWithConnectionOpen(string sql, object connobj)
        {
            string[] sRet = new string[0];
            if (connobj != null && connobj is OleDbConnection)
            {
                OleDbConnection conn = connobj as OleDbConnection;
                try
                {
                    ExceptionInfo = "";
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    OleDbCommand cmd = new OleDbCommand(sql, conn);
                    OleDbDataReader rdr = cmd.ExecuteReader();
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
            if (connobj != null && connobj is OleDbConnection)
            {
                OleDbConnection conn = connobj as OleDbConnection;
                try
                {
                    ExceptionInfo = "";
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    OleDbCommand cmd = new OleDbCommand(sql, conn);
                    OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
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
            if (connobj != null && connobj is OleDbConnection)
            {
                OleDbConnection conn = connobj as OleDbConnection;
                try
                {
                    ExceptionInfo = "";
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    OleDbCommand cmd = new OleDbCommand(sql, conn);
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

        public override int OperateBySQL(string sql)
        {
            int iRet = 0;
            using (OleDbConnection conn = new OleDbConnection(base.Connections[base.CurrentConnectionKey].Value.ToString()))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                //cmd.CommandTimeout = 0;
                iRet = cmd.ExecuteNonQuery();
                conn.Close();
            }
            return iRet;
        }

        public override int OperateBySQL(string sql, string[] paranames, object[] paravalues)
        {
            int iRet = 0;
            using (OleDbConnection conn = new OleDbConnection(base.Connections[base.CurrentConnectionKey].Value.ToString()))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                //cmd.CommandTimeout = 0;
                for (int i = 0; i < paranames.Length; ++i)
                {
                    cmd.Parameters.AddWithValue("@" + paranames[i], paravalues[i]);
                }
                iRet = cmd.ExecuteNonQuery();
                conn.Close();
            }
            return iRet;
        }

        public override int OperateBySQL(string sql, string[] paranames, string[] paravalues)
        {
            int iRet = 0;
            using (OleDbConnection conn = new OleDbConnection(base.Connections[base.CurrentConnectionKey].Value.ToString()))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                //cmd.CommandTimeout = 0;
                for (int i = 0; i < paranames.Length; ++i)
                {
                    cmd.Parameters.AddWithValue("@" + paranames[i], paravalues[i]);
                }
                iRet = cmd.ExecuteNonQuery();
                conn.Close();
            }
            return iRet;
        }

        public override object GetScalarBySQL(string sql)
        {
            object oRet = null;
            using (OleDbConnection conn = new OleDbConnection(base.Connections[base.CurrentConnectionKey].Value.ToString()))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                oRet = cmd.ExecuteScalar();
                conn.Close();
            }
            return oRet;
        }

    }
}
