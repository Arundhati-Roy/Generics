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
    class LinkedListStack
    {
        internal Node top;
        public LinkedListStack()
        { this.top = null; }
        internal void Push(int data)
        {
            Node node = new Node(data);
            if (this.top == null)
                this.top = node;
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed into Linked list stack", node.data);
        }
        internal void Display()
        {
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            Console.WriteLine("Elements inside Linked List stack");
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        internal void Peek()
        {
            if(this.top==null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine(this.top.data + " is in top of the stack");
        }
        internal void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine(this.top.data + " is in popped out of the stack");
            this.top = this.top.next;
        }
        /*internal Node InsertAtGivenPos(int pos,int data)
        {
            if (pos < 1)
                Console.WriteLine("Invalid position");
            if(pos==1)
            {
                var newNode = new Node(data);
                newNode.next = this.top;
                top = newNode;
            }
            else
            {
                while(pos-- !=0)
                {
                    if(pos==1)
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
        }*/



    }
}
