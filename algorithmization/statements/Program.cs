using System;

namespace Statements
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i = 1;
        start:
            Console.Write("{0},", i);
            i++;
            if (i < 10)
                goto start;
            else
                Console.WriteLine(i);

            int j = 10;
        second_start:
            if (j % 2 == 1)
                Console.WriteLine(j);
            j--;
            if (j > 0)
                goto second_start;
        }
    }
}