using System;

namespace Algebraic_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 2;

            bool areEqual = x == y;
            Console.WriteLine($"{x} == {y} = {areEqual}");

            bool result = x > y;
            Console.WriteLine($"{x} > {y} = {result}");

            result = x >= y;
            Console.WriteLine($"{x} >= {y} = {result}");

            result = x < y;
            Console.WriteLine($"{x} < {y} = {result}");

            result = x <= y;
            Console.WriteLine($"{x} <= {y} = {result}");

            result = x != y;
            Console.WriteLine($"{x} != {y} = {result}");
        }

        static void MathOperations()
        {
            int x = 1;
            int y = 2;

            int z = x + y;
            int k = x - y;

            int q = z + k - y;

            Console.WriteLine($"z = {z}");
            Console.WriteLine($"k = {k}");
            Console.WriteLine($"q = {q}");

            int b = z * 2;
            int c = k / 2;
            Console.WriteLine($"b = z * 2 это {b}");
            Console.WriteLine($"c = k / 2 это {c}");

            int a = 4 % 2;
            b = 5 % 2;

            Console.WriteLine(a);
            Console.WriteLine(b);

            a = 3;
            a = a * a;
            Console.WriteLine(a);

            a = a * a * a;
            Console.WriteLine(a);

            a = 2 + 2 * 2;
            Console.WriteLine(a);

            a *= 2;
            Console.WriteLine(a);
            a /= 2;
            Console.WriteLine(a);
            a %= 2;
            Console.WriteLine(a);
        }

        static void IncrementDecrementDemo()
        {
            int x = 1;

            x = x + 1;
            Console.WriteLine(x);

            x++;
            Console.WriteLine(x);

            ++x;
            Console.WriteLine(x);

            x--;
            Console.WriteLine(x);

            --x;
            Console.WriteLine(x);

            Console.WriteLine("Learn about increments");
            Console.WriteLine($"Last x state is {x}");

            int j = x++;
            Console.WriteLine($"j = {j}");
            Console.WriteLine($"x = {x}");

            j = ++x;
            Console.WriteLine($"j = {j}");
            Console.WriteLine($"x = {x}");

            x += 2;
            Console.WriteLine($"x = {x}");
        }
    }
}
