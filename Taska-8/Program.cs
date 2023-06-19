using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taska_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            Console.WriteLine("Please enter data of 10 different shapes");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Type a name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Please select the right shape: Circle or Square: Press 1 or 2");
                int rightShape = int.Parse(Console.ReadLine());
                switch (rightShape)
                {
                    case 1:
                        Console.Write("Enter the radius: ");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        shapes.Add(new Circle(name, radius));
                        break;
                    case 2:
                        Console.Write("Enter the side length: ");
                        double side = Convert.ToDouble(Console.ReadLine());
                        shapes.Add(new Square(name, side));
                        break;
                    default:
                        Console.WriteLine("Invalid shape type.");
                        break;
                }

            }

            Console.WriteLine("All shapes:");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Name: {shape.Name}");
                Console.WriteLine($"Area: {shape.Area()}");
                Console.WriteLine($"Perimeter: {shape.Perimeter()}");
            }

            //The largets perimeter
            double largestPerimeter = shapes.Max(x => x.Perimeter());
            Console.WriteLine("The largest perimeter is: " + $"{largestPerimeter}");

            // Sorted shapes by area
            var sortedShapesByArea = shapes.OrderByDescending(x => x.Area());

            foreach (var z in sortedShapesByArea)
            {
                Console.WriteLine($"{z.Name} - {z.Area()} - {z.Perimeter()}");
            }

            Console.ReadKey();
        }
    }
}
