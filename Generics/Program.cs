using System;

namespace Generics
{
    public class GenericMaxVAl<T> where T:IComparable
    {
        public T[] val;
        public GenericMaxVAl(T[] val)
        {
            this.val = val;

        }
        public T[] Sort(T[] vals)
        {
            Array.Sort(vals);
            return vals;
        }
        public T MaxVal(T[] vals)
        {
            var sorted_values = Sort(vals);
            /*var max = sorted_values[^1];
            return max;*/
            return sorted_values[^1];
        }
        public T MaxMethod()
        {
            var max = MaxVal(this.val);
            return max;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to generics demo!");
            int[] arr = { 728, 387, 847, 378, 3896, 23 };
            GenericMaxVAl<int> generic=new GenericMaxVAl<int>(arr);
            Console.WriteLine("Max value: ");
            Console.WriteLine(generic.MaxVal(arr));

        }
    }
}
