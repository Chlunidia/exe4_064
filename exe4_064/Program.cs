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
        public int pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack underflow.");
                return -1;
            }
            else
            {
                Console.WriteLine("Poped element is: " + ele[top]);
                return ele[top--];
            }
        }
        public void display()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty.");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Item [" + (i + 1) + "]: " + ele[i]);
                }
            }
        }
    }
    class Program
    {
        
    }
}