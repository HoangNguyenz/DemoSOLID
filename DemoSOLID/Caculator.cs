using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSOLID
{
    public class Calculator : ICalculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
    }
}
