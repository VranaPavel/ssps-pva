using System;

namespace Exercises
{
    public class Program
    {
        public static void Main()
        {
            // first exercise
            DateTime t1A = DateTime.Now;
            Console.WriteLine("{0} {1}", t1A.DayOfWeek, t1A.Date.ToString("d"));

            DateTime newYear = new DateTime(day: 1, month: 1, year: t1A.Year + 1);
            TimeSpan span1 = newYear - t1A;
            Console.WriteLine(span1.Days);

            DateTime t1C = new DateTime(day: 31, month: 12, year: t1A.Year);
            Console.WriteLine(t1C.DayOfWeek);


            // second exercise
            DateTime t2 = DateTime.Now;
            if (t2.Day < 13)
            {
                t2 = new DateTime(13, t2.Month, t2.Year);
            }
            else if (t2.Day > 13)
            {
                if (t2.Month == 12)
                {
                    t2 = new DateTime(t2.Year + 1, 1, 13);
                }
                else
                {
                    t2 = new DateTime(t2.Year, t2.Month + 1, 13);
                }
            }

            for (int i = 0; i < 10; i++)
            {
                while (t2.DayOfWeek != DayOfWeek.Friday)
                {
                    t2 = t2.AddMonths(1);
                }
                Console.WriteLine(t2.Date.ToString("d"));
                t2 = t2.AddMonths(1);
            }
        }
    }
}