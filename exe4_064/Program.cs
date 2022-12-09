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
    }
}