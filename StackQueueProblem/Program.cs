using StackQueueProblem.Queue;
using StackQueueProblem.Stack;
using System;

namespace StackQueueProblem
{
    class Program
    {
        static readonly LinkedListStack linkedListStack = new LinkedListStack();
        static readonly LinkedListQueue queue = new LinkedListQueue();
        /// <summary>
        /// perform the stack operations.
        /// </summary>
        public static void StackMenu()
        {
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            Console.WriteLine("----------------------------");
            linkedListStack.Display();
            Console.WriteLine("----------------------------");
            linkedListStack.Peek();
            linkedListStack.Pop();
            Console.WriteLine("----------------------------");
            linkedListStack.Display();
            Console.WriteLine("----------------------------");
            linkedListStack.ISEmpty();
            Console.WriteLine("----------------------------");
            linkedListStack.Display();
            Console.WriteLine("----------------------------");
        }
        /// <summary>
        /// perform the queue operations.
        /// </summary>
        public static void QueueMenu()
        {
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();
            Console.WriteLine("----------------------------");
            queue.Dequeue();
            queue.Display();
            Console.WriteLine("----------------------------");
        }
        /// <summary>
        /// entry point of the application.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Program.StackMenu();
            Program.QueueMenu();
        }
    }
}
