using System.ComponentModel;

namespace Win.LOYADE.MSSQL
{
    public class _DBConnection
    {
        public _DBConnection(string id)
        {
            this.ID = id;
        }

        [
            Category("只读信息"),
            ReadOnly(true),
        ]
        public string ID { get; set; }

        [
            Category("基本连接"), 
            ReadOnly(false),
        ]
        public string DataSource { get; set; }

        [
            Category("基本连接"), 
            ReadOnly(false),
        ]
        public string UserID { get; set; }

        [
            Category("基本连接"), 
            ReadOnly(false),
        ]
        public string Password { get; set; }

        [
            Category("个性设置"), 
            ReadOnly(false),
        ]
        public string DefaultDatabase { get; set; }
    }
}
