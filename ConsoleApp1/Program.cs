using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        class Stack<T>
        {
            int index = 0;
            T[] innerArray = new T[100];
            public void Push(T item)
            {
                innerArray[index++] = item;
            }
            public T Pop()
            {
                return innerArray[--index];
            }
            public T Get(int k) { return innerArray[k]; }
        }
        static void Main(string[] args)
        {
            /*Stack<int> intStack = new Stack<int>();
            intStack.Push(3);
            Console.WriteLine(intStack.Pop());
            intStack.Push(6);
            Console.WriteLine(intStack.Pop());
            intStack.Push(7);
            Console.WriteLine(intStack.Pop());
            //intStack.Push(8);
            Console.WriteLine(intStack.Get(0));
            */
            ///////////////////////////////////////
            Stack<string> sStack = new Stack<string>();
            sStack.Push("a");
            sStack.Pop();
            sStack.Push("b");
            sStack.Push("c");
            Console.WriteLine(sStack.Get(0));
            for(int i = 0; i<10; i++)
            {
                sStack.Push("bb");
            }
            Console.WriteLine(sStack.Get(10));

        }
    }
}