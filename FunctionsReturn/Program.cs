using System;

namespace FunctionsReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 29;
            int b = 54;

            int result = AddTwoNumbers(a, b);

            Console.WriteLine($"{a} + {b} = {result}");

        }
        private static int AddTwoNumbers(int x, int y)
        {
                return x + y;
        }
        
    }
}
