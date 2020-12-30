using System;
using System.Collections.Generic;
using System.Text;

namespace LOYADE.CONTROL
{
    /*

*/
    /// <summary>
    ///增量式PID算法
    ///Uo(N)=P*E(N)+I*[E(N)+E(N-1)+...+E(0)]+D*[E(N)-E(N-1)]
    ///E-误差
    ///P--改变P可提高响应速度，减小静态误差，但太大会增大超调量和稳定时间。
    ///I--与P的作用基本相似，但要使静态误差为0，必须使用积分。
    ///D--与P,I的作用相反，主要是为了减小超调，减小稳定时间。
    ///三个参数要综合考虑，一般先将I,D设为0，调好P,达到基本的响应速度和误差，再加上I，
    ///使误差为0，这时再加入D,三个参数要反复调试，最终达到较好的结果。不同的控制对象，调试的难度相差很大！
    /// </summary>
    public class PID
    {
        /// <summary>
        /// 设定目标值/给定值 Desired Value
        /// </summary>
        public double SetPoint;
        /// <summary>
        /// 比例常数 Proportional Const
        /// </summary>
        public double Proportion;
        /// <summary>
        /// 积分常数 Integral Const
        /// </summary>
        public double Integral;
        /// <summary>
        /// 微分常数 Derivative Const
        /// </summary>
        public double Derivative;
        /// <summary>
        /// Error[-1]
        /// </summary>
        public double LastError;
        /// <summary>
        /// Error[-2]
        /// </summary>
        public double PrevError;
        /// <summary>
        /// Sums of Errors
        /// </summary>
        public double SumError;

        public PID()
        {

        }

        public PID(double sp)
        {
            this.SetPoint = sp;
        }

        public void Initialize()
        {
            this.SetPoint = 0;
            this.LastError = 0;
            this.PrevError = 0;
            this.SumError = 0;
        }

        public void Initialize(double sp)
        {
            this.SetPoint = sp;
            this.LastError = 0;
            this.PrevError = 0;
            this.SumError = 0;
        }

        public void AdjustParameters(double[] para)
        {
            this.Proportion = para[0];
            this.Integral = para[1];
            this.Derivative = para[2];
        }

        /// <summary>
        /// PID计算部分
        /// </summary>
        /// <param name="nextpoint"></param>
        /// <returns></returns>
        public double Calculate(double nextpoint)
        {
            double derror, error;

            error = this.SetPoint - nextpoint;          // 偏差
            this.SumError += error;                      // 积分
            derror = this.LastError - this.PrevError;     // 当前微分
            this.PrevError = this.LastError;
            this.LastError = error;
            return (this.Proportion * error + this.Integral * this.SumError + this.Derivative * derror);
        }
    }
}

