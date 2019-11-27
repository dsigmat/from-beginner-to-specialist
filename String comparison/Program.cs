using System;

namespace String_comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt1 = "abcde";
            string txt2 = "abcde";

            bool areEqual = txt1 == txt2;//тоже самое
            Console.WriteLine(areEqual);

            areEqual = string.Equals(txt1, txt2, StringComparison.Ordinal);//тоже самое
            Console.WriteLine(areEqual);

            Console.WriteLine();

            string txt3 = "Strasse";
            string txt4 = "Straße";

            areEqual = string.Equals(txt3, txt4, StringComparison.Ordinal);//тоже самое
            Console.WriteLine(areEqual);
            areEqual = string.Equals(txt3, txt4, StringComparison.InvariantCulture);
            Console.WriteLine(areEqual);
            areEqual = string.Equals(txt3, txt4, StringComparison.CurrentCulture);
            Console.WriteLine(areEqual);
        }
    }
}
