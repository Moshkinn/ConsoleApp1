using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        struct Point
        {
            public int x;
            public int y;
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        enum Days { Sun=1, Mon, Tue, Wed, Thu, Fri, Sat };

        static void Main(string[] args)
        {
            Days d = Days.Sat;

            Console.WriteLine("day  - " + d);

            switch (d)
            {
                case Days.Fri:
                    Console.WriteLine("no work! but home! ");
                    break;
                case Days.Sat:
                    Console.WriteLine("no work! it is sat!");
                    break;
            }


            Console.ReadLine();
        }
    }
}

