using List;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueueProblem.Stack
{
    class LinkedListStack
    {
        private Node top;
        /// <summary>
        /// constructor is used to initialized the top.
        /// </summary>
        public LinkedListStack()
        {
            this.top = null;
        }
        /// <summary>
        /// add element into stack.
        /// </summary>
        public void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
                node.next = this.top;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine("{0} pushed to stack", value);
        }
        /// <summary>
        /// display the stack elements.
        /// </summary>
        public void Display()
        {
            Node temp = this.top;
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data+ " ");
                temp = temp.next;
            }
        }
    }
}
