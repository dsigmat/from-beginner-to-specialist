using System;

namespace We_work_with_the_console
{
    class Program
    {
        static void Main(string[] args)
        {        
            Console.WriteLine("Hi, please tell me your name");
            string name = Console.ReadLine();
            string sentence = $"Your name is {name}";
            Console.WriteLine(sentence);

            Console.WriteLine("Hi, please tell me your age");
            string input = Console.ReadLine();
            int age = int.Parse(input);//приводим к числу
            sentence = $"Your age is {age}";
            Console.WriteLine(sentence);

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.Write("New Style ");
            Console.Write("New Style\n");
        }
    }
}
