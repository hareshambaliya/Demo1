using DemoLibrary;
using System;

namespace Demo1
{
    /// <summary>
    /// Private - Default
    /// Protected
    /// internal
    /// public
    /// </summary>
    class Program
    {
        /// <summary>
        /// static - Only one instance
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter operand 1: ");
            decimal operand1 = Convert.ToDecimal(Console.ReadLine());
            
            Console.WriteLine("Enter operand 2: ");
            decimal operand2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine(
                "1. Addition\n" +
                "2. Subtraction\n" +
                "3. Multiplication\n" +
                "4. Division\n" +
                "Enter operation no: ");

            int operation = Convert.ToInt32(Console.ReadLine());

            decimal result;

            if (operation == 1)
                result = new Maths().Addition(operand1, operand2);
            else if(operation==2)
                result = new Maths().Subtraction(operand1, operand2);

            Console.ReadKey();
        }
    }
}
