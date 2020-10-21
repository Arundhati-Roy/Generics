using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
        }
    }
    class LinkedListQueue
    {
        internal Node head;
        internal void EnQueue(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into Linked list", node.data);
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        internal void Peek()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            else
            {
                Console.WriteLine(temp.data + " is in first of queue");
            }
        }
        internal void DeQueue()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            
            else
            { 
                Console.WriteLine("Deleted element: " + temp.data);
                this.head = temp.next;
            }
        }
        /*internal Node InsertAtGivenPos(int pos, int data)
        {
            if (pos < 1)
                Console.WriteLine("Invalid position");
            if (pos == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (pos-- != 0)
                {
                    if (pos == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (pos != 1)
                    Console.WriteLine("Position out of range");
            }
            Console.WriteLine("Inserted value is: " + head);
            return head;
        }
*/


    }
}
