using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LOYADE.DATA.REALTIME
{
    public enum VariableType
    {
        Bit = 0,//1位
        Byte = 1,//1字节，8位
        Word = 2,//2字节，16位
        DWord = 3,//4字节，32位
        Float = 4,//4字节，32位
        Double = 5,//8字节，64位
        ASCII = 6,
    }
}
