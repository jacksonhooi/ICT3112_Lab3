using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowCalculatorTests
{
    public class CalculatorContext
    {
        public Calculator Calculator { get; set; }
        public double Result { get; set; }

        public CalculatorContext()
        {
            Calculator = new Calculator();
        }
    }
}
