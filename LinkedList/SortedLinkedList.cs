using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListImplementation
{
        public class SortedLinkedList
        {
            internal Node head;
            public SortedLinkedList()
            {
                this.head = null;
            }

            //This method Sorted while Adding in the LinkedList....
            public void Add(int data)
            {
                Node newNode = new Node(data);
                if (head == null)
                    head = newNode;
                else
                {
                    Node temp = head;
                    if (temp.data > data)
                    {
                        newNode.Next = head;
                        head = newNode;
                    }
                    else
                    {
                        while (temp.Next != null && temp.Next.data < data)
                        {
                            temp = temp.Next;
                        }
                        newNode.Next = temp.Next;
                        temp.Next = newNode;
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

            //Display sorted linked list
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


