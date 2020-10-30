using System;

namespace StackAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue demo");
            LinkedList StacklinkedList = new LinkedList();
            StacklinkedList.Push(70);
            StacklinkedList.Push(30);
            StacklinkedList.Push(56);
            StacklinkedList.Display();

            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            linkedListQueue.Display();
        }
    }
}
