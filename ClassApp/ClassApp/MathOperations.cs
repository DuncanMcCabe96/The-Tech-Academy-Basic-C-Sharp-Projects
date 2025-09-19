using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp
{
    public class MathOperations
    {
        public void Division(int number)
        {
            int result = number / 2;
            Console.WriteLine("Result: " + result);
        }

        public void MultiplyByTwo(int input, out int result)
        {
            result = input* 2;
        }

        public void Division(double number)
        {
            double result = number / 2;
                Console.WriteLine("Result (double): " + result);
        }
}
}
