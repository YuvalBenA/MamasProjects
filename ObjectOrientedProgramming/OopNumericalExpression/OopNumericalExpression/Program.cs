using System;
using System.Collections.Generic;

namespace OopNumericalExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            NumericalExpression num = new NumericalExpression(12355);
            Console.WriteLine(num.ToString());

        }
    }
}
