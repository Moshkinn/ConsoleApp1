using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Some text";
            //str = Console.ReadLine();
            try
                    {
                string txt = File.ReadAllText("test1.txt");
                Console.WriteLine(txt);

                // File.WriteAllText("test1.txt", str);
            }
                    
                    catch (Exception e)
                    {
                        Console.WriteLine("An error occurred");
                    }
                finally
                {
                
            }
                
            
        
        }
    }
}