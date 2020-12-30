using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web.Script.Serialization;
using CompressDataSet;

namespace LOYADE.DATA
{
    public class ActionDTS
    {
        /// <summary>    
        /// DataTable转换为Json（序列化方式）   
        /// </summary>    
        /// <param name="dt">DataTable对象</param>   
        /// <returns>Json字符串</returns>    
        public static string GetJsonFromDataTableBySerializer(DataTable dt)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            System.Collections.ArrayList dic = new System.Collections.ArrayList();
            foreach (DataRow dr in dt.Rows)
            {
                Dictionary<string, object> drow = new Dictionary<string, object>();
                foreach (DataColumn dc in dt.Columns)
                {
                    drow.Add(dc.ColumnName, dr[dc.ColumnName]);
                }
                dic.Add(drow);
            }
            //序列化  
            return jss.Serialize(dic);
        }

        /// <summary>    
        /// DataSet转换为Json   
        /// </summary>    
        /// <param name="dataSet">DataSet对象</param>   
        /// <returns>Json字符串</returns>    
        public static string GetJsonFromDataSet(DataSet dataSet)
        {
            string jsonString = "{";
            foreach (DataTable table in dataSet.Tables)
            {
                jsonString += "\"" + table.TableName + "\":" + GetJsonFromDataTable(table) + ",";
            }
            jsonString = jsonString.TrimEnd(',');
            return jsonString + "}";
        }

        /// <summary>     
        /// Datatable转换为Json     
        /// </summary>    
        /// <param name="table">Datatable对象</param>     
        /// <returns>Json字符串</returns>     
        public static string GetJsonFromDataTable(DataTable dt)
        {
            StringBuilder jsonString = new StringBuilder();
            jsonString.Append("[");
            DataRowCollection drc = dt.Rows;
            for (int i = 0; i < drc.Count; i++)
            {
                jsonString.Append("{");
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    string strKey = dt.Columns[j].ColumnName;
                    string strValue = drc[i][j].ToString();

                    Type type = dt.Columns[j].DataType;
                    jsonString.Append("\"");
                    jsonString.Append(strKey);
                    jsonString.Append("\":");
                    strValue = String.Format(strValue, type);
                    jsonString.Append("\"");
                    jsonString.Append(strValue);
                    jsonString.Append("\"");
                    if (j < dt.Columns.Count - 1)
                    {
                        jsonString.Append(",");
                    }
                }
                jsonString.Append("},");
            }
            jsonString.Remove(jsonString.Length - 1, 1);
            jsonString.Append("]");
            return jsonString.ToString();
        }

        public static string GetXMLFromDataSet(DataSet ds)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<NewDataSet>");
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                sb.Append("<DefaultTable ");
                foreach (DataColumn dc in ds.Tables[0].Columns)
                {
                    sb.Append(dc.ColumnName + "=\"" + dr[dc.ColumnName].ToString() + "\" ");
                }
                sb.Append("/>");
            }
            sb.Append("</NewDataSet>");
            return sb.ToString();
        }

        /// <summary>
        /// 序列化转化为二进制数组的DataSet
        /// </summary>
        /// <param name="DS"></param>
        /// <returns></returns>
        public static byte[] GetZipBytesByDataSetSurrogate(DataSet ds)
        {
            DataSetSurrogate dss = new DataSetSurrogate(ds);
            ///二进制方式方式序列化
            BinaryFormatter ser = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            ser.Serialize(ms, dss);
            byte[] buffer = ms.ToArray();
            ///调用压缩方法
            byte[] zipbuffer = Compress(buffer);
            return zipbuffer;
        }

        /// <summary>
        /// 压缩二进制文件
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static byte[] Compress(byte[] data)
        {
            MemoryStream ms = new MemoryStream();
            Stream zipstream = null;
            zipstream = new GZipStream(ms, CompressionMode.Compress, true);
            ///从指定的字节数组中将压缩的字节写入基础流
            zipstream.Write(data, 0, data.Length);
            zipstream.Close();
            ms.Position = 0;
            byte[] compresseddata = new byte[ms.Length];
            ms.Read(compresseddata, 0, int.Parse(ms.Length.ToString()));
            return compresseddata;
        }

        /// <summary>
        /// 将压缩后的二进制数组解压
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static byte[] Decompress(byte[] data)
        {     
            ///data参数为压缩后的二进制数组
            try
            {
                MemoryStream ms = new MemoryStream(data);
                Stream zipstream = null;
                zipstream = new GZipStream(ms, CompressionMode.Decompress);
                byte[] dcdata = null;
                dcdata = ExtractBytesFormStream(zipstream, data.Length);
                return dcdata;
                ///返回解压后的二进制数组
            }
            catch
            {
                return null;
            }
        }

        public static byte[] ExtractBytesFormStream(Stream zipstream, int datablock)
        {
            try
            {
                byte[] data = null;
                int totalBytesRead = 0;
                while (true)
                {
                    Array.Resize(ref data, totalBytesRead + datablock + 1);
                    int bytesRead = zipstream.Read(data, totalBytesRead, datablock);
                    if (bytesRead == 0)
                    {
                        break;
                    }
                    totalBytesRead += bytesRead;
                }
                Array.Resize(ref data, totalBytesRead);
                return data;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 将压缩的二进制文件反序列化后转化为DataSet
        /// </summary>
        /// <param name="zipbyte"></param>
        /// <returns></returns>
        public static DataSet GetDataSetFromZipBytes(byte[] zipbyte)
        {
            byte[] buffer = Decompress(zipbyte);
            BinaryFormatter ser = new BinaryFormatter();
            DataSetSurrogate dss;
            dss = (DataSetSurrogate)ser.Deserialize(new MemoryStream(buffer));
            DataSet ds = dss.ConvertToDataSet();
            return ds;

        }

        public static Type SqlType2CSharpType(SqlDbType sqlType)
        {
            switch (sqlType)
            {
                case SqlDbType.BigInt:
                    return typeof(Int64);
                case SqlDbType.Binary:
                    return typeof(Object);
                case SqlDbType.Bit:
                    return typeof(Boolean);
                case SqlDbType.Char:
                    return typeof(String);
                case SqlDbType.DateTime:
                    return typeof(DateTime);
                case SqlDbType.Decimal:
                    return typeof(Decimal);
                case SqlDbType.Float:
                    return typeof(Double);
                case SqlDbType.Image:
                    return typeof(Object);
                case SqlDbType.Int:
                    return typeof(Int32);
                case SqlDbType.Money:
                    return typeof(Decimal);
                case SqlDbType.NChar:
                    return typeof(String);
                case SqlDbType.NText:
                    return typeof(String);
                case SqlDbType.NVarChar:
                    return typeof(String);
                case SqlDbType.Real:
                    return typeof(Single);
                case SqlDbType.SmallDateTime:
                    return typeof(DateTime);
                case SqlDbType.SmallInt:
                    return typeof(Int16);
                case SqlDbType.SmallMoney:
                    return typeof(Decimal);
                case SqlDbType.Text:
                    return typeof(String);
                case SqlDbType.Timestamp:
                    return typeof(Object);
                case SqlDbType.TinyInt:
                    return typeof(Byte);
                case SqlDbType.Udt://自定义的数据类型
                    return typeof(Object);
                case SqlDbType.UniqueIdentifier:
                    return typeof(Object);
                case SqlDbType.VarBinary:
                    return typeof(Object);
                case SqlDbType.VarChar:
                    return typeof(String);
                case SqlDbType.Variant:
                    return typeof(Object);
                case SqlDbType.Xml:
                    return typeof(Object);
                default:
                    return null;
            }
        }

        // sql server数据类型（如：varchar）
        // 转换为SqlDbType类型
        public static SqlDbType SqlTypeString2SqlType(string sqlTypeString)
        {
            SqlDbType dbType = SqlDbType.Variant;//默认为Object

            switch (sqlTypeString)
            {
                case "int":
                    dbType = SqlDbType.Int;
                    break;
                case "varchar":
                    dbType = SqlDbType.VarChar;
                    break;
                case "bit":
                    dbType = SqlDbType.Bit;
                    break;
                case "datetime":
                    dbType = SqlDbType.DateTime;
                    break;
                case "decimal":
                    dbType = SqlDbType.Decimal;
                    break;
                case "float":
                    dbType = SqlDbType.Float;
                    break;
                case "image":
                    dbType = SqlDbType.Image;
                    break;
                case "money":
                    dbType = SqlDbType.Money;
                    break;
                case "ntext":
                    dbType = SqlDbType.NText;
                    break;
                case "nvarchar":
                    dbType = SqlDbType.NVarChar;
                    break;
                case "smalldatetime":
                    dbType = SqlDbType.SmallDateTime;
                    break;
                case "smallint":
                    dbType = SqlDbType.SmallInt;
                    break;
                case "text":
                    dbType = SqlDbType.Text;
                    break;
                case "bigint":
                    dbType = SqlDbType.BigInt;
                    break;
                case "binary":
                    dbType = SqlDbType.Binary;
                    break;
                case "char":
                    dbType = SqlDbType.Char;
                    break;
                case "nchar":
                    dbType = SqlDbType.NChar;
                    break;
                case "numeric":
                    dbType = SqlDbType.Decimal;
                    break;
                case "real":
                    dbType = SqlDbType.Real;
                    break;
                case "smallmoney":
                    dbType = SqlDbType.SmallMoney;
                    break;
                case "sql_variant":
                    dbType = SqlDbType.Variant;
                    break;
                case "timestamp":
                    dbType = SqlDbType.Timestamp;
                    break;
                case "tinyint":
                    dbType = SqlDbType.TinyInt;
                    break;
                case "uniqueidentifier":
                    dbType = SqlDbType.UniqueIdentifier;
                    break;
                case "varbinary":
                    dbType = SqlDbType.VarBinary;
                    break;
                case "xml":
                    dbType = SqlDbType.Xml;
                    break;
            }
            return dbType;
        }

        public static string CSharpTypeString2SqlTypeString(string csTypeString)
        {
            string dbType = SqlDbType.Variant.ToString();

            switch (csTypeString)
            {
                case "Int":
                    dbType = SqlDbType.Int.ToString();
                    break;
                case "String":
                    dbType = SqlDbType.VarChar.ToString();
                    break;
                case "Bool":
                    dbType = SqlDbType.Bit.ToString();
                    break;
                case "DateTime":
                    dbType = SqlDbType.DateTime.ToString();
                    break;
                case "Decimal":
                    dbType = SqlDbType.Decimal.ToString();
                    break;
                case "Float":
                    dbType = SqlDbType.Float.ToString();
                    break;
                case "Image":
                    dbType = SqlDbType.Image.ToString();
                    break;
                case "Text":
                    dbType = SqlDbType.Text.ToString();
                    break;
                case "Bigint":
                    dbType = SqlDbType.BigInt.ToString();
                    break;
            }
            return dbType;
        }
    }
}
