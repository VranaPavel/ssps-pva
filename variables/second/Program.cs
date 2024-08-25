using System;

namespace Second
{
    class Program
    {
        public static void Main(string[] args)
        {
            // 1
            decimal d = 2.0m;           // missing m after 2.0
            decimal l = 2 * 2.0m;       // f instead of m in decimal type
            float f = 2.5f;             // missing f after 2.5
            float g = (float)l;         // conversion is needed
            int i = (int)f;             // conversion is needed

            // 2

            float a = 2;
            float b = 2.0f;             // missing f after 2.0

            // 3
            double r = 2.0;
            double plochaKruhu = Math.PI * r * r;

            // it is much more faster
        }
    }
}