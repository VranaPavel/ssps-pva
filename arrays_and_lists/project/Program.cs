using System;
using System.Linq.Expressions;

namespace Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> name = new List<string>();
            List<string> description = new List<string>();
            List<string> deadline = new List<string>();
            List<int> priority = new List<int>();
            List<bool> isCompleted = new List<bool>();
            string? action;

            Console.WriteLine("Welcome in the Simple ToDo list v 1.0\n");

            while (true)
            {
                Console.WriteLine("Actions are: \"add\", \"delete\", \"list\", \"mark as completed\", \"exit\"");
                Console.Write("Enter action please: ");
                action = Console.ReadLine();
                switch (action)
                {
                    case "exit":
                        Console.WriteLine("\nGoodbye!");
                        return;

                    case "add":
                        if (name.Count() > 15)
                        {
                            Console.WriteLine("Can not create new task. Task limit exceeded.");
                            break;
                        }
                        else
                        {
                            string? s1;
                            do
                            {
                                Console.Write("Enter name of the task: ");
                                s1 = Console.ReadLine();
                            } while (s1 == null);
                            name.Add(s1);

                            do
                            {
                                Console.Write("Enter description of the task: ");
                                s1 = Console.ReadLine();
                            } while (s1 == null);
                            description.Add(s1);

                            do
                            {
                                Console.Write("Enter deadline of the task: ");
                                s1 = Console.ReadLine();
                            } while (s1 == null);
                            deadline.Add(s1);

                            bool b1;
                            int x;
                            do
                            {
                                Console.Write("Enter priority of the task (1 - 5): ");
                                s1 = Console.ReadLine();
                                b1 = int.TryParse(s1, out x);
                            } while (s1 == null || b1 == false || x < 1 || x > 5);
                            priority.Add(x);

                            isCompleted.Add(false);
                            break;
                        }

                    case "delete":
                        if (name.Count() == 0)
                        {
                            Console.WriteLine("There is no task to be deleted.");
                            break;
                        }
                        else
                        {
                            string? s2;
                            bool b2;
                            int index;
                            do
                            {
                                if (name.Count() == 1)
                                    Console.Write("Enter index of task to delete (only 0): ");
                                else
                                    Console.Write("Enter index of task to delete (0 - {0}): ", name.Count() - 1);
                                s2 = Console.ReadLine();
                                b2 = int.TryParse(s2, out index);
                            } while (s2 == null || b2 == false || index > name.Count() - 1 || index < 0);

                            name.RemoveAt(index);
                            description.RemoveAt(index);
                            deadline.RemoveAt(index);
                            priority.RemoveAt(index);
                            isCompleted.RemoveAt(index);
                            break;
                        }

                    case "mark as completed":
                        if (name.Count() == 0)
                        {
                            Console.WriteLine("There is no task to be mark as completed.");
                            break;
                        }
                        else
                        {
                            string? s3;
                            bool b3;
                            int index2;
                            do
                            {
                                if (name.Count() == 1)
                                    Console.Write("Enter index of task to mark as completed (only 0): ");
                                else
                                    Console.Write("Enter index of task to mark as completed (0 - {0}): ", name.Count() - 1);
                                s3 = Console.ReadLine();
                                b3 = int.TryParse(s3, out index2);
                            } while (s3 == null || b3 == false || index2 < 0 || index2 > name.Count() - 1);
                            isCompleted[index2] = true;
                            break;
                        }

                    case "list":
                        for (int i = 0; i < name.Count; i++)
                        {
                            Console.WriteLine("Name: {0}", name[i]);
                            Console.WriteLine("Description: {0}", description[i]);
                            Console.WriteLine("Deadline: {0}", deadline[i]);
                            Console.WriteLine("Priority: {0}", priority[i]);
                            Console.WriteLine("Index: {0}", i);
                            Console.WriteLine("Is completed: {0}\n", isCompleted[i]);
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid action");
                        break;
                }
            }
        }
    }
}