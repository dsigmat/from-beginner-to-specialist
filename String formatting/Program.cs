using System;
using System.Text;
using System.Threading;

namespace String_formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            int age = 30;

            string str = string.Format("My name is {0} and i'm {1}", name, age);
            Console.WriteLine(str);

            string str2 = $"My name is {name} and I'm {age}";
            Console.WriteLine(str2);

            string str3 = $"My name is {name} \nand I'm {age}";
            Console.WriteLine(str3);

            string str4 = $"My name \tis {name} \nand I'm {age}";
            Console.WriteLine(str4);

            string str5 = $"My name  is {Environment.NewLine}John";
            Console.WriteLine(str5);

            str5 = "I'm John and I'm a \"good\" programmer.";
            Console.WriteLine(str5);

            string str6 = @"C:\tmp\test_file.txt";
            Console.WriteLine(str6);

            double answer = 42.08;
            //string result = string.Format("{0:d}", answer);
            //string result2 = string.Format("{0:d4}", answer);

            string result = string.Format("{0:f}", answer);
            string result2 = string.Format("{0:f1}", answer);

            Console.WriteLine(result);
            Console.WriteLine(result2);


            Console.OutputEncoding = Encoding.UTF8;

            double money = 12.5;
            result = string.Format("{0:C}", money);
            result2 = string.Format("{0:C2}", money);

            Console.WriteLine(result);
            Console.WriteLine(money.ToString("C2"));//тоже самое
            Console.WriteLine(result2);//тоже самое

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Console.WriteLine(money.ToString("C2"));
        }
    }
}
