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
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            //Dispaly the list
            linkedList.Display();
        }
    }
}




