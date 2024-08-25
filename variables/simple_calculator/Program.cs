using System;

namespace Simple_calculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            string? i1 = Console.ReadLine();
            string? i2 = Console.ReadLine();

            bool t1 = double.TryParse(i1, out double v1);
            bool t2 = double.TryParse(i2, out double v2);
            while (t1 == false || t2 == false)
            {
                i1 = Console.ReadLine();
                i2 = Console.ReadLine();
                t1 = double.TryParse(i1, out v1);
                t2 = double.TryParse(i2, out v2);
            }

            string? i3 = Console.ReadLine();
            
            switch(i3)
            {
                case "+":
                    Console.WriteLine(v1 + v2);
                    break;
                case "-":
                    Console.WriteLine(v1 - v2);
                    break;
                case "*":
                    Console.WriteLine(v1 * v2);
                    break;
                case "/":
                    Console.WriteLine(v1 / v2);
                    break;
                case "pow":
                    Console.WriteLine(Math.Pow(v1, v2));
                    break;
                case "sqrt":
                    Console.WriteLine(Math.Sqrt(v1));
                    Console.WriteLine(Math.Sqrt(v2));
                    break;
                default:
                    Console.WriteLine("Bad operation.");
                    break;
            }
        }
    }
}