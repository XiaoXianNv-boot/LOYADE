using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;
using System.Security.Cryptography;

namespace LOYADE
{
    public class ActionFile
    {
        //调用windows API获取磁盘空闲空间
        //导入库
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        static extern bool GetDiskFreeSpace([MarshalAs(UnmanagedType.LPTStr)]string rootPathName,
        ref int sectorsPerCluster, ref int bytesPerSector, ref int numberOfFreeClusters, ref int totalNumbeOfClusters);
        public ActionFile()
        {

        }

        public static string GetFileString(string file)
        {
            string sret = "";
            try
            {
                StreamReader sr = new StreamReader(file);
                sret = sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception ex)
            {
                sret = "";
            }
            return sret;
        }

        public static string GetFileString(string file, string encode)
        {
            StreamReader sr = new StreamReader(file, ASCIIEncoding.GetEncoding(encode));
            string sret = sr.ReadToEnd();
            sr.Close();
            return sret;
        }

        public static DataSet ConvertXmlToDataSet(string xmlStr, bool hasschema)
        {
            if (!string.IsNullOrEmpty(xmlStr))
            {
                StringReader StrStream = null;
                XmlTextReader Xmlrdr = null;
                try
                {
                    DataSet ds = new DataSet();
                    //读取字符串中的信息 
                    StrStream = new StringReader(xmlStr);
                    //获取StrStream中的数据 
                    Xmlrdr = new XmlTextReader(StrStream);
                    Xmlrdr.WhitespaceHandling = WhitespaceHandling.None;
                    //ds获取Xmlrdr中的数据 
                    if (hasschema)
                        ds.ReadXml(Xmlrdr, XmlReadMode.ReadSchema);
                    else
                        ds.ReadXml(Xmlrdr);
                    return ds;
                }
                catch (System.Exception e)
                {
                    throw e;
                }
                finally
                {
                    //释放资源 
                    if (Xmlrdr != null)
                    {
                        Xmlrdr.Close();
                        StrStream.Close();
                        StrStream.Dispose();
                    }
                }
            }
            else
            {
                return null;
            }
        }

        public static string GetProgramDirectory()
        {
            return AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
        }

        public static DataSet GetFileInfoSetFromDirectory(string dir)
        {
            DataSet dsRet = new DataSet();
            DataTable dt = new DataTable("DefaultTable");
            dt.Columns.Add(new DataColumn("name"));
            dt.Columns.Add(new DataColumn("extention"));
            dt.Columns.Add(new DataColumn("length"));
            dt.Columns.Add(new DataColumn("creationtime"));
            dt.Columns.Add(new DataColumn("lastwritetime"));
            dt.Columns.Add(new DataColumn("fullname"));
            dsRet.Tables.Add(dt);
            string[] arr = Directory.GetFiles(dir);
            foreach (string s in arr)
            {
                FileInfo fi = new FileInfo(s);
                DataRow dr = dt.NewRow();
                dr["name"] = fi.Name;
                dr["extention"] = fi.Extension;
                dr["length"] = fi.Length;
                dr["creationtime"] = fi.CreationTime;
                dr["lastwritetime"] = fi.LastWriteTime;
                dr["fullname"] = fi.FullName;
                dt.Rows.Add(dr);
            }
            return dsRet;
        }

        public static int Level = 0;

        public static void GetDirectoryAndFileInfoSetFromDirectory(string dir, DataTable dt)
        {
            Level++;
            string[] arrfile = Directory.GetFiles(dir);
            foreach (string f in arrfile)
            {
                DataRow dr = dt.NewRow();
                dr["name"] = Path.GetFileName(f);
                dr["fathername"] = dir;
                dr["type"] = "0";
                dr["level"] = Level;
                dr["path"] = f;
                dt.Rows.Add(dr);
            }
            string[] arrdir = Directory.GetDirectories(dir);
            foreach (string d in arrdir)
            {
                DataRow dr = dt.NewRow();
                dr["name"] = d.Remove(0, d.LastIndexOf("\\") + 2);
                dr["fathername"] = dir;
                dr["type"] = "1";
                dr["level"] = Level;
                dr["path"] = d;
                dt.Rows.Add(dr);
                GetDirectoryAndFileInfoSetFromDirectory(d, dt);
            }
        }

        public static void AppendStringToFile(string file, string content, string encodername)
        {
            StreamWriter sw = new StreamWriter(file, true, ASCIIEncoding.GetEncoding(encodername));
            sw.WriteLine(content);
            sw.Close();
        }

        public static void AppendStringToFile(string file, string content)
        {
            StreamWriter sw = new StreamWriter(file, true, ASCIIEncoding.GetEncoding("utf-8"));
            sw.WriteLine(content);
            sw.Close();
        }

        public static void CreateStringFile(string file, string content, string encodername)
        {
            StreamWriter sw = new StreamWriter(file, false, ASCIIEncoding.GetEncoding(encodername));
            sw.Write(content);
            sw.Close();
        }

        public static void CreateStringFile(string file, string content)
        {
            StreamWriter sw = new StreamWriter(file, false, ASCIIEncoding.GetEncoding("utf-8"));
            sw.Write(content);
            sw.Close();
        }

        public static void CreateStringFile(string file, string content, bool isappend)
        {
            try
            {
                string dir = Path.GetDirectoryName(file);
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);
                StreamWriter sw = new StreamWriter(file, isappend, ASCIIEncoding.GetEncoding("utf-8"));
                sw.Write(content);
                sw.Close();
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// 按照内存数据表完整内容生成Excel文件
        /// </summary>
        /// <param name="dt">数据表（.Net的DataTable）</param>
        /// <param name="file">生成Excel文件路径（一般是SaveFileDialog的FileName）</param>
        /// <param name="where">筛选条件</param>
        /// <param name="encodername">编码方式名称（gb2312，utf-8等）</param>
        public static void CreateExcel(DataTable dt, string file, string where, string encodername)
        {
            string colHeaders = "", ls_item = "";
            //定义表对象与行对象，同时用DataSet对其值进行初始化 
            DataRow[] myRow = dt.Select(where);//可以类似dt.Select("id>10")之形式达到数据筛选目的
            int i = 0;
            int cl = dt.Columns.Count;
            //取得数据表各列标题，各标题之间以t分割，最后一个列标题后加回车符 
            for (i = 0; i < cl; i++)
            {
                if (i == (cl - 1))//最后一列，加n
                {
                    colHeaders += dt.Columns[i].Caption.ToString() + "\n";
                }
                else
                {
                    colHeaders += dt.Columns[i].Caption.ToString() + "\t";
                }
            }
            //逐行处理数据   
            foreach (DataRow row in myRow)
            {
                //当前行数据写入HTTP输出流，并且置空ls_item以便下行数据     
                for (i = 0; i < cl; i++)
                {
                    if (i == (cl - 1))//最后一列，加n
                    {
                        ls_item += row[i].ToString() + "\n";
                    }
                    else
                    {
                        ls_item += row[i].ToString() + "\t";
                    }
                }
            }
            StreamWriter sw = new StreamWriter(file, false, ASCIIEncoding.GetEncoding(encodername));
            sw.Write(colHeaders + ls_item);
            sw.Close();
        }

        public static bool CreateCSV(DataTable dt, string file, string encodername)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                foreach (DataColumn dc in dt.Columns)
                {
                    sb.Append(dc.ColumnName);
                    sb.Append(",");
                }
                sb.AppendLine();
                foreach (DataRow dr in dt.Rows)
                {
                    foreach (DataColumn dc in dt.Columns)
                    {
                        sb.Append(dr[dc.ColumnName].ToString());
                        sb.Append(",");
                    }
                    sb.AppendLine();
                }
                StreamWriter sw = new StreamWriter(file, false, ASCIIEncoding.GetEncoding(encodername));
                sw.Write(sb.ToString());
                sw.Flush();
                sw.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static bool CreateCSV(DataTable dt, string file, string encodername, bool ishasheader)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                if (ishasheader)
                {
                    foreach (DataColumn dc in dt.Columns)
                    {
                        sb.Append(dc.ColumnName);
                        sb.Append(",");
                    }
                    sb.AppendLine();
                }
                foreach (DataRow dr in dt.Rows)
                {
                    foreach (DataColumn dc in dt.Columns)
                    {
                        sb.Append(dr[dc.ColumnName].ToString());
                        sb.Append(",");
                    }
                    sb.AppendLine();
                }
                StreamWriter sw = new StreamWriter(file, false, ASCIIEncoding.GetEncoding(encodername));
                sw.Write(sb.ToString());
                sw.Flush();
                sw.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        /// <summary>  
        /// 通过MD5CryptoServiceProvider类中的ComputeHash方法直接传入一个FileStream类实现计算MD5  
        /// 操作简单，代码少，调用即可  
        /// </summary>  
        /// <param name="path">文件地址</param>  
        /// <returns>MD5Hash</returns>  
        public static string GetMD5ByMD5CryptoService(string path)
        {
            if (!File.Exists(path))
                throw new ArgumentException(string.Format("<{0}>, 不存在", path));
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
            MD5CryptoServiceProvider md5Provider = new MD5CryptoServiceProvider();
            byte[] buffer = md5Provider.ComputeHash(fs);
            string resule = BitConverter.ToString(buffer);
            resule = resule.Replace("-", "");
            md5Provider.Clear();
            fs.Close();
            return resule;
        }

        /// <summary>  
        /// 通过HashAlgorithm的TransformBlock方法对流进行叠加运算获得MD5  
        /// 实现稍微复杂，但可使用与传输文件或接收文件时同步计算MD5值  
        /// 可自定义缓冲区大小，计算速度较快  
        /// </summary>  
        /// <param name="path">文件地址</param>  
        /// <returns>MD5Hash</returns>  
        public static string GetMD5ByHashAlgorithm(string path)
        {
            if (!File.Exists(path))
                throw new ArgumentException(string.Format("<{0}>, 不存在", path));
            int bufferSize = 1024 * 16;//自定义缓冲区大小16K  
            byte[] buffer = new byte[bufferSize];
            Stream inputStream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read);
            HashAlgorithm hashAlgorithm = new MD5CryptoServiceProvider();
            int readLength = 0;//每次读取长度  
            var output = new byte[bufferSize];
            while ((readLength = inputStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                //计算MD5  
                hashAlgorithm.TransformBlock(buffer, 0, readLength, output, 0);
            }
            //完成最后计算，必须调用(由于上一部循环已经完成所有运算，所以调用此方法时后面的两个参数都为0)  
            hashAlgorithm.TransformFinalBlock(buffer, 0, 0);
            string md5 = BitConverter.ToString(hashAlgorithm.Hash);
            hashAlgorithm.Clear();
            inputStream.Close();
            md5 = md5.Replace("-", "");
            return md5;
        }

        /// <summary>
        /// 将文件转换成byte[] 数组
        /// </summary>
        /// <param name="fileUrl">文件路径文件名称</param>
        /// <returns>byte[]</returns>
        public static byte[] GetFileData(string fileUrl)
        {
            FileStream fs = new FileStream(fileUrl, FileMode.Open, FileAccess.Read);
            try
            {
                byte[] buffur = new byte[fs.Length];
                fs.Read(buffur, 0, (int)fs.Length);

                return buffur;
            }
            catch (Exception ex)
            {
                //MessageBoxHelper.ShowPrompt(ex.Message);
                return null;
            }
            finally
            {
                if (fs != null)
                {

                    //关闭资源
                    fs.Close();
                }
            }
        }


        /// <summary>
        /// 将文件转换成byte[] 数组
        /// </summary>
        /// <param name="fileUrl">文件路径文件名称</param>
        /// <returns>byte[]</returns> 
        public static byte[] AuthGetFileData(string fileUrl)
        {
            using (FileStream fs = new FileStream(fileUrl, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                byte[] buffur = new byte[fs.Length];
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    bw.Write(buffur);
                    bw.Close();
                }
                return buffur;
            }
        }

        ///   
        /// 获取指定驱动器的空间总大小(单位为GB) 
        ///   
        ///  只需输入代表驱动器的字母即可 （大写） 
        ///    
        public static decimal GetHardDiskSpace(string str_HardDiskName)
        {
            decimal totalSize = 0;
            str_HardDiskName = str_HardDiskName + ":\\";
            System.IO.DriveInfo[] drives = System.IO.DriveInfo.GetDrives();
            foreach (System.IO.DriveInfo drive in drives)
            {
                if (drive.Name == str_HardDiskName)
                {
                    totalSize = Convert.ToDecimal(drive.TotalSize) / (1024 * 1024 * 1024);
                }
            }
            return totalSize;
        }

        ///   
        /// 获取指定驱动器的剩余空间总大小(单位为GB) 
        ///   
        ///  只需输入代表驱动器的字母即可  
        ///    
        public static decimal GetHardDiskFreeSpace(string str_HardDiskName)
        {
            decimal freeSpace = 0;
            str_HardDiskName = str_HardDiskName + ":\\";
            System.IO.DriveInfo[] drives = System.IO.DriveInfo.GetDrives();
            foreach (System.IO.DriveInfo drive in drives)
            {
                if (drive.Name == str_HardDiskName)
                {
                    freeSpace = Convert.ToDecimal(drive.TotalFreeSpace) / (1024 * 1024 * 1024);
                }
            }
            return freeSpace;
        }

        /// <summary>
        /// 获取指定路径的占用空间
        /// </summary>
        /// <param name="dirPath">路径</param>
        /// <returns></returns>
        public static decimal GetDirectorySpace(string dirPath)
        {
            //返回值
            decimal len = 0;
            //判断该路径是否存在（是否为文件夹）
            if (!Directory.Exists(dirPath))
            {
                //如果是文件，则调用
                len = FileSpace(dirPath);
            }
            else
            {
                //定义一个DirectoryInfo对象
                DirectoryInfo di = new DirectoryInfo(dirPath);
                //本机的簇值
                decimal clusterSize = GetClusterSize(di);
                //遍历目录下的文件，获取总占用空间
                foreach (FileInfo fi in di.GetFiles())
                {
                    //文件大小除以簇，余若不为0
                    if (fi.Length % clusterSize != 0)
                    {
                        decimal res = fi.Length / clusterSize;
                        //文件大小除以簇，取整数加1。为该文件占用簇的值
                        int clu = Convert.ToInt32(Math.Ceiling(res)) + 1;
                        decimal result = clusterSize * clu;
                        len += result;
                    }
                    else
                    {
                        //余若为0，则占用空间等于文件大小
                        len += fi.Length;
                    }
                }
                //获取di中所有的文件夹，并存到一个新的对象数组中，以进行递归
                DirectoryInfo[] dis = di.GetDirectories();
                if (dis.Length > 0)
                {
                    for (int i = 0; i < dis.Length; i++)
                    {
                        len += GetDirectorySpace(dis[i].FullName);
                    }
                }
            }
            return len;
        }

        /// <summary>
        /// 获取指定路径的大小
        /// </summary>
        /// <param name="dirPath">路径</param>
        /// <returns></returns>
        public static decimal GetDirectoryLength(string dirPath)
        {
            decimal len = 0;
            //判断该路径是否存在（是否为文件夹）
            if (!Directory.Exists(dirPath))
            {
                //查询文件的大小
                len = FileSize(dirPath);
            }
            else
            {
                //定义一个DirectoryInfo对象
                DirectoryInfo di = new DirectoryInfo(dirPath);

                //通过GetFiles方法，获取di目录中的所有文件的大小
                foreach (FileInfo fi in di.GetFiles())
                {
                    len += fi.Length;
                }
                //获取di中所有的文件夹，并存到一个新的对象数组中，以进行递归
                DirectoryInfo[] dis = di.GetDirectories();
                if (dis.Length > 0)
                {
                    for (int i = 0; i < dis.Length; i++)
                    {
                        len += GetDirectoryLength(dis[i].FullName);
                    }
                }
            }
            return len;
        }


        //所给路径中所对应的文件大小
        public static decimal FileSize(string filePath)
        {
            //定义一个FileInfo对象，是指与filePath所指向的文件相关联，以获取其大小
            FileInfo fileInfo = new FileInfo(filePath);
            return fileInfo.Length;
        }

        //所给路径中所对应的文件占用空间
        public static decimal FileSpace(string filePath)
        {
            decimal temp = 0;
            //定义一个FileInfo对象，是指与filePath所指向的文件相关联，以获取其大小
            FileInfo fileInfo = new FileInfo(filePath);
            decimal clusterSize = GetClusterSize(fileInfo);
            if (fileInfo.Length % clusterSize != 0)
            {
                decimal res = fileInfo.Length / clusterSize;
                int clu = Convert.ToInt32(Math.Ceiling(res)) + 1;
                temp = clusterSize * clu;
            }
            else
            {
                return fileInfo.Length;
            }
            return temp;
        }

        /// <summary>
        /// 获取每簇的字节
        /// </summary>
        /// <param name="file">指定文件</param>
        /// <returns></returns>
        public static decimal GetClusterSize(FileInfo file)
        {
            decimal clusterSize = 0;
            DiskInfo diskInfo = new DiskInfo();
            diskInfo = GetDiskInfo(file.Directory.Root.FullName);
            clusterSize = (diskInfo.BytesPerSector * diskInfo.SectorsPerCluster);
            return clusterSize;
        }

        /// <summary>
        /// 获取每簇的字节
        /// </summary>
        /// <param name="dir">指定目录</param>
        /// <returns></returns>
        public static decimal GetClusterSize(DirectoryInfo dir)
        {
            decimal clusterSize = 0;
            DiskInfo diskInfo = new DiskInfo();
            diskInfo = GetDiskInfo(dir.Root.FullName);
            clusterSize = (diskInfo.BytesPerSector * diskInfo.SectorsPerCluster);
            return clusterSize;
        }

        public static DiskInfo GetDiskInfo(string rootPathName)
        {
            DiskInfo diskInfo = new DiskInfo();
            int sectorsPerCluster = 0, bytesPerSector = 0, numberOfFreeClusters = 0, totalNumberOfClusters = 0;
            GetDiskFreeSpace(rootPathName, ref sectorsPerCluster, ref bytesPerSector, ref numberOfFreeClusters, ref totalNumberOfClusters);

            //每簇的扇区数
            diskInfo.SectorsPerCluster = sectorsPerCluster;
            //每扇区字节
            diskInfo.BytesPerSector = bytesPerSector;

            return diskInfo;
        }


        //// <summary>
        /// 结构。硬盘信息
        /// </summary>
        public struct DiskInfo
        {
            public string RootPathName;
            //每簇的扇区数
            public int SectorsPerCluster;
            //每扇区字节
            public int BytesPerSector;
            public int NumberOfFreeClusters;
            public int TotalNumberOfClusters;
        }
    }
}
