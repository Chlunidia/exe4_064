using System;
// Create Stack Using Array.
namespace StackUsingArray
{
    // Create  class Stacks.
    class Stacks
    {
        // Create variable ele, top, max.
        private int[] ele;
        private int top;
        private int max;
        // Create method Stacks.
        public Stacks(int size)
        {
            ele = new int[750];
            top = -1;
            max = 750;
        }
        // Create method push to allocate memory.
        public void push(int item)
        {
            // Check if the stack is full.
            if (top == max - 1)
            {
                Console.WriteLine("Stack overflow.");
                return;
            }
            else
            {
                // Print data that was successfully entered.
                Console.WriteLine("\n" + item + " pushed into stack.");
                ele[++top] = item;
            }
        }
        // Create method pop. This is utility function to pop element from the stack. Remove at the beginning.
        public int pop()
        {
            // Check for stack underflow.
            if (top == -1)
            {
                Console.WriteLine("Stack underflow.");
                return -1;
            }
            else
            {
                // Print data that was successfully deleted.
                Console.WriteLine("\nPoped element is: " + ele[top]);
                return ele[top--];
            }
        }
        public void display()
        {
            // Check for empty stack. 
            if (top == -1)
            {
                Console.WriteLine("Stack is empty.");
                return;
            }
            else
            {
                for (int luni = 0; luni <= top; luni++)
                {
                    // Print entered data.
                    Console.WriteLine("Item [" + (luni + 1) + "]: " + ele[luni]);
                }
            }
        }
    }
    // Create class Program to display menu.
    class Program
    {
        static void Main(string[] args)
        {
            Stacks s = new Stacks(750);
            while (true)
            {
                Console.WriteLine("\n**Stack Menu**\n");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");
                Console.Write("\nEnter your choice: ");
                string sInput = Console.ReadLine();
                char ch = Convert.ToChar(sInput == "" ? "0" : sInput);
                switch (ch)
                {
                    case '1':
                        Console.Write("\nEnter a number: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        s.push(num);
                        break;
                    case '2':
                        s.pop();
                        break;
                    case '3':
                        s.display();
                        break;
                    case '4':
                        return;
                    default:
                        Console.WriteLine("\nInvalid Choice");
                        break;
                }
            }
        }
    }
}