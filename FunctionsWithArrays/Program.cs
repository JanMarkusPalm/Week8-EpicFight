using System;

namespace FunctionsWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "red", "blue", "green" };
            string randomcolor = PickRandomColor(colors);
            Console.WriteLine($"aruvit valis {randomcolor}.");
            DisplayRandomColor(colors);
        }
        private static int GenerateRandomNumberForArray(string[] someArray)
        {
            Random rnd = new Random();
            return rnd.Next(0, someArray.Length);
        }
        private static string PickRandomColor(string[] someArray)
        {           
            return someArray[GenerateRandomNumberForArray(someArray)];
        }

        private static void DisplayRandomColor(string[] someArray)
        {         
            Console.WriteLine(someArray[GenerateRandomNumberForArray(someArray)]);
        }

    }
}
