using System;

namespace Generics
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to generics demo!");
            LinkedListQueue list = new LinkedListQueue();
            list.EnQueue(56);
            list.EnQueue(89);
            list.EnQueue(43);
            list.Peek();
            list.Display();
            list.DeQueue();
            list.Peek();
            list.EnQueue(93);
            list.EnQueue(563);
            list.DeQueue();
            list.Peek();
            list.Display();
            /*list.Peek();
            list.Push(67);
            list.Push(90);
            list.Pop();
            list.Display();*/
            //list.Display();

        }
    }
}
