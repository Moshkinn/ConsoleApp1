using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        public interface Shape
        {
            void Draw();
        }
        class Circle : Shape
        {
            public  void Draw()
            {
                // draw a circle...
                Console.WriteLine("Circle Draw");
            }
        }
        class Rectangle : Shape
        {
            public  void Draw()
            {
                // draw a rectangle...
                Console.WriteLine("Rect Draw");
            }
        }
        class Car
        {
            string name;
            public Car(string nm)
            {
                name = nm;
                Motor m = new Motor();
            }
            public class Motor
            {
                // some code
                public Motor()
                {
                    Console.WriteLine("new motor");
                }
                
            }
        }
        static void Main(string[] args)
        {
            Car a = new Car("Merc");
            
            Shape c = new Circle();
            c.Draw();

            Console.ReadLine();
        }
    }
}
