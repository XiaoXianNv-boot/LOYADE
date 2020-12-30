using System;
using System.Collections.Generic;
using System.Text;

namespace LOYADE.BPM
{
    public class ActionFilter
    {
        private static ActionFilter _filter;

        protected ActionFilter()
        {

        }

        public static ActionFilter GetInstance()
        {
            if (_filter == null)
            {
                _filter = new ActionFilter();
            }
            return _filter;
        }

        public bool ConditionCheck2(ObjectToken t, string condition, bool previouscondition, int simulationcount)
        {
            bool bRet = false;
            switch (condition)
            {
                default:
                    break;
                case "S Task":
                    if (t.DicObjectTokenColor.ContainsKey("父任务编号"))
                        if (t.DicObjectTokenColor["紧急度"].CurrentValue >= 1)
                            bRet = true;
                    break;
                case "S Split":
                    if (t.DicObjectTokenColor.ContainsKey("父任务编号"))
                        if (t.DicObjectTokenColor["紧急度"].CurrentValue < 1)
                            bRet = true;
                    break;
                case "S Dead Task":
                    if (t.DicObjectTokenColor.ContainsKey("父任务编号"))
                        if (t.DicObjectTokenColor["截止时间"].CurrentValue < simulationcount)
                            bRet = true;
                    break;
                case "S Alive Task":
                    if (t.DicObjectTokenColor.ContainsKey("父任务编号"))
                        if (t.DicObjectTokenColor["截止时间"].CurrentValue >= simulationcount)
                            bRet = true;
                    break;
                case "S Split BAD":
                    if (t.DicObjectTokenColor.ContainsKey("父任务编号"))
                        if (t.DicObjectTokenColor["父任务编号"].CurrentValue == -t.DicObjectTokenColor["任务编号"].CurrentValue)
                            bRet = true;
                    break;
                case "S RES":
                    if (t.DicObjectTokenColor.ContainsKey("是否独占"))
                        if (t.DicObjectTokenColor["是否独占"].CurrentValue == 1)
                            bRet = true;
                    break;
                case "S Split OK":
                    if (t.DicObjectTokenColor.ContainsKey("父任务编号"))
                        if (t.DicObjectTokenColor["父任务编号"].CurrentValue != t.DicObjectTokenColor["任务编号"].CurrentValue)
                            bRet = true;
                    break;
                case "Has Task":

                    break;
            }
            return bRet;
        }

        public bool ConditionCheck(ObjectToken t, string condition, bool previouscondition, int simulationcount)
        {
            try
            {
                //condition: Logic ; ObjectName ; Compare ; Operator ; ObjectName2 ; Const
                double v,temp;
                string[] arr = condition.Split(';');
                if (t.DicObjectTokenColor.ContainsKey(arr[0]))
                {
                    //与的情况，上一个为否则这个不用再判断就是否
                    if (arr[1] == "AND")
                    {
                        if (!previouscondition)
                            return false;
                    }
                    else//或的情况，上一个为真则这个不用再判断就是真
                    {
                        if (previouscondition)
                            return true;
                    }
                    //求得值
                    double x = t.DicObjectTokenColor[arr[0]].CurrentValue;
                    double y,result;
                    if (t.DicObjectTokenColor.ContainsKey(arr[4]))
                    {
                        y = t.DicObjectTokenColor[arr[4]].CurrentValue;
                    }
                    else if (double.TryParse(arr[5], out y))
                    {
                        ;
                    }
                    else
                    {
                        y = simulationcount;
                    }
                    switch (arr[3])
                    {
                        default:
                            result = y;
                            break;                         
                        case "+":
                            if (t.DicObjectTokenColor.ContainsKey(arr[2]))
                                result = x + Convert.ToDouble(t.DicObjectTokenColor[arr[2]].CurrentValue);
                            else if (double.TryParse(arr[3], out v))
                                result = x + v;
                            else
                                result = x + simulationcount;
                            break;
                        case "-":
                            if (t.DicObjectTokenColor.ContainsKey(arr[2]))
                                result = x - Convert.ToDouble(t.DicObjectTokenColor[arr[2]].CurrentValue);
                            else if (double.TryParse(arr[3], out v))
                                result = x - v;
                            else
                                result = x - simulationcount;
                            break;
                        case "*":
                            if (t.DicObjectTokenColor.ContainsKey(arr[2]))
                                result = x * Convert.ToDouble(t.DicObjectTokenColor[arr[2]].CurrentValue);
                            else if (double.TryParse(arr[3], out v))
                                result = x * v;
                            else
                                result = x * simulationcount;
                            break;
                        case "/":
                            if (t.DicObjectTokenColor.ContainsKey(arr[2]))
                            {
                                temp = Convert.ToDouble(t.DicObjectTokenColor[arr[2]].CurrentValue);
                                if (temp != 0)
                                {
                                    result = x / temp;
                                }
                                else
                                    result = x / simulationcount;
                            }
                            else if (double.TryParse(arr[3], out v))
                            {
                                if (v != 0)
                                {
                                    result = x / v;
                                }
                                else
                                    result = x / simulationcount;
                            }
                            else
                                result = x / simulationcount;
                            break;
                        case "POW":
                            if (t.DicObjectTokenColor.ContainsKey(arr[2]))
                                result = Math.Pow(x, Convert.ToDouble(t.DicObjectTokenColor[arr[2]].CurrentValue));
                            else if (double.TryParse(arr[3], out v))
                                result = Math.Pow(x, v);
                            else
                                result = Math.Pow(x, simulationcount);
                            break;
                    }
                    switch (arr[2])
                    {
                        default:
                            break;
                        case ">":
                            if (x > y)
                                return true;
                            break;
                        case "<":
                            if (x < y)
                                return true;
                            break;
                        case "=":
                            if (x == y)
                                return true;
                            break;
                        case ">=":
                            if (x >= y)
                                return true;
                            break;
                        case "<=":
                            if (x <= y)
                                return true;
                            break;
                    }
                }
            }
            catch
            {
            }
            return false;
        }

        public void Operate(ObjectToken t, string operation, int simulationcount)
        {
            try
            {
                //operate: ObjectName ; Operator ; ObjectName 2 ; Const 
                string[] arr = operation.Split(';');
                if (t.DicObjectTokenColor.ContainsKey(arr[0]))
                {
                    //求得值
                    double x = Convert.ToDouble(t.DicObjectTokenColor[arr[0]].CurrentValue);
                    double result;
                    double v, temp;
                    switch (arr[1])
                    {
                        default:
                            result = x;
                            break;
                        case "=":
                            if (t.DicObjectTokenColor.ContainsKey(arr[2]))
                                result = Convert.ToDouble(t.DicObjectTokenColor[arr[2]].CurrentValue);
                            else if (double.TryParse(arr[3], out v))
                                result = v;
                            else
                                result = simulationcount;
                            break;
                        case "+":
                            if (t.DicObjectTokenColor.ContainsKey(arr[2]))
                                result = x + Convert.ToDouble(t.DicObjectTokenColor[arr[2]].CurrentValue);
                            else if (double.TryParse(arr[3], out v))
                                result = x + v;
                            else
                                result = x + simulationcount;
                            break;
                        case "-":
                            if (t.DicObjectTokenColor.ContainsKey(arr[2]))
                                result = x - Convert.ToDouble(t.DicObjectTokenColor[arr[2]].CurrentValue);
                            else if (double.TryParse(arr[3], out v))
                                result = x - v;
                            else
                                result = x - simulationcount;
                            break;
                        case "*":
                            if (t.DicObjectTokenColor.ContainsKey(arr[2]))
                                result = x * Convert.ToDouble(t.DicObjectTokenColor[arr[2]].CurrentValue);
                            else if (double.TryParse(arr[3], out v))
                                result = x * v;
                            else
                                result = x * simulationcount;
                            break;
                        case "/":
                            if (t.DicObjectTokenColor.ContainsKey(arr[2]))
                            {
                                temp = Convert.ToDouble(t.DicObjectTokenColor[arr[2]].CurrentValue);
                                if (temp != 0)
                                {
                                    result = x / temp;
                                }
                                else
                                    result = x / simulationcount;
                            }
                            else if (double.TryParse(arr[3], out v))
                            {
                                if (v != 0)
                                {
                                    result = x / v;
                                }
                                else
                                    result = x / simulationcount;
                            }
                            else
                                result = x / simulationcount;
                            break;
                        case "POW":
                            if (t.DicObjectTokenColor.ContainsKey(arr[2]))
                                result = Math.Pow(x, Convert.ToDouble(t.DicObjectTokenColor[arr[2]].CurrentValue));
                            else if (double.TryParse(arr[3], out v))
                                result = Math.Pow(x, v);
                            else
                                result = Math.Pow(x, simulationcount);
                            break;
                    }
                    if (result <= t.DicObjectTokenColor[arr[0]].MaxValue && result >= t.DicObjectTokenColor[arr[0]].MinValue)
                        t.DicObjectTokenColor[arr[0]].CurrentValue = result;
                }
            }
            catch
            {

            }
        }
    }
}
