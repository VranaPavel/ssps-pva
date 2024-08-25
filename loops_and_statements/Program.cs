using System;

namespace LoopsAndStatements
{
    public class Program
    {
        static void Main(string[] args)
        {
            // first exercise
            string? s1 = Console.ReadLine();
            bool b1 = int.TryParse(s1, out int x1);
            while (b1 == false)
            {
                s1 = Console.ReadLine();
                b1 = int.TryParse(s1, out x1);
            }
            for (int i = 1; i <= x1; i++)
            {
                Console.Write("{0} ", i);
            }


            // second exercise
            int[] x2 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                string? s2 = Console.ReadLine();
                bool b2 = int.TryParse(s2, out int x2e);
                while (b2 == false)
                {
                    s2 = Console.ReadLine();
                    b2 = int.TryParse(s2, out x2e);
                }
                x2[i] = x2e;
            }
            int t1 = x2[0];
            for (int i = 0; i < x2.Length - 1; i++)
            {
                if (x2[i + 1] > t1)
                    t1 = x2[i + 1];
            }
            Console.WriteLine("\n\nBiggest number in this serie is {0}", t1);
            int t2 = x2[0];
            for (int i = 0; i < x2.Length - 1; i++)
            {
                if (x2[i + 1] < t2)
                    t2 = x2[i + 1];
            }
            Console.WriteLine("\n\nSmallest number in this serie is {0}", t2);


            // third exercise
            int z = 0;
            for (int i = 0; i < 10; i++)
            {

                string? s3 = Console.ReadLine();
                bool b3 = int.TryParse(s3, out int x3);
                while (b3 == false)
                {
                    s3 = Console.ReadLine();
                    b3 = int.TryParse(s3, out x3);
                }
                z = z + x3;
            }
            Console.WriteLine(z);

            z = 0;
            int i3 = 0;
            while (i3 < 10)
            {
                string? s3 = Console.ReadLine();
                bool b3 = int.TryParse(s3, out int x3);
                while (b3 == false)
                {
                    s3 = Console.ReadLine();
                    b3 = int.TryParse(s3, out x3);
                }
                z = z + x3;
                i3++;
            }
            Console.WriteLine(z);

            z = 0;
            i3 = 0;
            do
            {
                string? s3 = Console.ReadLine();
                bool b3 = int.TryParse(s3, out int x3);
                while (b3 == false)
                {
                    s3 = Console.ReadLine();
                    b3 = int.TryParse(s3, out x3);
                }
                z = z + x3;
                i3++;
            }
            while (i3 < 10);
            Console.WriteLine(z);


            // fourth exercise
            double sum4 = 0, average4;
            int[] A = { 2, 3, 5, 7, 11, 13, 17, 19, 23 };
            int[] B = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                B[i] = 0;
                sum4 += A[i];
                for (int j = i; j >= 0; j--)
                {
                    B[i] += A[j];
                }
            }
            average4 = sum4 / A.Length;

            Console.WriteLine("Sum of array is {0}", sum4);
            Console.WriteLine("Average of array is {0}", average4);
            Console.Write("Values of array B are ");
            for (int i = 0; i < B.Length; i++)
            {
                Console.Write("{0} ", B.GetValue(i));
            }


            // fifth exercise
            double z2 = 1;
            for (double i = 2; i < 10000; i += 2)
            {
                z2 = z2 + (1 / i) - (1 / (i + 1));
            }
            Console.WriteLine("Result is {0}", z2);


            // sixth exercise
            string? s6 = Console.ReadLine();
            bool b6 = int.TryParse(s6, out int x6);
            while (b6 == false)
            {
                s6 = Console.ReadLine();
                b6 = int.TryParse(s6, out x6);
            }
            Console.Write("These are numbers that devide N without remainder: ");
            for (int i = 1; i <= x6; i++)
            {
                if (x6 % i == 0)
                {
                    if (i == x6)
                        Console.Write(i);
                    else
                        Console.Write("{0}, ", i);
                }
            }

            // seventh exercise
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write("{0} * {1} = {2}\t", i, j, i * j);
                }
                Console.Write("\n");
            }
            

            // eighth exercise
            Console.Write("Please enter diameter of circle: ");
            string? s8 = Console.ReadLine();
            bool b8 = double.TryParse(s8, out double x8);
            while (b8 == false)
            {
                Console.Write("You have to enter decimal number. Please enter diameter of circle: ");
                s8 = Console.ReadLine();
                b8 = double.TryParse(s8, out x8);
            }
            Console.WriteLine("Area of circle is {0}", x8 * x8 * Math.PI);
            

            // nineth exercise
            Console.Write("Please enter your weight on the Earth: ");
            string? s9 = Console.ReadLine();
            bool b9 = double.TryParse(s9, out double x9);
            while (b9 == false)
            {
                Console.Write("You have to enter decimal number. Please enter your weight on the Earth: ");
                s9 = Console.ReadLine();
                b9 = double.TryParse(s9, out x9);
            }
            Console.WriteLine("Your weight on the Moon is {0}", x9 * 0.17);


            // tenth exercise
            Console.WriteLine(
                """
                How you would declare integer variable in v C#?
                a) int 1x = 10;
                b) int x = 10;
                c) float x = 10.0f;
                d) string x = "10";
                """
            );
            Console.Write("Enter correct answer ('a', 'b' , 'c' or 'd'): ");
            string? s10 = Console.ReadLine();
            while (true)
            {
                if (s10 == "b" || s10 == "c" || s10 == "d")
                {
                    Console.WriteLine("Wrong answer!");
                    break;
                }
                else if (s10 == "a")
                {
                    Console.WriteLine("Correct answer!");
                    break;
                }
                else
                {
                    Console.Write("You have to enter only 'a', 'b', 'c' or 'd': ");
                    s10 = Console.ReadLine();
                }
            }
            

            // eleventh exercise
            string? s11 = Console.ReadLine();
            while (s11 == null)
                s11 = Console.ReadLine();
            for (int i = s11.Length - 1; i >= 0; i--)
            {
                Console.Write("{0}", s11[i]);
            }
            

            // twelfth exercise
            // Skipped 'cause of math


            // thirtteenth exercise
            // Skipped 'cause of reason "What the fuck is this math???"


            // fourteenth exercise
            string? sf1 = Console.ReadLine();
            string? sf2 = Console.ReadLine();

            bool b141 = double.TryParse(sf1, out double f1);
            bool b142 = double.TryParse(sf2, out double f2);

            while (b141 == false)
            {
                sf1 = Console.ReadLine();
                b141 = double.TryParse(sf1, out f1);
            }
            while (b142 == false)
            {
                sf2 = Console.ReadLine();
                b142 = double.TryParse(sf2, out f2);
            }

            double f = (f1 * f1) + (f2 * f2);
            f = Math.Sqrt(f);
            Console.WriteLine("Final strenght is: {0}", f);
            

            // fifteenth exercise
            string? s15 = Console.ReadLine();
            bool b15 = int.TryParse(s15, out int x15);
            while (b15 == false)
            {
                s15 = Console.ReadLine();
                b15 = int.TryParse(s15, out x15);
            }
            Console.Write("These are prime numbers: ");
            for (int i = 2; i < x15; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (i % j == 0)
                        if (j != 1 && j != i)
                            break;
                    if (j == 1)
                        Console.Write("{0} ", i);
                }
            }
            

            // sixteenth exercise
            for (int i = 0; i < 10; i++)
            {
                string? s, t;
                do
                {
                    s = Console.ReadLine();
                    t = Console.ReadLine();
                }
                while (s == null || t == null);
                if (s.Contains(t) == true)
                {
                    Console.WriteLine("\"{0}\" is contained in the string \"{1}\"", t, s);
                }
            }
        }
    }
}