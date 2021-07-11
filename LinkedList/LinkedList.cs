using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListImplementation
{
    public class LinkedList
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

        //Method to delete an element
        public bool Delete(int data)
        {
            bool flag = false;
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return flag;
            }
            else
            {
                if (head.data == data)
                {
                    head = null;
                    return flag;
                }
                else
                {
                    Node temp = head;
                    while (temp.Next != null)
                    {
                        if (temp.Next.data == data)
                        {
                            temp.Next = temp.Next.Next;
                            flag = true;
                            break;
                        }
                        temp = temp.Next;
                    }
                    return flag;
                }
            }
        }

        //Method to determine size of the linked list
        public int Size()
        {
            int size = 0;
            Node temp = head;
            while (temp != null)
            {
                size++;
                temp = temp.Next;
            }
            return size;
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
