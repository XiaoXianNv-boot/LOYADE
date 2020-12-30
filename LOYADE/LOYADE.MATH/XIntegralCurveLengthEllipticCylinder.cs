using System;
using System.Collections.Generic;
using System.Text;

namespace LOYADE.MATH
{
    public class XIntegralCurveLengthEllipticCylinder : XIntegral
    {
        public override double Func(double x)
        {
            double r = 0;
            //椭圆柱面方程是 y = 根号下 (b^2-b^2 * x^2/a^2)
            //复合函数求导[f(g(x))]'=f'(g(x))*g'(x) 
            //导函数为：y'= ± (b/a) * x / 根号下 (a^2 - x^2)
            if (ListA.Count > 1)
            {
                r = (ListA[1] * x / ListA[0]) / Math.Sqrt((ListA[0] * ListA[0]) - (x * x));
            }
            //曲线求弧长的积分函数=在导函数基础上平方+1再开平方
            return Math.Sqrt(r * r + 1);
        }
    }
}
