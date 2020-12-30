using System;
using System.Collections.Generic;
using System.Text;

namespace LOYADE.MATH
{
    public class XIntegralCurveLength : XIntegral
    {
        public override double Func(double x)
        {
            double r = 0, temp = 0;
            if (ListA.Count > 0)
            {
                r = ListA[0];
                for (int i = 1; i < ListA.Count; ++i)
                {
                    temp = ListA[i];
                    for (int j = ListA.Count - i; j < ListA.Count; ++j)
                    {
                        temp *= x;
                    }
                    r += temp;
                }
            }
            //曲线求弧长的积分函数=在导函数基础上平方+1再开平方
            return Math.Sqrt(r * r + 1);
        }
    }
}
