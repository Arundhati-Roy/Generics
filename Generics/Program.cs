using System;

namespace Generics
{
    public class GenericMaxVAl<T> where T:IComparable
    {
        public T a, b, c;
        public GenericMaxVAl(T a, T b, T c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

        }
        public static T MaxOf3(T a, T b, T c)
        {

            if (a.CompareTo(b) >= 0 && a.CompareTo(c) >= 0)
                return a;
            if (b.CompareTo(a) >= 0 && b.CompareTo(c) >= 0)
                return b;
            if (c.CompareTo(b) >= 0 && c.CompareTo(a) >= 0)
                return c;
            return a;

        }
        public T MaxMethod()
        {
            T max = GenericMaxVAl<T>.MaxOf3(a, b, c);
            return max;
        }
        
    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to generics demo!");
            var m=new GenericMaxVAl<int>(3,4,5).MaxMethod();
            var m2 = new GenericMaxVAl<double>(4.3, 6.7, 9.5).MaxMethod();
            var m3 = new GenericMaxVAl<string>("dh3", "F", "5").MaxMethod();
            Console.WriteLine(m3 , m,m2);

        }
    }
}
