using System;
using System.Collections.Generic;
using System.Text;

namespace LOYADE.CONTROL
{
    public abstract class Controller
    {
        public abstract double TransferFunction(double[] input);
    }
}
