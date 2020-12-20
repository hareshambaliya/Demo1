using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public class Maths
    {
        public decimal Addition(decimal operand1, decimal operand2)
        {
            return operand1 + operand2;
        }
        public decimal Subtraction(decimal operand1, decimal operand2)
        {
            return operand1 - operand2;
        }

        public decimal Multiplication(decimal operand1, decimal operand2)
        {
            return operand1 * operand2;
        }

        public decimal Division(decimal operand1, decimal operand2)
        {
            return operand1 / operand2;
        }

        public int ToInt(decimal operand1)
        {
            return Convert.ToInt32(operand1);
        }
    }
}
