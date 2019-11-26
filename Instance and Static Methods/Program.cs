using System;

namespace Instance_and_Static_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "abrakadabra";
            bool containsA = name.Contains('a');
            bool containsE = name.Contains('e');

            Console.WriteLine(containsA);
            Console.WriteLine(containsE);

            string abc = string.Concat("a", 'b', "c");
            Console.WriteLine(abc);

            Console.WriteLine(int.MinValue);

            int x = 1;
            string xStr = x.ToString();

            Console.WriteLine(xStr);
        }
    }
}
                                              