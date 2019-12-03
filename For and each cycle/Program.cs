using System;

namespace For_and_each_cycle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 6, 2, 1, 2, 5, 8, 120 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]%2 == 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }

            Console.WriteLine();

            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
