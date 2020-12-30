using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LOYADE.DATA
{
    public class ObjectSQL
    {
        public ObjectSQL()
        {

        }

        public ObjectSQL(SQLType type, string text)
        {
            SQLType = type;
            SQLText = text;
        }

        public ObjectSQL(SQLType type, string text, List<string> paras)
        {
            SQLType = type;
            SQLText = text;
            ListInputParaName = paras;
        }

        public ObjectSQL(SQLType type, string text, List<string> paras, string returnname)
        {
            SQLType = type;
            SQLText = text;
            ListInputParaName = paras;
            ReturnParaName = returnname;
        }

        public string ReturnParaName;
        public List<string> ListInputParaName;
        public string SQLText;
        public SQLType SQLType;
    }
}
