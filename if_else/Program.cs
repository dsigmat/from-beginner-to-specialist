using System;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Сколько лет?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько ты весишь, кожаный ублюдок!");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Твой рост!");
            double height = double.Parse(Console.ReadLine());

            double bodyMassIndex = weight / (height * height);

            bool isTooLow = bodyMassIndex <= 18.5;// недостаток веса
            bool isNormal = bodyMassIndex > 18.5 && bodyMassIndex < 25;// норма веса
            bool isAboveNormal = bodyMassIndex >= 25 && bodyMassIndex <= 30;
            bool isToolFat = bodyMassIndex > 30;

            bool isFat = isAboveNormal || isToolFat;

            if (isFat)
            {
                Console.WriteLine("Жиропасина!");
            }
            else
            {
                Console.WriteLine("Пока еще не жиропасина!");
            }
            if (!isFat)
            {
                Console.WriteLine("Ты не жиропасина!");
            }

            if (isTooLow)
            {
                Console.WriteLine("Ты анерексия ходячая!");
            }
            else if (isNormal)
            {
                Console.WriteLine("Ты идеален!!!");
            }
            else if (isAboveNormal)
            {
                Console.WriteLine("Обрастаешь гавножиром!!!");
            }
            else
            {
                Console.WriteLine("Пора не жрать!!!");
            }

            if (isFat || isToolFat)
            {
                Console.WriteLine("Время сесть на диету!!!");
            }

            string desc = age > 18 ? "Опять нажрешся скотиняка!!!" : "Тебе еще рано побухивать!!!";//ternay operation 
            Console.WriteLine(desc);


            Console.WriteLine("Введите число");
            int num_a = int.Parse(Console.ReadLine());
            int num_b = int.Parse(Console.ReadLine());
            string result = num_a > num_b ? $"{num_a} больше {num_b}" : $"{num_b} больше {num_a}";

            Console.WriteLine(result);
        }
    }
}
