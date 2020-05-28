using System;
using System.Collections.Generic;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            Stack<int> s = new Stack<int>();

            for(int i=0; i<5; i++)
            {
                s.Push(i + 1);
            }
            foreach(int a in s) {
                q.Enqueue(a);
            }
            Console.WriteLine("Stack: ");
            foreach (int a in s)
                Console.WriteLine(" " + a);
            Console.WriteLine("Queue: ");
            foreach (int a in q)
                Console.WriteLine(" " + a);
            q.Dequeue();
            s.Pop();
            Console.WriteLine("Stack: ");
            foreach (int a in s)
                Console.WriteLine(" " + a);
            Console.WriteLine("Queue: ");
            foreach (int a in q)
                Console.WriteLine(" " + a);

        }
    }
}
