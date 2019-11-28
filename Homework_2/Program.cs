using System;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины трех сторон треугольника.");
            Console.WriteLine("x:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("y:");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("z:");
            double z = double.Parse(Console.ReadLine());

            double p = (x + y + z) / 2;
            double result = (p * (p - x)*(p - y)*(p - z));
            double st = Math.Sqrt(result);

            Console.WriteLine($"Площадь треугольника равна {st}");
        }
    }
}
