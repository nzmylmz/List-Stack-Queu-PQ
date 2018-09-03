using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje2B_a
{
    class StackX
    {
        private int maxSize;
        private long[] stackArray;
        private int top;


        public StackX(int s) 
        {
            maxSize = s; 
            stackArray = new long[maxSize]; 
            top = -1; 
        }
        public void push(long j) 
        {
            stackArray[++top] = j;
        }
        public long pop() 
        {
            return stackArray[top--]; 
        }
        public long peek() 
        {
            return stackArray[top];
        }
        public bool isEmpty() 
        {
            return (top == -1);
        }
        public bool isFull() 
        {
            return (top == maxSize - 1);
        }
    }
        class Program { 

        static void Main(string[] args)
        {
            StackX theStack = new StackX(10); 
            theStack.push(20); 
            theStack.push(40);
            theStack.push(60);
            theStack.push(80);
            while (!theStack.isEmpty()) 
            { 
                long value = theStack.pop();
                Console.Write(value); 
                Console.Write(" ");
            } 
            Console.WriteLine("");
        }
    }
}
