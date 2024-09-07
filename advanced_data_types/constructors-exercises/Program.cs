using System;

namespace ConstructorsExercise
{
    class Person
    {
        string name;
        string surname;
        string bornID;

        public Person(string nameArg, string surnameArg, string bornIDArg)
        {
            if (bornIDArg.Length > 11)
            {
                bornIDArg = "Invalid bornID";
            }
            else
            {
                for (int i = 0; i < bornIDArg.Length; i++)
                {
                    if (i == 6)
                    {
                        if (bornIDArg[6] != '/')
                        {
                            bornIDArg = "Invalid bornID";
                            break;
                        }
                        else
                            continue;
                    }
                    else if (bornIDArg[i] < '0' || bornIDArg[i] > '9')
                    {
                        bornIDArg = "Invalid bornID";
                        break;
                    }
                }
            }

            name = nameArg;
            surname = surnameArg;
            bornID = bornIDArg;
        }

        public string WhoAmI()
        {
            return $"Name: {name}\t Surname: {surname}\t BornID: {bornID}";
        }

        public void ChangeBornID()
        {
            string? s;
            do
            {
                Console.Write("Enter new bornID: ");
                s = Console.ReadLine();
            } while (s == null);
            bornID = s;
        }

        public void changeNameAndSurname()
        {
            string? newName;
            string? newSurname;
            do 
            {
                Console.Write("Enter new name: ");
                newName = Console.ReadLine();
                Console.Write("Enter new surname: ");
                newSurname = Console.ReadLine();
            } while (newName == null || newSurname == null);
            name = newName;
            surname = newSurname;
        }
    }

    class Programmer : Person
    {
        public string prgLang;

        public Programmer(string nameArg, string surnameArg, string bornIDArg, string prgLangArg) : base(nameArg, surnameArg, bornIDArg)
        {
            if (prgLangArg == "Kotlin" || prgLangArg == "C#" || prgLangArg == "Python" || prgLangArg == "JS" || prgLangArg == "Rust")
                prgLang = prgLangArg;
            else
                prgLang = "other";
        }

        public new string WhoAmI()
        {
            return base.WhoAmI() + $"\t Programming language: {prgLang}";
        }
    }

    public static class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person("James", "Smith", "990703/8831");
            Programmer programmer = new Programmer("James", "Smith", "990703/8831", "Java");

            Console.WriteLine(person.WhoAmI());
            Console.WriteLine(programmer.WhoAmI());
            person.ChangeBornID();
            Console.WriteLine(person.WhoAmI());
            person.changeNameAndSurname();
            Console.WriteLine(person.WhoAmI());
        }
    }
}