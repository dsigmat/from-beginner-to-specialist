using System;

namespace Homework_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Назовите свою фамилию:");
            string surname = Console.ReadLine();
            Console.WriteLine("Назовите свое имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Назовите свой возраст:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Назовите свой вес:");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Назовите свой рост:");
            double height = double.Parse(Console.ReadLine());

            double bodyMassIndex = (weight / ((height/100) * (height/100)));

            Console.WriteLine("Ваш профайл:");
            Console.WriteLine($"Полное имя: {surname}, {name}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Вес: {weight}");
            Console.WriteLine($"Индекс массы тела: {bodyMassIndex:f2}");
        }
    }
}
