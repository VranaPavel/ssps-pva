using System;

namespace Exercises
{
    public class Program
    {
        // first exercise
        public static int[] Shuffle(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            int index = arr.Length - 1;
            foreach (int i in arr)
            {
                newArr[index] = i;
                index--;
            }
            return newArr;
        }

        public static void Main()
        {
            // first exercise
            int[] arr1 = [3, 2, 5, 7, 11, 13, 17];
            int[] newArr1 = Shuffle(arr1);
            foreach (int i1 in newArr1)
                Console.Write(i1 + " ");


            // second exercise
            int m2 = 5, n2 = 5;
            Random r2 = new Random();
            int[,] arr2 = new int[m2, n2];
            for (int i = 0; i < m2; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    arr2[i, j] = r2.Next(0, 1000);
                }
            }
            Console.Write("\n\n");

            for (int i = 0; i < m2; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    Console.Write($"{arr2[i, j]} ");
                }
                Console.Write("\n");
            }

            int biggestVal = 0;
            for (int i = 0; i < m2; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    if (arr2[i, j] > biggestVal)
                        biggestVal = arr2[i, j];
                }
            }
            Console.WriteLine($"Biggest value in array is {biggestVal}");

            int indexRow = -1;
            int indexColumn = -1;
            for (int i = 0; i < m2; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    if (arr2[i, j] == biggestVal)
                    {
                        indexRow = i;
                        indexColumn = j;
                    }
                }
            }
            Console.WriteLine($"Biggest value has {indexRow}. row index and {indexColumn}. column index");


            // third exercise
            int m3 = 6;
            Random r3 = new Random();
            double[,] arr3 = new double[m3, m3];
            for (int i = 0; i < m3; i++)
            {
                for (int j = 0; j < m3; j++)
                {
                    arr3[i,j] = r2.NextDouble();
                }
            }

            for (int i = 0; i < m3; i++)
            {
                Console.Write($"{arr3[i, i]} ");
            }
            Console.Write("\n");

            for (int i = 0; i < m3; i++)
            {
                Console.Write($"{arr3[2, i]} ");
            }
            Console.Write("\n");

            for (int i = 0; i < m3; i++)
            {
                Console.Write($"{arr3[arr3.GetLength(0) - 2, i]} ");
            }
            Console.Write("\n");

            for (int i = 0; i < m3; i++)
            {
                Console.Write($"{arr3[i, arr3.GetLength(1) - 2]}");
            }
            Console.Write($"\n");


            // fourth exercise
            int[,] arr4 = new int[5,5] { 
                {62, 96, 294, 72, 296},
                {146, 288, 232, 254, 234},
                {168, 303, 254, 276, 256},
                {314, 413, 24, 386, 43},
                {100, 199, 206, 172, 208}
            };

            string[] x4 = {"Brno", "Ceske Budejovice", "Cesky Krumlov", "Decin", "Havlickuv Brod"};
            string[] y4 = {"Znojmo", "Zlin", "Usti nad Labem", "Uherske hradiste", "Teplice"};

            string? firstInput4 = Console.ReadLine();
            string? secondInput4 = Console.ReadLine();
            string? thirdInput4 = Console.ReadLine();
            
            int firstIndex4 = -1;
            int secondIndex4 = -1;
            int thirdIndex4 = -1;
            for (int i = 0; i < x4.Length; i++)
            {
                if (firstInput4 == x4[i])
                {
                    firstIndex4 = i;
                }
                if (thirdInput4 == x4[i])
                {
                    thirdIndex4 = i;
                }
            }
            for (int i = 0; i < y4.Length; i++)
            {
                if (secondInput4 == y4[i])
                {
                    secondIndex4 = i;
                }
            }

            if (firstIndex4 == -1 || secondIndex4 == -1 || thirdIndex4 == -1)
            {                
                Console.WriteLine("Input error");
            }
            else
            {
                int distance4 = arr4[firstIndex4, secondIndex4];
                distance4 = distance4 + arr4[thirdIndex4, secondIndex4];
                Console.WriteLine("Distance between cities is {0}", distance4);
            }


            // fifth exercise - skipped
            // sixth exercise - skipped
            // seventh exercise - skipped
        }
    }
}