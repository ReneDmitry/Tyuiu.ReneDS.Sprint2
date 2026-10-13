using System;
using Tyuiu.ReneDS.Sprint2.Task5.V12.Lib;

namespace Tyuiu.ReneDS.Sprint2.Task5.V12
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Ренье Д. С. | АСОиУБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Ренье Дмитрий Сергеевич | АСОиУБ-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дата задана тремя натуральными числами:                                 *");
            Console.WriteLine("* g — год, m — номер месяца, n — число месяца.                            *");
            Console.WriteLine("* Определить дату предыдущего дня с помощью оператора switch.             *");
            Console.WriteLine("* Заданный год является високосным.                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int g;
            int m;
            int n;

            Console.WriteLine("Введите год (високосный):");
            g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер месяца:");
            m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число месяца:");
            n = Convert.ToInt32(Console.ReadLine());

            string res;
            res = ds.FindDateOfPreviousDay(g, m, n);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Дата предыдущего дня: " + res);

            Console.ReadLine();
        }
    }
}
