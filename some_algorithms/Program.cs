using System;
using System.ComponentModel;

namespace some_algorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // first exercise
            string? s1;
            bool b1;
            int x1;
            do
            {
                Console.Write("Please enter number N: ");
                s1 = Console.ReadLine();
                b1 = int.TryParse(s1, out x1);
            } while (s1 == null || b1 == false);

            List<int> primeNumbers1 = new List<int>();
            int tmpVal1 = 2;
            for (int i = 0; i < x1;)
            {
                for (int j = 2; j <= tmpVal1; j++)
                {
                    if (j == tmpVal1)
                    {
                        primeNumbers1.Add(j);
                        i++;
                    }
                    else if (tmpVal1 % j == 0)
                    {
                        break;
                    }
                }
                tmpVal1++;
            }
            Console.Write("Prime numbers: ");
            for (int i = 0; i < primeNumbers1.Count(); i++)
            {
                Console.Write("{0} ", primeNumbers1[i]);
            }


            // second exercise
            string? s2a, s2b;
            bool b2a, b2b;
            int x2N, x2M;
            do
            {
                Console.Write("\n\nEnter number N please: ");
                s2a = Console.ReadLine();
                Console.Write("Enter number M please: ");
                s2b = Console.ReadLine();
                b2a = int.TryParse(s2a, out x2N);
                b2b = int.TryParse(s2b, out x2M);
            } while (b2a == false || b2b == false);

            Console.Write("Prime numbers from {0} to {1} are: ", x2N, x2M);
            for (int i = x2N; i <= x2M; i++)
            {
                for (int j = 2; j <= i; j++)
                {
                    if (j == i)
                    {
                        Console.Write("{0} ", j);
                    }
                    else if (i % j == 0)
                    {
                        break;
                    }
                }
            }


            // third exercise
            int[] a3 = {15, 1, 96, 42, 5, -17, 6, 28, 34, 10};
            int min3 = a3[0], max3 = a3[0], diameter3 = 0;
            for (int i = 0; i < a3.Length; i++)
            {
                if (a3[i] < min3)
                    min3 = a3[i];
                if (a3[i] > max3)
                    max3 = a3[i];
                diameter3 += a3[i];
            }
            diameter3 /= a3.Length;
            Console.WriteLine("\n\nSmallest element of array is: {0}", min3);
            Console.WriteLine("Biggest element of array is: {0}", max3);
            Console.WriteLine("Diameter of array is: {0}", diameter3);


            // fourth exercise
            int[] a4 = {15, 1, 96, 42, 5, -17, 6, 28, 34, 10};
            int min4 = a4[0], max4 = a4[0], secondMin4 = a4[0], secondMax4 = a4[0], diameter = 0;
            
            for (int i = 0; i < a4.Length; i++)
            {
                if (a4[i] < min4)
                    min4 = a4[i];
                if (a4[i] > max4)
                    max4 = a4[i];
            }
            for (int i = 0; i < a4.Length; i++)
            {
                if (a4[i] > min4 && a4[i] < secondMin4)
                    secondMin4 = a4[i];
                if (a4[i] < max4 && a4[i] > secondMax4)
                    secondMax4 = a4[i];
            }

            int[] a4New = new int[a4.Length - 2];
            int j4 = 0;
            for (int i = 0; i < a4.Length; i++)
            {
                if (a4[i] != min4 && a4[i] != max4)
                {
                    a4New[j4] = a4[i];
                    diameter += a4New[j4];
                    j4++;
                }   
            }
            diameter /= a4New.Length;
            Console.WriteLine("\nSmallest element of array is: {0}", min4);
            Console.WriteLine("Biggest element of array is: {0}", max4);
            Console.WriteLine("Second smallest element of array is: {0}", secondMin4);
            Console.WriteLine("Second biggest element of array is: {0}", secondMax4);
            Console.WriteLine("Diameter of array without biggest and smallest element is: {0}", diameter);
        }

        // fifth exercise
        
    }
}