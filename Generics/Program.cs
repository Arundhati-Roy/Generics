using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to generics demo!");
            int[] intArray = { 1, 2, 4, 5, 6 };
            double[] doubleArray = { 1.2, 3.4, 5.6 };
            char[] charArray = { 'f', 'h', 'g', 'i' };
            Program.toPrint<int>(intArray);
            Program.toPrint<double>(doubleArray);
            Program.toPrint<char>(charArray);
        }
        public static void toPrint<T>(T[] a)
        {
            foreach(var i in a)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");
        }
        
    }
}
