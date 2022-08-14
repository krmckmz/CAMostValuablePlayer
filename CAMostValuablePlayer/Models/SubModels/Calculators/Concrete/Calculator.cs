using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAMostValuablePlayer
{
    public class Calculator
    {
        private readonly ICalculator _calculator;
        public Calculator(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public int CalculatePoint()
        {
            return _calculator.CalculatePoint();
        }
    }
}
