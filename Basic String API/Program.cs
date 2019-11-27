using System;

namespace Basic_String_API
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "abrsakadabra";
            bool containtsA = name.Contains('d');
            bool containtsE = name.Contains('E');

            Console.WriteLine(containtsA);
            Console.WriteLine(containtsE);

            bool endsWithAbra = name.EndsWith("abra");
            Console.WriteLine(endsWithAbra);

            bool startWithAbra = name.StartsWith("abrs");
            Console.WriteLine(startWithAbra);

            int indxOfA = name.IndexOf('a', 1);            
            Console.WriteLine(indxOfA);

            int lastIndxOfR = name.LastIndexOf('r');
            Console.WriteLine(lastIndxOfR);

            Console.WriteLine(name.Length);

            string substringFrom5 = name.Substring(5);
            string substringFromTo = name.Substring(0,3);
            Console.WriteLine(substringFrom5);
            Console.WriteLine(substringFromTo);
        }
    }
}
 