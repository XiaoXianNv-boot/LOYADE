using LOYADE.DATA;
using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace Win.LOYADE.MSSQL
{
    public partial class formMain : Form
    {
        private Thread _tcopy;
        private int _copytype = 0;
        private bool _startcopy = false;

        private _DBConnection _dba = new _DBConnection("A");
        private _DBConnection _dbb = new _DBConnection("B");

        public formMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            _dba.DataSource = "DESKTOP-32DAU5B";
            _dba.UserID = "sa";
            _dba.Password = "xiaole";
            _dba.DefaultDatabase = "EEAIT_COMMON";
            _dbb.DataSource = "DESKTOP-32DAU5B";
            _dbb.UserID = "sa";
            _dbb.Password = "xiaole";
            _dbb.DefaultDatabase = "test1";
            propertyGridA.SelectedObject = _dba;
            propertyGridB.SelectedObject = _dbb;
        }

        private void tsbCopySchema_Click(object sender, EventArgs e)
        {
            tsbCopySchema.Enabled = false;
            tsbCopyData.Enabled = false;
            tsbCopyAll.Enabled = false;
            _copytype = 1;
            _startcopy = true;
            _tcopy = new Thread(new ThreadStart(TCopy));
            textBoxReport.Text = "开始将A库的架构同步复制给B库...\r\n";
            textBoxError.Text = "";
            _tcopy.IsBackground = true;
            _tcopy.Start();
        }

        private void TCopy()
        {
            int ok_table_count = 0;
            int ok_column_count = 0;
            int ok_row_count = 0;
            int error_column_count = 0;
            int error_row_count = 0;
            string sqlcopy = "";

            try
            {
                //架构和全部都要架构
                if (_copytype == 1 || _copytype == 3)
                {
                    //------------------------表--------------------------
                    string sql = @"SELECT SysObjects.name AS table_name FROM sysobjects WHERE xtype = 'U'";
                    //A
                    ActionDBSQL adbsa = ActionDBSQL.GetInstance(ServiceType.MSSQL);
                    adbsa.UseDynamicConnection("DBA",
                                   _dba.DataSource,
                                   _dba.UserID,
                                   _dba.Password,
                                   _dba.DefaultDatabase);
                    DataSet dsatable = adbsa.GetDataSetBySQL(sql);
                    sql = @"SELECT 
table_name,column_name,column_default,is_nullable,data_type,ordinal_position,
character_maximum_length,numeric_precision,numeric_scale,datetime_precision
FROM information_schema.columns 
WHERE NOT table_name IN('sysdiagrams','dtproperties') ORDER BY table_name,ordinal_position";
                    DataSet dsacolumn = adbsa.GetDataSetBySQL(sql);
                    if (dsatable != null && dsatable.Tables.Count == 1 && dsacolumn != null && dsacolumn.Tables.Count == 1)
                    {
                        this.Invoke((EventHandler)delegate
                        {
                            textBoxReport.Text += "A库连接成功！找到" + dsatable.Tables[0].Rows.Count + "个数据表\r\n";
                        });
                    }
                    else
                    {
                        this.Invoke((EventHandler)delegate
                        {
                            textBoxReport.Text += "A库连接失败！\r\n";
                        });
                    }
                    //B
                    sql = @"SELECT SysObjects.name AS table_name FROM sysobjects WHERE xtype = 'U'";
                    ActionDBSQL adbsb = ActionDBSQL.GetInstance(ServiceType.MSSQL);
                    adbsb.UseDynamicConnection("DBB",
                                   _dbb.DataSource,
                                   _dbb.UserID,
                                   _dbb.Password,
                                   _dbb.DefaultDatabase);
                    DataSet dsbtable = adbsb.GetDataSetBySQL(sql);
                    sql = @"SELECT 
table_name,column_name,column_default,is_nullable,data_type,ordinal_position,
character_maximum_length,numeric_precision,numeric_scale,datetime_precision
FROM information_schema.columns 
WHERE NOT table_name IN('sysdiagrams','dtproperties') ORDER BY table_name,ordinal_position";
                    DataSet dsbcolumn = adbsb.GetDataSetBySQL(sql);
                    if (dsbtable != null && dsbtable.Tables.Count == 1 && dsbcolumn != null && dsbcolumn.Tables.Count == 1)
                    {
                        this.Invoke((EventHandler)delegate
                        {
                            textBoxReport.Text += "B库连接成功！找到" + dsbtable.Tables[0].Rows.Count + "个数据表\r\n";
                        });
                    }
                    else
                    {
                        this.Invoke((EventHandler)delegate
                        {
                            textBoxReport.Text += "B库连接失败！\r\n";
                        });
                    }
                    //比对，从A库取出逐个表
                    foreach (DataRow dra in dsatable.Tables[0].Rows)
                    {
                        //对应A库的每个表，尝试找寻B库对应的表
                        DataRow[] drtbs = dsbtable.Tables[0].Select("table_name='" + dra["table_name"] + "'");
                        ok_column_count = 0;
                        error_column_count = 0;
                        //判断是否存在表名，找到的话，开始遍历A库中该表的字段描述
                        if (drtbs.Length == 1)
                        {
                            this.Invoke((EventHandler)delegate
                            {
                                textBoxReport.Text += "A、B库表名" + dra["table_name"] + "匹配成功，开始检测字段！\r\n";
                            });
                            DataRow[] drs = dsacolumn.Tables[0].Select("table_name='" + dra["table_name"] + "'", "ordinal_position");
                            for (int i = 0; i < drs.Length; i++)
                            {
                                DataRow drac = drs[i];
                                DataRow[] drcbs = dsbcolumn.Tables[0].Select("table_name='" + dra["table_name"] + "' and column_name='" + drac["column_name"] + "'");
                                //判断是否存在列名
                                if (drcbs.Length == 1)
                                {
                                    //如果内容一致，放过
                                    if (drcbs[0]["column_default"].ToString() == drac["column_default"].ToString() &&
                                        drcbs[0]["is_nullable"].ToString() == drac["is_nullable"].ToString() &&
                                        drcbs[0]["data_type"].ToString() == drac["data_type"].ToString() &&
                                        drcbs[0]["character_maximum_length"].ToString() == drac["character_maximum_length"].ToString() &&
                                        drcbs[0]["numeric_precision"].ToString() == drac["numeric_precision"].ToString() &&
                                        drcbs[0]["numeric_scale"].ToString() == drac["numeric_scale"].ToString() &&
                                        drcbs[0]["datetime_precision"].ToString() == drac["datetime_precision"].ToString())
                                    {
                                        ok_column_count++;
                                    }
                                    else
                                    {
                                        //字段描述内容不一致，则质疑不处理，不要修正字段，以免数据丢失
                                        this.Invoke((EventHandler)delegate
                                        {
                                            textBoxError.Text += "发现A、B库的" + dra["table_name"] + "表" + drac["column_name"] + "字段描述不一致！\r\n";
                                        });
                                        error_column_count++;
                                    }
                                }
                                else
                                {
                                    //添加列
                                    sqlcopy += "ALTER TABLE " + dra["table_name"] + " ADD [" + drac["column_name"] + "] [" + drac["data_type"] + "] ";
                                    if (drac["data_type"].ToString() == "decimal")
                                    {
                                        sqlcopy += "(" + drac["numeric_precision"] + ", " + drac["numeric_scale"] + ") ";
                                    }
                                    else if (drac["data_type"].ToString() == "nvarchar")
                                    {
                                        sqlcopy += "(" + drac["character_maximum_length"] + ") ";
                                    }

                                    if (drac["is_nullable"].ToString() == "YES")
                                    {
                                        sqlcopy += "NULL ";
                                    }
                                    else
                                    {
                                        sqlcopy += "NOT NULL ";
                                    }

                                    if (drac["column_default"] != null && drac["column_default"].ToString() != "NULL" && drac["column_default"].ToString() != "")
                                    {
                                        sqlcopy += "DEFAULT " + drac["column_default"].ToString();
                                    }
                                    sqlcopy += ";";
                                    ok_column_count++;
                                }
                            }
                            this.Invoke((EventHandler)delegate
                            {
                                textBoxReport.Text += "A、B库表名" + dra["table_name"] + "匹配成功，结束字段检测：" + ok_column_count + "个字段匹配完成，" + error_column_count + "个字段匹配失败！\r\n";
                            });
                        }
                        else
                        {
                            //创建create
                            this.Invoke((EventHandler)delegate
                            {
                                textBoxReport.Text += "A库表名" + dra["table_name"] + "不存在于B库，开始创建添加！\r\n";
                            });
                            sqlcopy += @"CREATE TABLE [" + dra["table_name"] + @"](
[id] [bigint] IDENTITY(1,1) NOT NULL,
[sn] [nvarchar](50) NOT NULL,
";
                            DataRow[] drs = dsacolumn.Tables[0].Select("table_name='" + dra["table_name"] + "' and column_name<>'id' and column_name<>'sn'", "ordinal_position");
                            for (int i = 0; i < drs.Length; i++)
                            {
                                DataRow drac = drs[i];

                                sqlcopy += "[" + drac["column_name"] + "] [" + drac["data_type"] + "] ";

                                if (drac["data_type"].ToString() == "decimal")
                                {
                                    sqlcopy += "(" + drac["numeric_precision"] + ", " + drac["numeric_scale"] + ") ";
                                }
                                else if (drac["data_type"].ToString() == "nvarchar")
                                {
                                    sqlcopy += "(" + drac["character_maximum_length"] + ") ";
                                }

                                if (drac["is_nullable"].ToString() == "YES")
                                {
                                    sqlcopy += "NULL ";
                                }
                                else
                                {
                                    sqlcopy += "NOT NULL ";
                                }

                                if (drac["column_default"] != null && drac["column_default"].ToString() != "NULL" && drac["column_default"].ToString() != "")
                                {
                                    sqlcopy += "DEFAULT " + drac["column_default"].ToString();
                                }
                                sqlcopy += ", ";
                            }
                            sqlcopy += @"PRIMARY KEY ([sn])
);";
                        }
                    }
                    int exec = adbsb.OperateBySQL(sqlcopy);

                    //------------------------视图--------------------------
                    sql = "select o.name,c.colid,c.text from sys.objects o,syscomments c where o.object_id = c.id and o.type='v' order by o.name, c.colid";
                    dsatable = adbsa.GetDataSetBySQL(sql);
                    string sqlclear = "";
                    string vname = "", temp = "";
                    if (dsatable != null && dsatable.Tables.Count == 1)
                    {
                        sqlcopy = "";
                        for (int i = 0; i < dsatable.Tables[0].Rows.Count; i++)
                        {
                            DataRow dr = dsatable.Tables[0].Rows[i];
                            temp = dr["name"].ToString();
                            if (vname != temp)
                            {
                                sqlclear = "IF EXISTS (SELECT * FROM sysobjects WHERE name='" + temp + "') DROP VIEW " + temp;
                                exec = adbsb.OperateBySQL(sqlclear);
                                if (vname != "")
                                {
                                    exec = adbsb.OperateBySQL(sqlcopy);
                                }
                                sqlcopy = dr["text"].ToString();
                                vname = temp;
                            }
                            else
                            {
                                sqlcopy += dr["text"].ToString();
                            }
                        }
                        exec = adbsb.OperateBySQL(sqlcopy);
                        this.Invoke((EventHandler)delegate
                        {
                            textBoxReport.Text += "从A库向B库覆盖式同步复制视图" + dsatable.Tables[0].Rows.Count + "项！\r\n";
                        });
                    }
                }
                //数据和全部都要数据
                if (_copytype == 2 || _copytype == 3)
                {

                }
            }
            catch (Exception ex)
            {
                this.Invoke((EventHandler)delegate
                {
                    textBoxReport.Text += "致命错误终止操作！" + ex.Message + "\r\n";
                });
            }
            this.Invoke((EventHandler)delegate
            {
                tsbCopySchema.Enabled = true;
                tsbCopyData.Enabled = true;
                tsbCopyAll.Enabled = true;
                textBoxReport.Text += "从A库到B库的架构同步复制已完成！\r\n";
            });
        }

        private void tsbCopyData_Click(object sender, EventArgs e)
        {
            _copytype = 2;
            tsbCopySchema.Enabled = false;
            tsbCopyData.Enabled = false;
            tsbCopyAll.Enabled = false;
        }

        private void tsbCopyAll_Click(object sender, EventArgs e)
        {
            _copytype = 3;
            tsbCopySchema.Enabled = false;
            tsbCopyData.Enabled = false;
            tsbCopyAll.Enabled = false;
        }

        private void tsbCopyInfo_Click(object sender, EventArgs e)
        {
            _dbb.DataSource = _dba.DataSource;
            _dbb.UserID = _dba.UserID;
            _dbb.Password = _dba.Password;
            propertyGridB.Refresh();
        }
    }
}
