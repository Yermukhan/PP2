using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            Rectangle rectangle = new Rectangle(8,9 );
            Circle circle = new Circle(0, 5, 16);
            shapes.Add(rectangle);
            shapes.Add(circle);

            foreach (Shape shape in shapes)
            {
                if (shape.GetType() == typeof(Rectangle))
                {
                    Console.WriteLine(shape.x + " " + shape.y);
                }
                if (shape.GetType() == typeof(Circle))
                {
                    Console.WriteLine(shape.x + " " + shape.y + " " + ((Circle)shape).r);
                }
               
            }
            Console.ReadKey();
        }
        
    }
   
}
