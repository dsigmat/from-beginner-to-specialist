﻿using System;

namespace While_and_do_while_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 30;

            while (age < 18)
            {
                Console.WriteLine("First while loop");
                Console.WriteLine("What is your age?");
                age = int.Parse(Console.ReadLine());
            }

            do
            {
                Console.WriteLine("Do\\While");
                Console.WriteLine("What is your age?");
                age = int.Parse(Console.ReadLine());
            } while (age < 18);

            Console.WriteLine("Good");

            int[] numbers = { 1,2,5,8,9,6,7,8,4 };

            int i = 0;
            while (i < numbers.Length)
            {
                Console.Write(numbers[i] + ", ");
                i++;
            }
        }
    }
}
