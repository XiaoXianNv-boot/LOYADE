using System;

namespace LOYADE
{
    interface IDataUnderControl
    {
        void ClearData();
        void InitializeData();
        void AppendData();
        void UpdateData();

    }
}
