using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LOYADE.DATA.REALTIME
{
    public class DataTableProvider
    {
        public DataTableProvider()
        {

        }

        public static decimal Sum(DataTable dt, string field, string filter)
        {
            decimal dret= 0;
            decimal temp = 0;
            DataRow[] drs = dt.Select(filter);
            foreach(DataRow dr in drs)
            {
                if(decimal.TryParse(dr[field].ToString(),out temp))
                {
                    dret += temp;
                }
            }
            return dret;
        }
    }
}
