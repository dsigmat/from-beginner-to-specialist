using System;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            #region if-else
            //Console.WriteLine("Сколько лет?");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Сколько ты весишь, кожаный ублюдок!");
            //double weight = double.Parse(Console.ReadLine());
            //Console.WriteLine("Твой рост!");
            //double height = double.Parse(Console.ReadLine());

            //double bodyMassIndex = weight / (height * height);

            //bool isTooLow = bodyMassIndex <= 18.5;// недостаток веса
            //bool isNormal = bodyMassIndex > 18.5 && bodyMassIndex < 25;// норма веса
            //bool isAboveNormal = bodyMassIndex >= 25 && bodyMassIndex <= 30;
            //bool isToolFat = bodyMassIndex > 30;

            //bool isFat = isAboveNormal || isToolFat;

            //if (isFat)
            //{
            //    Console.WriteLine("Жиропасина!");
            //}
            //else
            //{
            //    Console.WriteLine("Пока еще не жиропасина!");
            //}
            //if (!isFat)
            //{
            //    Console.WriteLine("Ты не жиропасина!");
            //}

            //if (isTooLow)
            //{
            //    Console.WriteLine("Ты анерексия ходячая!");
            //}
            //else if (isNormal)
            //{
            //    Console.WriteLine("Ты идеален!!!");
            //}
            //else if (isAboveNormal)
            //{
            //    Console.WriteLine("Обрастаешь гавножиром!!!");
            //}
            //else
            //{
            //    Console.WriteLine("Пора не жрать!!!");
            //}

            //if (isFat || isToolFat)
            //{
            //    Console.WriteLine("Время сесть на диету!!!");
            //}

            //string desc = age > 18 ? "Опять нажрешся скотиняка!!!" : "Тебе еще рано побухивать!!!";//ternay operation 
            //Console.WriteLine(desc);
            #endregion

            #region homework
            //Console.WriteLine("Введите число");
            //int num_a = int.Parse(Console.ReadLine());
            //int num_b = int.Parse(Console.ReadLine());
            //string result = num_a > num_b ? $"{num_a} больше {num_b}" : $"{num_b} больше {num_a}";

            //Console.WriteLine(result);
            #endregion

            #region for foreach

            //int[] numb = { 1,2,3,4,5,6,7,8,9,-1,-2,-3,-4,-5,-6,-7,-8,-9};
            //char[] alphabet = { };


            //for (int i = 0; i < numb.Length; i++)
            //{
            //    Console.Write(numb[i] + " ");
            //}

            //Console.WriteLine();

            //for (int i = numb.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(numb[i] + " ");
            //}

            //Console.WriteLine();

            //for (int i = 0; i < numb.Length; i++)
            //{
            //    if (numb[i] % 2 == 0)
            //    {
            //        Console.Write(numb[i] + " ");
            //    }
            //}

            //Console.WriteLine();

            //foreach (var item in numb)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine();

            //for (int i = 0; i < numb.Length; i++)
            //{
            //    Console.Write($"({i}:{numb[i]})" + ", ");
            //}

            //Console.WriteLine();

            //for (int i = 0; i < numb.Length; i++)
            //{
            //    for (int j = i + 1; j < numb.Length; j++)
            //    {
            //        for (int k = j +1; k < numb.Length; k++)
            //        {
            //            int atI = numb[i];
            //            int atJ = numb[j];
            //            int atK = numb[k];

            //            if (atI + atJ + atK == 0)
            //            {
            //                Console.WriteLine($"Pair ({atI};{atJ};{atK}). Indexes ({i};{j};{k})");
            //            }
            //        }                    
            //    }
            //}

            #endregion

            #region do while

            //int age = 0;

            //while (age < 18)
            //{
            //    Console.WriteLine("Сколько те лет?");
            //    age = int.Parse(Console.ReadLine());
            //}

            //do
            //{
            //    Console.WriteLine("Сколько те лет?");
            //    age = int.Parse(Console.ReadLine());
            //} while (age < 18);
            //Console.WriteLine("GOOD!!!");

            //int[] numb = { 1, 2, 3, 4, 5, 6, 7, 8, 9, -1, -2, -3, -4, -5, -6, -7, -8, -9 };
            //int i = 0;

            //while (i < numb.Length)
            //{
            //    Console.Write(numb[i] + " ");
            //    i++;
            //}

            //Console.WriteLine("GOOD!!!");

            #endregion

            #region breack and continue

            int[] numbers = { 0, 1, 3, 2, 4, 6, 5, 7, 8, 9 };
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'k', 'l' };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Numbers={numbers[i]}");
                
                for (int j = 0; j < letters.Length; j++)
                {
                    if (numbers[i] == j)
                        break;
                    Console.Write($" {letters[j]} ");
                }
                Console.WriteLine();
            }


            //int[] numb = { 1, 2, 3, 4, 5, 6, 7, 8, 9, -1, -2, -3, -4, -5, -6, -7, -8, -9 };

            //int counter = 0;

            //for (int i = 0; i < numb.Length; i++)
            //{
            //    for (int j = i + 1; j < numb.Length; j++)
            //    {

            //        if (counter == 3)
            //        {
            //            break;
            //        }

            //        for (int k = j + 1; k < numb.Length; k++)
            //        {
            //            int atI = numb[i];
            //            int atJ = numb[j];
            //            int atK = numb[k];

            //            if (atI + atJ + atK == 0)
            //            {
            //                Console.WriteLine($"Pair ({atI};{atJ};{atK}). Indexes ({i};{j};{k})");
            //                counter++;
            //            }
            //        }                      
            //    }
            //}

            #endregion
        }
    }
}
