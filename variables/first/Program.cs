using System;

namespace First
{
    class Program
    {
        public static void Main(string[] args)
        {
            double x = 2.5;
            decimal y = 2.5m;
            float z = 2.5f;
            string s = "Práce šla \"hladce\", jak nám říkali.";
            char c = 'Z';

            const int a = 2;
            

            Console.WriteLine("{0} {1} {2} {3} {4} {5}", x, y, z, s, c, a);


            for (decimal i = 0.0m; i <= 1; i = i + 0.05m)
            {
                Console.WriteLine("{0} ... {1}", i, (decimal)Math.Pow((double)i, 2));
            }
        }
    }
}