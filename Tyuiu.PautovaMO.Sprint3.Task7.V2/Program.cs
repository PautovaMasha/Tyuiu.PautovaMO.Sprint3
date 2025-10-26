using System.Net;
using Tyuiu.PautovaMO.Sprint3.Task7.V2.Lib;

namespace Tyuiu.PautovaMO.Sprint3.Task7.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил : Паутова М.О. | ИБКСб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Итоговый проект                                                   *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Паутова Мария Олеговна | ИБКСб-25-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*  Таблица значений функции F(x) = cos(x)/(x-0.7) - sin(x)*12x + 2        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            int startValue = -5;
            int stopValue = 5;


            Console.WriteLine("Начало  " + startValue);
            Console.WriteLine("Конец  " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("===================");
            Console.WriteLine("   x    |   F(x)   ");
            Console.WriteLine("--------|----------");
            for (int x = 0; x <= len-1; x++)
            {

                Console.WriteLine("| {0,5:d} | {1,7:F2} |", startValue, valueArray[x]);
                startValue++;
            }

            Console.WriteLine("===================");
            Console.ReadKey();
        }
    }
}




