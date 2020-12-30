using System;

namespace LOYADE.DATA
{
    public enum ServiceType
    {
        MSSQL = 1,
        MySQL = 2,
        Oracle = 3,
        OleDb = 4,
        SQLite = 5,
    }

    public enum VerifyMode
    {
        DatabaseServer = 1,
        OperatingSystem = 2,
    }

    public enum DataSource
    {
        ERP = 1,
        OperatingSystem = 2,
    }

    public enum SQLType
    {
        Read = 1,
        Write = 2,
        WriteWithReadParas = 3,
        WriteWithReturn = 4,
        WriteWithReadParasReturn = 5,
    }
}
