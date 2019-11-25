using System;

namespace Literals
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0b11;
            int y = 0b1001;
            int k = 0b10001001;
            int m = 0b1000_1001;
            Console.WriteLine($"x = {x}, y = {y}, k = {k}, m = {m}");

            Console.WriteLine();

            x = 0x1f;
            y = 0xff0d;
            k = 0x1fab30ef;
            m = 0x1fab_30ef;
            Console.WriteLine($"x = {x}, y = {y}, k = {k}, m = {m}");
        }

        static void Variables()
        {
            int x = 10;
            int y;

            y = 2;

            Int32 x1 = -1;

            uint z = 1;

            float f = 1.1f;

            double d = 2.3;

            int x2 = 0;

            var a = 4;
            var u = 5.2;

            decimal m = 3.0m;

            char ch = 'A';
            string str = "str";
            bool boo = true;

            object obj = 1;
            object obj2 = "text";
        }
    }
}
