using System;

namespace LinkedListImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------Linked List--------------------");
            LinkedList linkedList = new LinkedList();

            //Adding elements to the list
            linkedList.Append(56);
            linkedList.Append(70);
            linkedList.Insert(2, 30);

            if (linkedList.Search(56))
            {
                Console.WriteLine("The element 56 is found in the list");
            }
            else
            {
                Console.WriteLine("The element 56 is not found in the list");

                //Insert element at given position
                linkedList.Insert(3, 40);
                linkedList.Display();
            }
        }
        
    }
}
