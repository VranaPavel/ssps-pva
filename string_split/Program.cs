using System;

namespace StringSplit
{
    public class Program
    {
        public static int NumberOfWords(string input, char[] separators) {
            string[] arr = input.Split(separators ,StringSplitOptions.RemoveEmptyEntries);
            return arr.Length;
        }
        
        public static void Main()
        {
            Console.WriteLine(NumberOfWords("Nebe je modré, nebude pršet.", new char[] {' ', ',', '.'}));
        }
    }
}