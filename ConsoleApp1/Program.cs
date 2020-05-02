using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        class Box
        {
            public int Height { get; set; }
            public int Width { get; set; }
            public Box(int h, int w)
            {
                Height = h;
                Width = w;
            }
            public static Box operator +(Box a, Box b)
            {
                int h = a.Height + b.Height;
                int w = a.Width + b.Width;
                Box res = new Box(h, w);
                return res;
            }
            public static bool operator >(Box a, Box b)
            {
                if (a.Height > b.Height)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
    
            public static bool operator <(Box a, Box b)
            {
                if (a.Height < b.Height)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        static void func()
            {
            int xx = 1;
            xx++;
            Console.WriteLine("xx= " + xx);
            }
    static void Main(string[] args)
        {
            Box b1 = new Box(14, 3);
            Box b2 = new Box(5, 7);
            Box b3 = b1 + b2;
            func();

            Console.WriteLine("b1 h = " + b1.Height);
            Console.WriteLine("b2 h = " + b2.Height);

            if (b1 > b2)
                Console.WriteLine("b1 > b2");
        }
    }
}