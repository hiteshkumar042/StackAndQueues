using System;

namespace StackAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================\nWelcome to Stack and Queue!\n===========================");
            Console.WriteLine("1. Stack.\n2. Queue.");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1: //Stack
                    //Calling Class and Adding Data in Stack
                    LinkedListStack linkedListStack = new LinkedListStack();
                    linkedListStack.Push(70);
                    linkedListStack.Push(30);
                    linkedListStack.Push(56);
                    Console.WriteLine("----------------------------");

                    //Peek Value from Stack
                    linkedListStack.Peek();
                    Console.WriteLine("----------------------------");
                    linkedListStack.Pop();

                    //Pop value till Stack will empty
                    linkedListStack.IsEmpty();
                    break;
                case 2: //Queue
                    LinkedListQueue linkedListQueue = new LinkedListQueue();
                    linkedListQueue.Enqueue(56);
                    linkedListQueue.Enqueue(30);
                    linkedListQueue.Enqueue(70);
                    Console.WriteLine("----------------");

                    //Display Queue
                    linkedListQueue.Display();
                    Console.WriteLine("----------------");

                    //Dequeue from queue
                    linkedListQueue.Dequeue();

                    //Empty Dequeue
                    linkedListQueue.IsEmpty();

                    //Display Queue
                    linkedListQueue.Display();
                    Console.WriteLine("----------------");
                    break;
            }
        }
    }
}