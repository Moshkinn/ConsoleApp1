using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
       
       
    static void Main(string[] args)
        {
            int[] arr = { 8, 5, 4 };
            Array.Reverse(arr);
            double x = Math.Pow(arr[0], 2);
            Console.WriteLine("ath.Pow(arr[0], 2) = " + x);
            
        }
    }
}