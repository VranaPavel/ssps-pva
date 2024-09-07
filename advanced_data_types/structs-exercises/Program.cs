using System;

namespace StructsExercises
{
    public struct Cordinates
    {
        public double x;
        public double y;
    }

    public struct Line
    {
        public double firstX;
        public double firstY;
        public double secondX;
        public double secondY;
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            Cordinates first = new Cordinates();
            first.x = 58.6;
            first.y = 23.4;

            Cordinates second = new Cordinates();
            second.x = 69.7;
            second.y = 34.1;

            Cordinates third = new Cordinates();
            third.x = 101.64;
            third.y = 97.87;

            Cordinates fourth = new Cordinates();
            fourth.x = 123.78;
            fourth.y = 169.21;

            Line firstLine = new Line();
            firstLine.firstX = first.x;
            firstLine.firstY = first.y;
            firstLine.secondX = second.x;
            firstLine.secondY = second.y;

            Line secondLine = new Line();
            secondLine.firstX = third.x;
            secondLine.firstY = third.y;
            secondLine.secondX = fourth.x;
            secondLine.secondY = fourth.y;

            Line[] arrOfLines = {firstLine, secondLine};
            Console.WriteLine(arrOfLines);

            // skipped
        }
    }
}