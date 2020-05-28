using System;
using System.Collections.Generic;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary<string, int> d = new Dictionary<string, int>();

            Dictionary<string, string> d = new Dictionary<string, string>();
            Console.WriteLine("Dictionary: ");
            d.Add("name", "Bob");
            //d.Add("name", "Bobs");

            d.Add("age", "25");
            d.Add("sex", "male");
            foreach (string s in d.Keys)
                Console.WriteLine(s + ": " + d[s]);  // Uno: 1  Deux: 2
            Console.WriteLine("\nCount: {0}", d.Count); // 2 
        }
    }
}
