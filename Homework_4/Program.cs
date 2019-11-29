using System;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сейчас вы введете два целочисленных значения а я найду максимальное значение.");
            Console.WriteLine("Введите первое целочисленнроое значение!");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе целочисленнроое значение!");
            int b = int.Parse(Console.ReadLine());

            //1-st
            //if (a > b)
            //{
            //    Console.WriteLine($"Число {a} больше {b}");
            //}
            //else if (a < b)
            //{
            //    Console.WriteLine($"Число {b} больше {a}");
            //}
            //else
            //{
            //    Console.WriteLine($"Число {b} равно {a}");
            //}

            //2nd
            //int max = a;

            //if (b > a)
            //{
            //    max = b;
            //}
            //Console.WriteLine($"Max = {max}");

            //int max;
            //if (b > a) 
            //{
            //    max = b;
            //}
            //else
            //{
            //    max = a;
            //}
            //Console.WriteLine($"Max = {max}");

            //3rd
            int max = a > b ? a : b;

            Console.WriteLine($"Max = {max}");
        }
    }
}
