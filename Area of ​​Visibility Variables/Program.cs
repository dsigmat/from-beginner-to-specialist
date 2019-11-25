using System;

namespace Area_of___Visibility_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            {
                var b = 20;
                {
                    var c = 30;
                    Console.WriteLine($"{a}, {b} , {c}");
                }
                //Console.WriteLine($"{a}, {b} , {c}");
            }
            //Console.WriteLine($"{a}, {b} , {c}");
        }
    }
}
