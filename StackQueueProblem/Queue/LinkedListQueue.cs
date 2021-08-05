using List;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueueProblem.Queue
{
    public class LinkedListQueue
    {
        private Node front;
        public LinkedListQueue()
        {
            this.front = null;
        }
        public void Enqueue(int value)
        {
            Node node = new Node(value);
            if (this.front == null)
                this.front = node;
            else
            {
                Node rear = front;
                while (rear.next != null)
                {
                    rear = rear.next;
                }
                rear.next = node;
            }
        }
        /// <summary>
        /// display the elements of Queue.
        /// </summary>
        public void Display()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Node temp = front;
                while (temp != null)
                {
                    Console.Write(temp.data + "->");
                    temp = temp.next;
                }
                Console.Write("null\n");
            }
        }
    }
}
