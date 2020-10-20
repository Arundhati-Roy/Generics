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
            Program.toPrint(intArray);
            Program.toPrint(doubleArray);
            Program.toPrint(charArray);
        }
        public static void toPrint(int[] a)
        {
            foreach(int i in a)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");
        }
        public static void toPrint(double[] b)
        {
            foreach (int i in b)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");
        }
        public static void toPrint(char[] c)
        {
            foreach (int i in c)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");
        }
    }
}
