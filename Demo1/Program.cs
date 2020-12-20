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
            ////primitive data types are: int, object, short, char, float, double, bool.
            int a = 0;
            int[] array = { 1, 2, 3, 4, 5 };

            object obj = 0;
            object obj1 = "haresh";
            object obj2 = true;

            float f = 0.2F;
            double d = 0.2;
            decimal d1 = 0.2M;

            bool tr = true;
            bool fs = false;

            bool one = Convert.ToBoolean(1);
            bool zero = Convert.ToBoolean(0);

            char[] haresh = { 'h','a','r','e','s','h' };

            string h = "haresh";

            Console.WriteLine(h);

            Console.ReadKey();
        }
    }
}
