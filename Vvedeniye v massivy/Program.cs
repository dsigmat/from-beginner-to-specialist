using System;

namespace Vvedeniye_v_massivy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1;
            a1 = new int[10];

            int[] a2 = new int[5];
            int[] a3 = new int[5] { 1,2,3,4,5};

            int[] a4 = { 1, 2, 3, 4, 5, 6, 7, 8, 78 };

            Console.WriteLine(a4[3]);

            a4[2] = 6;
            Console.WriteLine(a4[2]);

            Console.WriteLine(a4.Length);//узнать длинну масива
            Console.WriteLine(a4[a4.Length-1]);//узнвать последнее значение элемента в массиве

            string s1 = "abcdefgh";
            char first = s1[0];
            char last = s1[s1.Length - 1];

            Console.WriteLine($"first: {first}, last: {last}.");
        }
    }
}
