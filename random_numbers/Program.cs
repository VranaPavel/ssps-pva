using System;

namespace RandomNumbers
{
    // first exercise
    public class Cube
    {
        public int numberOfSites;
        Random r = new Random();
        List<int> memory = new List<int>();

        public Cube(int numberOfSitesArg, int capacityArg)
        {
            numberOfSites = numberOfSitesArg;
            memory.Capacity = capacityArg;
        }

        public void Roll()
        {
            int currentRoll = r.Next(1, numberOfSites + 1);
            if (memory.Count != memory.Capacity)
            {
                memory.Add(currentRoll);
            }
            else
            {
                MemoryIsFull(currentRoll);
            }
            Console.WriteLine("Current roll: {0}", currentRoll);
        }

        void MemoryIsFull(int newElement)
        {
            for (int i = 0; i < memory.Capacity - 1; i++)
            {
                memory[i] = memory[i + 1];
            }
            memory[memory.Capacity - 1] = newElement;
        }

        public void PrintMemory()
        {
            Console.Write("Memory of cube:");
            for (int i = 0; i < memory.Count; i++)
            {
                Console.Write($" {memory[i]}");
            }
            Console.Write("\n\n");
        }
    }

    class Program
    {
        // second exercise
        public static int[] Second(int num)
        {
            int[] arr = new int[num];
            Random r = new Random();
            for (int i = 0; i < num; i++)
            {
                int tmp = r.Next();
                while (arr.Contains(tmp))
                {
                    tmp = r.Next();
                }
                arr[i] = tmp;
            }
            return arr;
        }

        // third exercise
        public static string[] Third(string[] arr)
        {
            string[] newArr = new string[arr.Length / 2];
            Random r = new Random();
            List<int> usedNames = new List<int>();

            int name1Index;
            int name2Index;
            for (int i = 0; i < newArr.Length; i++)
            {
                do
                {
                    name1Index = r.Next(0, arr.Length);
                } while (usedNames.Contains(name1Index));
                usedNames.Add(name1Index);

                do
                {
                    name2Index = r.Next(0, arr.Length);
                } while (usedNames.Contains(name2Index));
                usedNames.Add(name2Index);

                newArr[i] = arr[name1Index] + ' ' + arr[name2Index];
            }
            return newArr;
        }

        public static void Main()
        {
            // first exercise
            Cube cube = new Cube(12, 7);
            cube.Roll();
            cube.Roll();
            cube.Roll();
            cube.PrintMemory();
            cube.Roll();
            cube.PrintMemory();
            cube.Roll();
            cube.PrintMemory();
            cube.Roll();
            cube.PrintMemory();
            cube.Roll();
            cube.PrintMemory();
            cube.Roll();
            cube.PrintMemory();
            cube.Roll();
            cube.PrintMemory();
            cube.Roll();
            cube.PrintMemory();


            // second exercise
            int[] arr2 = Second(10);
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write($"{arr2[i]} ");
            }


            // third exercise
            string[] arr3 = {"Jack", "Stephanie", "James", "Jenifer", "William", "Paul"};
            string[] newArr3 = Third(arr3);
            Console.Write("\n\n");
            for (int i = 0; i < newArr3.Length; i++)
            {
                Console.WriteLine(newArr3[i]);
            }   
        }
    }
}