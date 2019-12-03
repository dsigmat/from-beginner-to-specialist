using System;

namespace Vlozhennyĭ_tsikl_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, -8, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];

                    if (atI + atJ == 0) 
                    {
                        Console.WriteLine($"Pair ({atI});({atJ}). Index ({i};{j})");
                    }
                }
            }
            Console.WriteLine();

            for (int i = 0; i < numbers.Length - 2; i++)
            {
                for (int j = i + 1; j < numbers.Length - 1; j++)
                {
                    for (int k = j + 1; k < numbers.Length; k++)
                    {
                        int atI = numbers[i];
                        int atJ = numbers[j];
                        int atK = numbers[k];

                        if (atI + atJ + atK == 0)
                        {
                            Console.WriteLine($"Triplets ({atI});({atJ});({atK}). Indexs ({i};{j};{k})");
                        }
                    }                  
                }
            }
        }
    }
}
