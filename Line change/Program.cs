using System;

namespace Line_change
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = string.Empty;//пустая стррока

            string nameConcat = string.Concat("My"," name"," is"," John");
            Console.WriteLine(nameConcat);

            nameConcat = "My " + "name " + "is " + "John";
            Console.WriteLine(nameConcat);

            nameConcat = string.Join(" ","My","name","is", "John");
            Console.WriteLine(nameConcat);
                       
            string newName = nameConcat.Insert(0, "By the way, ");
            Console.WriteLine(newName);

            newName = nameConcat.Remove(0, 5);
            Console.WriteLine(newName);

            string replaced = nameConcat.Replace('n','z');
            Console.WriteLine(replaced);

            string data = "12;25;64";
            string[] splitData = data.Split(';');
            string first = splitData[1];
            Console.WriteLine(first);

            char[] chars = nameConcat.ToCharArray();
            Console.WriteLine(chars[0]);
            Console.WriteLine(nameConcat[0]);

            string lower = nameConcat.ToLower();
            Console.WriteLine(lower);
            string upper = nameConcat.ToUpper();
            Console.WriteLine(upper);

            string john = " My name is John ";
            Console.WriteLine(john.Trim());
        }
    }
}
