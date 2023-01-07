namespace StackAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================\nWelcome to Stack and Queue\n===========================");
            //Calling Class and Adding Data in Stack
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);

            //Display Message
            linkedListStack.Display();
        }
    }
}