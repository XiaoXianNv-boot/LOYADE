using System;
using System.Collections.Generic;
using System.Text;

namespace LOYADE.MATH
{
    public class XIntegralCurveLengthCyindricalSurface : XIntegral
    {
        public override double Func(double x)
        {
            double r = 0;
            //圆柱面方程是 y = 根号下 (c^2-(x+a)^2)  - b
            //复合函数求导[f(g(x))]'=f'(g(x))*g'(x) 
            //导函数为：y'
            //           -(x+a)
            //-------------------------
            //  根号下(c^2 - (x+a)^2)
            if (ListA.Count > 2)
            {
                r = -(x + ListA[0]) / Math.Sqrt(ListA[2] * ListA[2] - (x + ListA[0]) * (x + ListA[0]));
            }
            //曲线求弧长的积分函数=在导函数基础上平方+1再开平方
            return Math.Sqrt(r * r + 1);
        }
    }
}
