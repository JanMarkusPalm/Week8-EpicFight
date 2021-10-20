using System;

namespace SumOfArrayElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 125, 5231, 21, 51, 5626, 59012, 4, 69 };
            Console.WriteLine($"Sum of all the elements : {SumOfElements(numbers)}");

        }

        private static int SumOfElements(int[] somearray)
        {
            int sum = 0;

            for(int i = 0; i < somearray.Length; i++)
            {
                sum = sum + somearray[i];
            }

            return sum;

        }

    }
}
