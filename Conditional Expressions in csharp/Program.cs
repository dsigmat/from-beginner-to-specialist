using System;

namespace Conditional_Expressions_in_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Назовите свой возраст:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Назовите свой вес:");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Назовите свой рост:");
            double height = double.Parse(Console.ReadLine());

            double bodyMassIndex = (weight / ((height / 100) * (height / 100)));

            Console.WriteLine($"Индекс массы тела: {bodyMassIndex:f2}");

            bool isTooLow = bodyMassIndex <= 18.5;
            bool isNormal = bodyMassIndex > 18.5 && bodyMassIndex < 25;
            bool isAboveNormal = bodyMassIndex >= 25 && bodyMassIndex <= 30;
            bool isTooFat = bodyMassIndex > 30;

            bool isFat = isAboveNormal || isTooFat;

            if (isFat)
            {
                Console.WriteLine("Лучше бы сбросить пару килло!!!");
            }            
            else
            {
                Console.WriteLine("О все отлично продолжай в том же духе!!!");
            }

            if (!isFat)
            {
                Console.WriteLine("Ты точно не толстый!");
            }
            else if (isTooLow)
            {
                Console.WriteLine("Недостаточно веса.");
            }
            else if (isNormal)
            {
                Console.WriteLine("Все хорошо!");
            }
            else if (isAboveNormal)
            {
                Console.WriteLine("Пора насторожиться!");
            }
            else
            {
                Console.WriteLine("Все равно пора садиться на диету!");
            }



            //ternary operation
            string description = age > 18 ? "Вы можете пить алкоголь" : "Вы должны стать немного старше";

            //тоже самое но больше кода
            //if (age > 18)
            //{
            //    description = "Вы можете пить алкоголь";
            //}
            //else
            //{
            //    description = "Вы должны стать немного старше";
            //}

            Console.WriteLine(description);
        }
    }
}
