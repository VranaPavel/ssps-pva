using System;

namespace Hello_world
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> names = new List<string>();
            while(true)
            {
                Console.Write("Please write down your name: ");
                string? s = Console.ReadLine();

                /* if (s == "Jana" || s == "Honza" || s == "Eva" || s == "Tomáš")
                {
                    Console.WriteLine("Hello {0}!", s);
                }
                else
                {
                    Console.WriteLine("Hello, I don't know who you are!");
                } */

                if (s == null)
                {
                    Console.WriteLine("Hello, I don't know who you are!");
                }
                else if (names.Contains(s))
                {
                    Console.WriteLine("Hello {0}!", s);
                }
                else
                {
                    Console.WriteLine("Hello, I don't know who you are!");
                    names.Add(s);
                }
            }
        }
    }
}