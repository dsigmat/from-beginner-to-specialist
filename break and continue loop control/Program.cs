using System;

namespace break_and_continue_loop_control
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numb = { 0, 1, 2, 5, 4, 3, 6, 7, 8, 9 };

            foreach (var item in numb)
            {
                //if (item % 2 != 0)
                //{
                //    Console.Write(  item + " " );
                //}

                if (item % 2 == 0)
                {
                    Console.Write(item + " ");
                }
            }



            char[] letters = { 'a', 'b','c','d','f','j', 'h', 'x', 'z','o' };

            for (int i = 0; i < numb.Length; i++)
            {
                Console.WriteLine($"Number = {numb[i]}");
                for (int x = 0; x < letters.Length; x++)
                {
                    if (numb[i] == x)
                        break;
                    Console.Write($"{letters[x]} ");
                }
                Console.WriteLine();
            }


            Console.WriteLine();
            int[] numbers = { 1,-2,4,-7,5,3,2,-1,-3,2,7,-1,-3,1,7};

            int counter = 0;            

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (counter == 3)
                {
                    break;
                }

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];

                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"Pair ({atI};{atJ}). Indexes ({i};{j})");
                        counter++;
                    }

                    if (counter == 3)
                    {
                        break;
                    }
                }

                Console.WriteLine($"{i}");
            }
        }
    }
}
