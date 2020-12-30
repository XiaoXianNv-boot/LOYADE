using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LOYADE
{
    public abstract class ObjectDataAdpter
    {
        protected DataRow _drdata;

        public virtual void SetDataRowToObject(DataRow dr)
        {
            _drdata = dr;
        }

        public virtual void AddNewObjectToDataTable(DataTable dt)
        {
            _drdata = dt.NewRow();
            dt.Rows.Add(_drdata);
        }

        public abstract void GenerateDataTableColumns(DataTable dt);

        public virtual void WriteObjectData(string datasetname, string file, DataTable dt)
        {
            DataSet ds = new DataSet(datasetname);
            ds.Tables.Add(dt);
            ds.WriteXml(file, XmlWriteMode.WriteSchema);
        }

    }
}
