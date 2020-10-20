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
            /*int[] intArray = { 1, 2, 4, 5, 6 };
            double[] doubleArray = { 1.2, 3.4, 5.6 };
            char[] charArray = { 'f', 'h', 'g', 'i' };
            new PrintArray<int>(intArray).toPrint();
            new PrintArray<double>(doubleArray).toPrint();
            new PrintArray<char>(charArray).toPrint();*/
            Console.WriteLine(MaxOf3(3, 4, 5));
            Console.WriteLine(MaxOf3(3.4, 6.7, 1.2));
            Console.WriteLine(MaxOf3(9.4, 6.7, 1.2));
            Console.WriteLine(MaxOf3(3.4, 6.7, 13.2));

        }
        public static int MaxOf3(int a,int b,int c)
        {
            if (a >= b && a >= c)
                return a;
            if (b >= a && b >= c)
                return b;
            if (c >= b && c >= a)
                return c;
            return a;
        }
        public static double MaxOf3(double a, double b, double c)
        {
            if (a >= b && a >= c)
                return a;
            if (b >= a && b >= c)
                return b;
            if (c >= b && c >= a)
                return c;
            return a;
        }



    }
}
