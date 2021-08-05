using StackQueueProblem.Stack;
using System;

namespace StackQueueProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListStack linkedListStack = new LinkedListStack();
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
    }
}
