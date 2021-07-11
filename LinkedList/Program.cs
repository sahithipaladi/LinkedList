using System;

namespace LinkedList
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

            //Dispaly the list
            linkedList.Display();
        }
    }
}