using System;

namespace Exercises
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // First exercise
            Console.Write("Enter radius of sphere please: ");
            string? input = Console.ReadLine();
            bool b = double.TryParse(input, out double r);
            while (b == false)
            {
                input = Console.ReadLine();
                b = double.TryParse(input, out r);
            }
            double surface = 4 * Math.PI * r * r;
            double volume = 4 / 3 * Math.PI * r * r * r;
            Console.WriteLine("Surface of the sphere is {0}", surface);
            Console.WriteLine("Volume of the sphere is {0}", volume);


            // Second exercise
            double x1, y1, x2, y2;
            Console.WriteLine("Enter cordinates of first point:");
            Console.Write("x: ");
            string? sx1 = Console.ReadLine();
            b = double.TryParse(sx1, out x1);
            while (b == false)
            {
                sx1 = Console.ReadLine();
                b = double.TryParse(sx1, out x1);
            }

            Console.Write("y: ");
            string? sy1 = Console.ReadLine();
            b = double.TryParse(sy1, out y1);
            while (b == false)
            {
                sy1 = Console.ReadLine();
                b = double.TryParse(sy1, out y1);
            }

            Console.WriteLine("Enter cordinates of second point:");
            Console.Write("x: ");
            string? sx2 = Console.ReadLine();
            b = double.TryParse(sx2, out x2);
            while (b == false)
            {
                sx2 = Console.ReadLine();
                b = double.TryParse(sx2, out x2);
            }

            Console.Write("y: ");
            string? sy2 = Console.ReadLine();
            b = double.TryParse(sy2, out y2);
            while (b == false)
            {
                sy2 = Console.ReadLine();
                b = double.TryParse(sy2, out y2);
            }

            double x = x2 - x1;
            double y = y2 - y1;
            double cx = x / 2 + x1;
            double cy = y / 2 + x2;

            Console.WriteLine("The lenght of line is {0}", Math.Sqrt(x * x + y * y));
            Console.WriteLine("X of center is {0} and Y of center is {1}", (decimal)cx, (decimal)cy);
            Console.WriteLine("Angle of line to x is {0}°", (180 / Math.PI) * (Math.Atan2(y, x)));
        }
    }
}