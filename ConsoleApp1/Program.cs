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
            int x = 1;
            int y = 2;
            while (x!=y) 
                {
                    try
                    {
                        Console.WriteLine("type x and y. ");
                        x = Convert.ToInt32(Console.ReadLine());
                        y = Convert.ToInt32(Console.ReadLine());
                        Console.Write("x/y = ");
                        Console.WriteLine(x / y);
                    }
                    catch (DivideByZeroException e)
                    {
                        Console.WriteLine("Cannot divide by 0");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("An error occurred");
                    }
                finally
                {
                    Console.WriteLine("finally.");
                }
                }
            
        
        }
    }
}