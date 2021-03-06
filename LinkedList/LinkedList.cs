using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList
    {
        internal Node head;
        public LinkedList()
        {
            this.head = null;
        }

        //Method to add elements
        internal void Add(int data)
        {
            Node newNode = new Node(data);
            newNode.data = data;
            newNode.Next = head;
            head = newNode;
        }

        //Method to display elements
        internal void Display()
        {
            if (head == null)
                Console.WriteLine("List is Empty");
            else
            {
                Node temp = head;
                Console.Write("  ");
                while (temp != null)
                {
                    Console.Write(temp.data + " -> ");
                    temp = temp.Next;
                }
                Console.Write("Null\n");
            }
        }
    }
}