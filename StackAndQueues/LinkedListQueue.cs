using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueues
{
    internal class LinkedListQueue
    {
        Node head = null;

        //Enqueue Function
        internal void Enqueue(int data)
        {
            //Node Object
            Node node = new Node(data);

            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            //Display Added Data
            Console.WriteLine("{0} inserted into Queue ", node.data);
        }
        //Dequeue Function
        internal void Dequeue()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            Console.WriteLine("Dequeue value : {0}", this.head.data);
            Console.WriteLine("----------------------------");
            this.head = this.head.next;
        }
        //Deletion till stack Will Empty
        internal void IsEmpty()
        {
            while (this.head != null)
            {
                Dequeue();

            }
        }
        //Display Queue Data
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine("Queue Data : " + temp.data);
                temp = temp.next;
            }
        }
    }
}
