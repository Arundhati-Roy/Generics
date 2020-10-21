using System;

namespace Generics
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to generics demo!");
            LinkedListStack list = new LinkedListStack();
            list.Push(56);
            list.Push(89);
            list.Peek();
            list.Push(43);
            list.Display();
            list.Peek();
            list.Push(67);
            list.Push(90);
            list.Pop();
            list.Display();
            //list.Display();

        }
    }
}
