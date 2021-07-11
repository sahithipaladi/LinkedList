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
        public void Add(int data)
        {
            Node newNode = new Node(data);
            newNode.data = data;
            newNode.Next = head;
            head = newNode;
        }

        //Method to add elements at first
        public void AddAtFirst(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
            }

        }

        //Method to append elements 
        public void Append(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = new Node(data);
                temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
        }

        //Method to insert elements
        public void Insert(int position, int data)
        {
            Node newNode = new Node(data);
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }
            else if (position == 1)
            {
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                Node temp = head;
                while (position > 2)
                {
                    temp = temp.Next;
                    position--;
                }
                newNode.Next = temp.Next;
                temp.Next = newNode;
            }
        }
        //Method to delete first element
        public void DeleteAtFirst()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            head = head.Next;
        }
        //Method to delete last element
        public void DeleteAtLast()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else if (head.Next == null)
            {
                head = null;
            }
            else
            {
                Node temp = head;
                while (temp.Next.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = null;
            }
        }
        //Method to search an element
        public bool Search(int data)
        {
            if (head == null)
            {
                return false;
            }
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    if (temp.data == data)
                    {
                        return true;
                    }
                    temp = temp.Next;
                }
                return false;
            }
        }
        //Method to display elements
        public void Display()
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
