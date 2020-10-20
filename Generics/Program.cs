using System;

namespace Generics
{
    public class PrintArray<T>
    {
        private T[] a;
        public PrintArray(T[] a)
        {
            this.a = a;
        }
        public void toPrint()
        {
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to generics demo!");
            int[] intArray = { 1, 2, 4, 5, 6 };
            double[] doubleArray = { 1.2, 3.4, 5.6 };
            char[] charArray = { 'f', 'h', 'g', 'i' };
            new PrintArray<int>(intArray).toPrint();
            new PrintArray<double>(doubleArray).toPrint();
            new PrintArray<char>(charArray).toPrint();
        }
       
        
    }
}
