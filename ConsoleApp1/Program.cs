using System;
using System.Collections.Generic;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>();
            li.Add(59);
            li.Add(72);
            li.Add(95);
            li.Add(5);
            li.Add(19);
            li.Remove(59);
            li.RemoveAt(1);
            for (int i=0; i<li.Count; i++)
            {
                li[i] = i;
            }

            Console.WriteLine("Capacity: ");
            Console.WriteLine(li.Capacity);
            Console.Write("\nList: ");
            for (int x = 0; x < li.Count; x++)
                Console.Write(li[x] + " ");
            li.Sort();
            Console.Write("\nSorted: ");
            for (int x = 0; x < li.Count; x++)
                Console.Write(li[x] + " ");
            //li.ForEach(+1);
        }
    }
}
