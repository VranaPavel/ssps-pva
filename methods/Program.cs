using System;

namespace Methods
{
    public class Program
    {
        public static void Main()
        {
            // first exercise
            int[] a1 = { 45, 1, 87, 19, 27 };
            Console.WriteLine(M1(a1) + "\n");

            // second exercise
            Console.WriteLine(M2a(6));
            Console.WriteLine(M2b(80, 5));
            Console.WriteLine(M2c("aedasd"));
            string s = "wasd", t = "qwerty";
            M2d(ref s, ref t);
            Console.WriteLine("Value of 's' is {0} and value of 't' is {1}", s, t);
            string[] str2e = { "dfsdfsf", "dfsfsdfsfsd", "saderfewfg", "adffsfdsf", "fdsdfsdsdf", "sdfdsfsdf" };
            int[] a2e = M2e(str2e);
            for (int i = 0; i < a2e.Length; i++)
                Console.Write("{0} ", a2e[i]);
            Console.Write("\n\n");

            // third exercise
            char[] a3 = { 'A', 'F', 'C', 'E', 'T', 'G', 'P' };
            char c = 'G';
            Console.WriteLine(M3(a3, c) + "\n");

            // fourth exercise
            // skipped 'cause of math

            // fifth exercise
            int[] firstArr5 = { 45, 5, 26, 34, 7, 12, 97 };
            int[] secondArr5 = { 7, 3, 6, 5, 4, 0 };
            int min5 = 0, max5 = 0;
            Console.WriteLine(M5a(firstArr5));
            M5b(secondArr5, ref min5, ref max5);
            Console.WriteLine("Min is {0} and max is {1}\n", min5, max5);

            // sixth exercise
            string s6 = "HELLOWORLD";
            string s6New = Encrypt(s6, 74);
            Console.WriteLine(Decrypt(s6New, 74));

            // seventh exercise
            string s7 = "Gone";
            string s7Encoded = morseEncode(s7);
            Console.WriteLine(s7Encoded);
            Console.WriteLine(morseDecode(s7Encoded));

            // eighth exercise
            int[] a8 = { 1, 3, 5, 9, 1, 0, 8 };
            int[] a8Vals = M8(a8);
            for (int i = 0; i < a8Vals.Length; i++)
                Console.WriteLine("{0}", a8Vals[i]);

            // nineth exercise
            int num9 = 1777;
            Console.WriteLine(M9(num9));

            // tenth exercise
            int num10 = 10;
            Console.WriteLine("\nOnly {0} teams can play game with {1} matches", M10(num10), num10);

            // eleventh exercise
            double a11 = 4, b11 = 6;
            M11(ref a11, ref b11);
            Console.WriteLine("\nValue of a is {0} and value of b is {1}", a11, b11);

        }

        // first exercise
        public static int M1(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        // second exercise
        public static bool M2a(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static double M2b(double num1, double num2)
        {
            return num1 / num2;
        }

        public static int M2c(string s)
        {
            bool b = int.TryParse(s, out int x);
            if (b == true)
            {
                return x;
            }
            else
            {
                return int.MinValue;
            }
        }

        public static void M2d(ref string s, ref string t)
        {
            string? tmpVal = s;
            s = t;
            t = tmpVal;
        }

        public static int[] M2e(string[] strArr)
        {
            int[] array = new int[strArr.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = strArr[i].Length;
            }
            return array;
        }

        // third exercise
        public static int M3(char[] charArr, char c)
        {
            for (int i = 0; i < charArr.Length; i++)
            {
                if (c == charArr[i])
                {
                    return i;
                }
            }
            return -1;
        }

        // fourth exercise
        // skipped 'cause of math

        // fifth exercise
        public static int M5a(int[] arr)
        {
            int x = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                x += arr[i];
            }
            return x / arr.Length;
        }

        public static void M5b(int[] arr, ref int min, ref int max)
        {
            min = arr[0];
            max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
                if (arr[i] > max)
                    max = arr[i];
            }
        }

        // sixth exercise
        public static string Encrypt(string strToEncrypt, int shift)
        {
            string newString = "";
            for (int i = 0; i < strToEncrypt.Length; i++)
            {
                char newChar = Convert.ToChar(strToEncrypt[i] + shift);
                while (newChar > 90)
                    newChar -= Convert.ToChar(26);
                newString += newChar;
            }
            return newString;
        }

        public static string Decrypt(string strToDecrypt, int shift)
        {
            string newString = "";
            for (int i = 0; i < strToDecrypt.Length; i++)
            {
                while (shift > 52)
                    shift -= 26;
                char newChar = Convert.ToChar(strToDecrypt[i] - shift);
                while (newChar < 65)
                    newChar += Convert.ToChar(26);
                newString += newChar;
            }
            return newString;
        }

        // seventh exercise
        public static string morseEncode(string str)
        {
            string newStr = "";

            string[] morseAlphabet =
            {
            ".-",    // A
            "-...",  // B
            "-.-.",  // C
            "-..",   // D
            ".",     // E
            "..-.",  // F
            "--.",   // G
            "....",  // H
            "..",    // I
            ".---",  // J
            "-.-",   // K
            ".-..",  // L
            "--",    // M
            "-.",    // N
            "---",   // O
            ".--.",  // P
            "--.-",  // Q
            ".-.",   // R
            "...",   // S
            "-",     // T
            "..-",   // U
            "...-",  // V
            ".--",   // W
            "-..-",  // X
            "-.--",  // Y
            "--.."   // Z
        };
            char[] alphabetUppercase =
            {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
        };
            char[] alphabetLowercase =
            {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
            'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
        };

            for (int i = 0; i < str.Length; i++)
            {
                if (alphabetLowercase.Contains(str[i]))
                {
                    for (int j = 0; j < alphabetLowercase.Length; j++)
                    {
                        if (alphabetLowercase[j] == str[i])
                        {
                            newStr += morseAlphabet[j];
                            if (i != str.Length - 1)
                                newStr += " ";
                        }
                    }
                }
                else if (alphabetUppercase.Contains(str[i]))
                {
                    for (int j = 0; j < alphabetUppercase.Length; j++)
                    {
                        if (alphabetUppercase[j] == str[i])
                        {
                            newStr += morseAlphabet[j];
                            if (i != str.Length - 1)
                            {
                                newStr += " ";
                            }
                        }
                    }
                }
                else
                {
                    return "Error while encoding.";
                }
            }
            return newStr;
        }

        public static string morseDecode(string str)
        {
            string newStr = "";

            string[] morseAlphabet =
            {
            ".-",    // A
            "-...",  // B
            "-.-.",  // C
            "-..",   // D
            ".",     // E
            "..-.",  // F
            "--.",   // G
            "....",  // H
            "..",    // I
            ".---",  // J
            "-.-",   // K
            ".-..",  // L
            "--",    // M
            "-.",    // N
            "---",   // O
            ".--.",  // P
            "--.-",  // Q
            ".-.",   // R
            "...",   // S
            "-",     // T
            "..-",   // U
            "...-",  // V
            ".--",   // W
            "-..-",  // X
            "-.--",  // Y
            "--.."   // Z
        };

            char[] alphabetLowercase =
            {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
            'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
        };

            List<string> morseList = new List<string>();
            for (int i = 0; i < str.Length; i++)
            {
                morseList.Add(str[i].ToString());
                if (i == str.Length - 1)
                    break;
                i++;
                while (str[i] != ' ')
                {
                    char tmpChar = str[i];
                    string tmpStr = morseList[morseList.Count() - 1] + tmpChar;
                    morseList.RemoveAt(morseList.Count - 1);
                    morseList.Add(tmpStr);

                    if (i == str.Length - 1)
                        break;
                    i++;
                }
            }

            for (int i = 0; i < morseList.Count; i++)
            {
                for (int j = 0; j < morseAlphabet.Length; j++)
                {
                    if (morseList[i] == morseAlphabet[j])
                    {
                        newStr += alphabetLowercase[j];
                        break;
                    }
                }
            }

            return newStr;
        }

        // eighth exercise
        public static int[] M8(int[] arr)
        {
            int[] values = new int[2];
            int diff = 0, tmpDiff;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                tmpDiff = Math.Abs(arr[i] - arr[i + 1]);
                if (tmpDiff >= diff)
                {
                    diff = tmpDiff;
                    values[0] = arr[i];
                    values[1] = arr[i + 1];
                }
            }
            return values;
        }

        // nineth exercise
        public static bool M9(int num)
        {
            bool isPrimeNum = true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isPrimeNum = false;
                    break;
                }
            }
            return isPrimeNum;
        }

        // tenth exercise
        public static int M10(int matches)
        {
            int teams = 2;
            int i = 1;
            while (true)
            {
                if (i + teams <= matches)
                {
                    i += teams;
                    teams++;
                }
                else
                {
                    break;
                }
            }
            return teams;
        }

        // eleventh exercise
        public static void M11(ref double a, ref double b)
        {
            double tmpVal = a;
            a = b;
            b = tmpVal;
        }
    }
}