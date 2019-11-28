using System;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("Ваше имя пжлста!");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");

            Console.WriteLine();

            Console.WriteLine("Введите целое число!");
            string input = Console.ReadLine();
            int x = int.Parse(input);

            Console.WriteLine("Введите еще одно целое число!");
            input = Console.ReadLine();
            int y = int.Parse(input);

            Console.WriteLine($"Вы ввели вот эти два числа - {x} и {y}");

            Console.WriteLine();

            int c = x;
            x = y;
            y = c;
            Console.WriteLine($"Воть так {x},{y}");

            Console.WriteLine();

            Console.WriteLine("Введите целое число!");
            int num = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Вот то что вы ввели {num}, и оно состоит из {num.ToString().Length} цифр.");

        }
    }
}
