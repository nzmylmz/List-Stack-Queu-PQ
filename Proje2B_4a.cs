using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje2B_4a
{
    class PQ
    {
        List<int> PrioriQ;

        public PQ() { PrioriQ = new List<int>(); }

        public void ekle(int number)
        { PrioriQ.Add(number); }

        public int sil()
        {
            int min = PrioriQ.ElementAt(0), minIndex = 0;
            for (int i = 1; i < PrioriQ.Count(); ++i)
            {
                if (PrioriQ.ElementAt(i) < min)
                {
                    min = PrioriQ.ElementAt(i);
                    minIndex = i;
                }
            }
            PrioriQ.ElementAt(minIndex); return min;
        }
        public bool bosMu() { return PrioriQ.Count() == 0; }
        public void yazdir()
        {
            foreach (int i in PrioriQ)
                Console.Write(i + " ");
        }
    }
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
    class Queue
    {
        private int maxSize;
        private long[] queArray;
        private int front;
        private int rear;
        private int nItems;

        public Queue(int s) 
        {
            maxSize = s;
            queArray = new long[maxSize];
            front = 0;
            rear = -1;
            nItems = 0;
        }

        public void insert(long j) 
        {
            if (rear == maxSize - 1)
                rear = -1;
            queArray[++rear] = j; 
            nItems++; 
        }

        public long remove() 
        {
            long temp = queArray[front++]; 
            if (front == maxSize) 
                front = 0;
            nItems--; 
            return temp;
        }
        public long peekFront() 
        {
            return queArray[front];
        }
        public bool isEmpty()
        {
            return (nItems == 0);
        }
        public bool isFull() 
        {
            return (nItems == maxSize);
        }
        public int size() 
        {
            return nItems;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            PQ pq = new PQ();
            StackX stack = new StackX(25);
            Queue que = new Queue(25);

            for (int i = 0; i < 25; i++)
            { 
                int a =rnd.Next(5,101);
                pq.ekle(a);
                stack.push(a);
                que.insert(a);
            }
            long  PQCount = 0, stackCount = 0, queueCount=0, avaragePQ=0,avarageStack=0,avarageQueue=0;
            byte counter = 0;
            while (counter < 25)
            {
                counter++;
                PQCount += pq.sil();
                queueCount += que.remove();
                stackCount += stack.pop();
                avaragePQ += PQCount;
                avarageStack += stackCount;
                avarageQueue += queueCount;
                Console.WriteLine("{0}. müşterinin işlem süreleri\n-------------------------", counter);
                Console.WriteLine(" Öcelik Kuyruğu(PQ) işlem süresi: {0}\n Yığıt(Stack) işlem süresi: {1}\n Kuyruk(Queue) işlem süresi: {2}\n",PQCount,stackCount,queueCount);
            }
            Console.WriteLine("Öncelik Kuyruğu(PQ)ndaki ortalama işlem süresi \t: {0} birim",avaragePQ/25);
            Console.WriteLine("Yığıt(Stack)taki ortalama işlem süresi \t\t: {0} birim", avarageStack/25);
            Console.WriteLine("Kuyruk(Queue)taki ortalama işlem süresi \t: {0} birim", avarageQueue/25);
            Console.ReadKey();
        }
    }
}
