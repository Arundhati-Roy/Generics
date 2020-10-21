using System;

namespace Generics
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to generics demo!");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(89);
            list.Add(43);
            list.Display();
            //Console.WriteLine("search element" + list.Search(30));
            Console.WriteLine("After insertion " + list.InsertAtGivenPos(2, 30));
            list.Display();

        }
    }
}
