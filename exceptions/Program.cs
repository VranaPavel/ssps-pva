using System;
using System.Net;

namespace ExceptionsExercises
{
    public class Program
    {
        // third exercise
        public static int ReadInt()
        {
            bool b; int x;
            do
            {
                string? s = Console.ReadLine();
                b = int.TryParse(s, out x);
            }
            while (b == false);
            return x;
        }

        // fourth exercise
        public static double Fourth(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("One side is bigger than sum of two another");
            }
            return a + b + c;
        }

        // fifth exercise
        public static bool IsPrimenumber(int input)
        {
            try
            {
                for (int i = 2; i < input; i++)
                {
                    if (input % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (FormatException)
            {
                throw new ArgumentException("Not an integer");
            }
        }

        // seventh exercise
        public static void Seventh()
        {
            try
            {
                string? input = Console.ReadLine();
                Console.WriteLine(Convert.ToDouble(input) * 2);
            }
            catch
            {
                throw new ArgumentException("Not a number");
            }
        }

        // eighth exercise
        public static char[] Deduplicate(char[] input)
        {
            if (input.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            List<char> tmpList = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (tmpList.Contains(input[i]))
                {
                    continue;
                }
                else
                {
                    tmpList.Add(input[i]);
                }
            }

            char[] newArr = new char[tmpList.Count];
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = tmpList[i];
            }

            return newArr;
        }


        public static void Main()
        {
            // first exercise
            try
            {
                string? s1 = Console.ReadLine();
                double d1 = Convert.ToDouble(s1);
                d1 = Math.Sqrt(d1);
                if (d1 == double.NaN)
                    Console.WriteLine("Incorrect number");
                else
                    Console.WriteLine(d1);
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect number");
            }


            // second exercise
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    string? s1 = Console.ReadLine();
                    string? s2 = Console.ReadLine();
                    int i1 = Convert.ToInt32(s1);
                    int i2 = Convert.ToInt32(s2);

                    Console.WriteLine(i1 / i2);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Format exception");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Devidion by zero is not acceptable");
                }


                // third exercise
                string[] sArr =
                {
                    "dsadadsa", "dsaddwq", "wertr", "xczxvb", "yttrreww",
                    "dsavxzc", "fdsgfddsq", "dsacxzcx"
                };

                try
                {
                    int i3 = ReadInt();
                    Console.WriteLine(sArr[i3]);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Index is out of range");
                }


                // fourth exercise
                Console.WriteLine(Fourth(12.5, 14.1, 13.8));
                Console.WriteLine(Fourth(11.3, 62.4, 23.1));


                // fifth exercise
                Console.WriteLine(IsPrimenumber(1777));


                // sixth exercise
#pragma warning disable SYSLIB0014 // Type or member is obsolete
                WebClient client = new WebClient();
#pragma warning restore SYSLIB0014 // Type or member is obsolete

                string reply = client.DownloadString("https://ssps.cz");
                Console.WriteLine(reply);


                // seventh exercise
                Seventh();


                // eighth exercise
                char[] input = { 'A', 'a', 'j', 'a', 'e', 'E', 'J', 'a', 'e' };
                char[] output = Deduplicate(input);
                for (int i8 = 0; i8 < output.Length; i8++)
                    Console.WriteLine(output[i]);
            }
        }
    }
}
