using System;

namespace Class_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Pow(2,6));//возводит в степень
            Console.WriteLine(Math.Sqrt(121));//корень числа
            Console.WriteLine(Math.Round(1.7));//округление числа
            Console.WriteLine(Math.Round(1.4));

            Console.WriteLine();

            Console.WriteLine(Math.Round(2.5));
            Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero));
            Console.WriteLine(Math.Round(2.5, MidpointRounding.ToEven));
        }
    }
}
