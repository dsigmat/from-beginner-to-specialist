using System;

namespace Repletion
{
    class Program
    {
        static void Main(string[] args)
        {
            //checked
            //{
                uint x = uint.MaxValue;
                Console.WriteLine(x);

                x = x + 1;
                Console.WriteLine(x); //выдаст ошибку переполнения при использование checked, без него просто 0.

                x = x - 1;
                Console.WriteLine(x);
            //}
        }
    }
}
