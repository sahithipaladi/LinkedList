using System;

namespace LinkedListImplementation
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------Linked List--------------------");
            LinkedList linkedList = new LinkedList();

            //Adding elements to the list
            linkedList.Append(56);
            linkedList.Append(70);
            //Insert element at given position
            linkedList.Insert(2, 30);

            //Insert element at given position
            linkedList.Insert(3, 40);

            //Search an element
            if (linkedList.Search(40))
            {
                Console.WriteLine("The element 40 is found in the list");
            }
            else
            {
                Console.WriteLine("The element 40 is not found in the list");
            }

            //Delete an element
            if (linkedList.Delete(40))
            {
                Console.WriteLine("The element 40 is deleted successfully");
            }
            else
            {
                Console.WriteLine("The element 40 is not found in the list");
            }

            Console.WriteLine("Size of the linked list is : " + linkedList.Size() + "\n");
            //Dispaly linked list 
            linkedList.Display();
        }
    }
}

