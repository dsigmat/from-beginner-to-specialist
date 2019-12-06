using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = int.Parse(Console.ReadLine());
            string season = string.Empty;

            switch (month)
            {
                case 1:
                case 2:
                case 12:
                    season = "Winter";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "Spring";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "Summer";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "Autum";
                    break;
                default:
                    throw new ArgumentException("");
            }

            Console.WriteLine(season);

            Console.ReadLine();

            #region switch
            //int weddingYears = int.Parse(Console.ReadLine());

            // string name = string.Empty;

            //switch (weddingYears)
            //{
            //    case 5:
            //        name = "Деревянная свадьба";
            //        break;
            //    case 10:
            //        name = "Оловянная свадьба";
            //        break;
            //    case 15:
            //        name = "Хрустальная свадьба";
            //        break;
            //    case 20:
            //        name = "Фарфоровая свадьба";
            //        break;
            //    case 25:
            //        name = "Серебрянная свадьба";
            //        break;
            //    case 30:
            //        name = "Жемчужная свадьба";
            //        break;
            //    default:
            //        name = "Не знаем такого юбилея!";
            //        break;
            //}
            //Console.WriteLine(name);
            #endregion

        }
    }
}
