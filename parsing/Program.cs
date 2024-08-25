using System;

namespace Parsing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter first decimal number: ");
            string? s1 = Console.ReadLine();
            Console.Write("Enter second decimal number: ");
            string? s2 = Console.ReadLine();

            bool b1 = double.TryParse(s1, out double d1);
            bool b2 = double.TryParse(s2, out double d2);

            while (b1 == false || b2 == false)
            {
                if (s1 == "" || s2 == "" || s1 == null || s2 == null)
                {
                    Console.Write("Type 'yes' to exit programm: ");
                    string? e = Console.ReadLine();
                    if (e == "yes")
                        return;
                }

                Console.WriteLine("You entered bad input, you should enter two decimal numbers - use dot. Enter numbers again please.\n");
                Console.Write("Enter first decimal number: ");
                s1 = Console.ReadLine();
                Console.Write("Enter second decimal number: ");
                s2 = Console.ReadLine();
            }

            Console.WriteLine(Math.Sqrt((d1 * d1) + (d2 * d2)));
        }
    }
}