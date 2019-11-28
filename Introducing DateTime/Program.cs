using System;

namespace Introducing_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine($"it's {now.Date}, {now.Hour}:{now.Minute}.");

            DateTime dt = new DateTime(2016,2,28);
            DateTime newDt = dt.AddHours(1);
            Console.WriteLine(dt);
            Console.WriteLine(newDt);

            TimeSpan ts = now - dt;
            //ts = now.Subtract(dt);
            Console.WriteLine(ts.Days);

        }
    }
}
