using System;
using System.Runtime.Intrinsics.Arm;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // first exercise
            
            Console.Write("Elements of array are: ");
            int[] a1 = new int[20];
            for (int i = 0; i < a1.Length; i++)
            {
                a1[i] = i * 5;
                Console.Write("{0} ", a1[i]);
            }
            Console.Write("\n\n");


            // second exercise
            string?[] a21 = new string[10];
            string?[] a22 = new string[10];

            for (int i = 0; i < a21.Length; i++)
            {
                Console.Write("Please enter {0}. value of first array: ", i + 1);
                a21[i] = Console.ReadLine();
            }
            for (int i = 0; i < a22.Length; i++)
            {
                Console.Write("Please enter {0}. value of second array: ", i + 1);
                a22[i] = Console.ReadLine();
            }
            for (int i = 0; i < a22.Length; i++)
            {
                if (a21[i] != a22[i])
                {
                    Console.WriteLine("Arrays are not same!");
                    break;
                }
                if (i == a22.Length - 1)
                    Console.WriteLine("Arrays are same!");
            }


            // third exercise - with array
            string? s31;
            do
            {
                s31 = Console.ReadLine();
            }
            while (s31 == null);
            string[] a31 = new string[s31.Length];
            int z = 0;
            for (int i = 0; i < s31.Length; i++)
            {
                if (s31[i] == '.' || s31[i] == ',' || s31[i] == ';' || s31[i] == '\t' || s31[i] == ' ')
                    z++;
                else
                    a31[z] = a31[z] + s31[i];
            }
            for (int i = 0; i < a31.Length; i++)
                Console.Write("{0} ", a31.GetValue(i));


            // third exercise with list
            string? s32;
            List<string> a32 = new List<string>();
            z = 0;
            do
            {
                s32 = Console.ReadLine();
            } while (s32 == null);
            for (int i = 0; i < s32.Length; i++)
            {
                if (i == 0)
                    a32.Add(s32[i].ToString());
                else if (s32[i] == ',' || s32[i] == '.' || s32[i] == '\t' || s32[i] == ';' || s32[i] == ' ')
                {
                    z++;
                    i++;
                    a32.Add(s32[i].ToString());
                }
                else
                {
                    string tempval = a32[z] + s32[i];
                    a32.RemoveAt(z);
                    a32.Add(tempval);
                }
            }
            for (int i = 0; i < a32.Count(); i++)
                Console.Write("{0} ", a32[i]);


            // fourth exercise
            string?[] a4 = new string[9];
            for (int i = 0; i < a4.Length; i++)
                a4[i] = Console.ReadLine();

            for (int i = 0; i < a4.Length / 2 + 1; i++)
            {
                if (a4[i] != a4[(a4.Length - 1) - i])
                {
                    Console.WriteLine("Array is not symetric.");
                    break;
                }
                else if (i == (a4.Length / 2))
                    Console.WriteLine("Array is symetric.");
            }


            // fifth exercise
            int[] a5 = {1, 2, -3, 5, -6, 0, 2};
            int z5 = 0;
            for (int i = 0; i < a5.Length; i++)
            {
                if(a5[i] < 0)
                {
                    z5++;
                    if(z == 2)
                    {
                        Console.WriteLine("Index = {0}", i);
                        Console.WriteLine("Hodnota = {0}", a5[i]);
                    }
                }
            }


            // sixth exercise
            List<string> a6A = new List<string>() {"dsadsa", "sa", "asdsad", "fga"};
            List<string> a6B = new List<string>() {"sadasd", "fa", "dsadsa", "sa", "hjgfcdxgchjb"};
            List<string> a6C = new List<string>();

            for(int i = 0; i < a6A.Count(); i++)
                a6C.Add(a6A[i]);
            for (int i = 0; i < a6B.Count(); i++)
            {
                if (a6C.Contains(a6B[i]))
                {
                    continue;
                } 
                else
                {
                    a6C.Add(a6B[i]);
                }
            }
            for (int i = 0; i < a6C.Count; i++)
            {
                Console.Write("{0} ", a6C[i]);
            }


            // seventh exercise
            List<string> a7A = new List<string>() { "dsadsa", "sa", "asdsad", "fga" };
            List<string> a7B = new List<string>() { "sadasd", "fa", "dsadsa", "sa", "hjgfcdxgchjb" };
            List<string> a7C = new List<string>();

            if (a7A.Count() > a7B.Count())
            {
                for (int i = 0; i < a7A.Count(); i++)
                {
                    if (a7B.Contains(a7A[i]))
                    {
                        a7C.Add(a7A[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < a7B.Count(); i++)
                {
                    if (a7A.Contains(a7B[i]))
                    {
                        a7C.Add(a7B[i]);
                    }
                }
            }
            for (int i = 0; i < a7C.Count(); i++)
            {
                Console.Write("{0} ", a7C[i]);
            }


            // nineth exercise
            int[] a9P = { 1, 4, 3, 2, 3, 4, 4, 1 };
            for (int i = 1; i < a9P.Count(); i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    if (a9P[i] == a9P[j])
                    {
                        a9P[i] = 0;
                    }
                }
            }
            for (int i = 0; i < a9P.Count(); i++)
            {
                Console.Write("{0} ", a9P[i]);
            }


            // tenth exercise
            int[] a10 = {8, 6, 1, 3, 0, 5, 2};
            for (int i = 1; i < a10.Length; i++)
            {
                for (int j = 0; j < a10.Length - i; j++)
                {
                    if (a10[j] > a10[j + 1])
                    {
                        int swap = a10[j + 1];
                        a10[j + 1] = a10[j];
                        a10[j] = swap;
                    }
                }
            }
            for (int i = 0; i < a10.Length; i++)
                Console.Write("{0} ", a10[i]);


            // eleventh exercise
            List<string> a11 = new List<string>();
            string? s11;
            do
            {
                s11 = Console.ReadLine();
            } while (s11 == null);
            Console.WriteLine("| Písmeno | Absolutní výskyt |       Relativní výskyt       |");
            for (int i = 0; i < s11.Length; i++)
            {
                a11.Add(s11[i].ToString());
            }
            a11.Sort();
            List<string> a11chars = new List<string>();
            for (int i = 0; i < a11.Count(); i++)
            {
                if (a11chars.Contains(a11[i]))
                {
                    continue;
                }
                else
                {
                    a11chars.Add(a11[i]);
                    int j = i;
                    decimal count = 0;
                    while (a11[j] == a11[i])
                    {
                        count++;
                        j++;
                        if (j == a11.Count())
                            break;
                    }
                    Console.WriteLine("|   {0}     |         {1}        |         {2}       |", a11[i], count, count / ((decimal)a11.Count() / 100));
                }
            }


            // twelveth exercise
            string[] a12 = { "Hello", "world", "in", "a", "frame" };
            Console.WriteLine("**************************");
            for (int i = 0; i < a12.Length; i++)
                Console.WriteLine("* \t {0} \t\t *", a12[i]);
            Console.WriteLine("**************************");


            // thirteenth exercise
            string? s13;
            do 
            {
                s13 = Console.ReadLine();
            } while (s13 == null);
            List<string> a13 = new List<string>();
            List<string> a13new = new List<string>();
            a13.Add(s13[0].ToString());
            for (int i = 1; i < s13.Length; i++)
            {
                if (s13[i] == ' ')
                {
                    i++;
                    a13.Add(s13[i].ToString());    
                }
                else
                {
                    string x = a13[a13.Count() - 1] + s13[i];
                    a13.RemoveAt(a13.Count() - 1);
                    a13.Add(x);
                }
            }
            for (int i = 0; i < a13.Count(); i++)
            {
                Console.Write("{0} ", a13[i]);
            }
            for (int i = 0; i < a13.Count(); i++)
            {
                char x = a13[i][0];
                if (x > 66 && x < 76)
                {
                    a13new.Add(a13[i]);
                }
            }
            Console.Write("\n");
            for (int i = 0; i < a13new.Count(); i++)
            {
                Console.Write("{0} ", a13new[i]);
            }
            Console.Write("\n");
            for (int i = 0; i < a13.Count(); i++)
            {
                if (a13new.Contains(a13[i]))
                    continue;
                else
                    Console.Write("{0} ", a13[i]);
            }


            // fourteenth exercise
            bool b14 = false;
            List<double> a14 = new List<double>();
            while (b14 == false)
            {
                string? s14;
                do
                {
                    s14 = Console.ReadLine();
                } while (s14 == null);

                List<string> a14s = new List<string>();
                a14s.Add(s14[0].ToString());
                for (int i = 1; i < s14.Length; i++)
                {
                    if (s14[i] == ' ')
                    {
                        if (i == s14.Length - 1)
                            break;
                        i++;
                        a14s.Add(s14[i].ToString());
                    }
                    else
                    {
                        string x = a14s[a14s.Count() - 1] + s14[i];
                        a14s.RemoveAt(a14s.Count() - 1);
                        a14s.Add(x);
                    }
                }

                for (int i = 0; i < a14s.Count(); i++)
                {
                    bool b = double.TryParse(a14s[i], out double x);
                    if (b == false)
                    {
                        b14 = false;
                        break;
                    }
                    else
                    {
                        a14.Add(x);
                        b14 = true;
                    }
                }
            }

            a14.Sort();
            double min = a14[0], max = a14[0];
            double median = 0, diameter = 0;
            double[] deviations = new double[a14.Count()];
            for (int i = 0; i < a14.Count(); i++)
            {
                if (min > a14[i])
                    min = a14[i];
                if (max < a14[i])
                    max = a14[i];
                diameter += a14[i];
            }
            diameter /= a14.Count();
            if (a14.Count() % 2 == 1)
            {
                median = a14[a14.Count() / 2];
            }
            else
            {
                median = (a14[a14.Count() / 2 - 1] + a14[a14.Count() / 2]) / 2;
            }
            double[] deviation = new double[a14.Count()];
            for (int i = 0; i < a14.Count(); i++)
            {
                deviation[i] = a14[i] - diameter;
            }

            string[] textInTable = {"Minimum", "Maximum", "Median", "Diameter"};
            double[] valuesInTable = {min, max, median, diameter};
            Console.WriteLine("--------------------------");
            for(int i = 0; i < textInTable.Length; i++)
                Console.WriteLine("| {0} \t| {1}\t |", textInTable[i], valuesInTable[i]);
            Console.WriteLine("--------------------------");
            for (int i = 0; i < deviation.Length; i++)
                Console.WriteLine("| Dev. of {0} \t| {1}\t |", a14[i], deviation[i]);
            Console.WriteLine("--------------------------");


            // fifteenth exercise
            string? s15;
            bool b15;
            double x15;
            do {
                Console.Write("Enter temperature: ");
                s15 = Console.ReadLine();
                b15 = double.TryParse(s15, out x15);
            } while (s15 == null || b15 == false);
            string? choice;
            do {
                Console.Write("Enter 'C' for convertion from Celsius to Fahrenheits or 'F' for convertion from Fahrenheits to Celsius: ");
                choice = Console.ReadLine();
            } while (choice == null || choice != "C" && choice != "F");
            if (choice == "C")
            {
                Console.WriteLine("Temperature of {0}˚C is {1}˚F", x15, x15 * 1.8 + 32);
            }
            else
            {
                Console.WriteLine("Temperature of {0}˚F is {1}˚C", x15, (x15 - 32) / 1.8);
            }
        }
    }
}
