using System;

namespace Operators
{
    public class Program
    {
        public static void Main(string[] args)
        {         
            // first exercise
            string? s = Console.ReadLine();
            bool b = int.TryParse(s, out int x);
            while (b == false)
            {
                s = Console.ReadLine();
                b = int.TryParse(s, out x);
            }
            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                    Console.WriteLine(i);
            }

            // second exercise
            int a1 = 3, b1 = 5;
            Console.WriteLine("{0} {1} {2} {3} {4}", a1 > b1, a1 != b1, a1 + b1 > 10, (a1 + b1 > 10) || (a1 - b1 < 0), (a1 + b1 == 8) && (b1 - a1 == 2));

            // third exercise
            byte a2 = 3, b2 = 5;
            Console.WriteLine("{0} {1} {2} {3}", a2 & b2, a2 | b2, a2 ^ b2, ~a2 & b2);

            // fourth exercise
            int a3 = 5, b3 = 4;
            int[] array = {a3 + b3, a3 + (b3++), a3 + b3, a3 + (++b3), a3 + b3, 14 / a3, 14 % a3, (b3 % 3) * a3, b3 ^ a3, ~(b3 ^ a3)};
            for (int j = 0; j < array.Length; j++)
                Console.Write("{0} ", array[j]);

            // fifth exercise
            Console.WriteLine("\n\n\nRectangle programm 1.0\n");
            Console.Write("Enter width: ");
            string? s1 = Console.ReadLine();
            Console.Write("Enter height:");
            string? s2 = Console.ReadLine();

            bool check1 = double.TryParse(s1, out double width);
            bool check2 = double.TryParse(s2, out double height);
            while (check1 == false || check2 == false)
            {
            Console.Write("Enter width: ");
            s1 = Console.ReadLine();
            Console.Write("Enter height:");
            s2 = Console.ReadLine();
            check1 = double.TryParse(s1, out width);
            check2 = double.TryParse(s2, out height);
            }

            Console.WriteLine("Area of rectangle is {0}", width * height);
        }
    }
}
