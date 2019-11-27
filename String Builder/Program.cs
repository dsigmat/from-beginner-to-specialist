using System;
using System.Text;

namespace String_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("My ");
            sb.Append("name ");
            sb.Append("is ");
            sb.Append("John");
            sb.AppendLine("!");
            sb.AppendLine("Hello!");
            //Console.WriteLine(sb);

            string str = sb.ToString();
            Console.WriteLine(str);
        }
    }
}
