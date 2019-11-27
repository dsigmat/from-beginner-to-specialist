using System;

namespace Privedeniye_tipov_i_parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 3;//0000 0011
            int i = b;//0000 0000 0000 0000 0000 0000 0000 0011
            long l = i;//0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0011

            Console.WriteLine($"b = {b}, i = {i}, l = {l}");

            float f = i;//3.0
            Console.WriteLine(f);

            b = (byte)i;
            Console.WriteLine(b);

            i = (int)f;
            Console.WriteLine(i);

            f = 2.1f;
            i = (int)f;
            Console.WriteLine(i);

            string str = "1";
            i = int.Parse(str);
            Console.WriteLine(i);

            l = long.Parse(str);
            Console.WriteLine(l);

            int x = 5;
            int y = 2;
            int result = x / y;

            float result2 = (float)x / y;
            Console.WriteLine(result2);



        }
    }
}
