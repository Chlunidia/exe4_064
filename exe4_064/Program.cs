using System;
// Create Stack Using Array
namespace StackUsingArray
{
    // Create  class Stacks
    class Stacks
    {
        private int[] ele;
        private int top;
        private int max;
        public Stacks(int size)
        {
            ele = new int[size];
            top = -1;
            max = size;
        }
        public void push(int item)
        {
            if (top == max - 1)
            {
                Console.WriteLine("Stack overflow.");
                return;
            }
            else
            {
                Console.WriteLine("\n" + item + " pushed into stack.");
                ele[++top] = item;
            }
        }
    }
}