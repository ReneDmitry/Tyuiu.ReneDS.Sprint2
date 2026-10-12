using System;
using Tyuiu.ReneDS.Sprint2.Task3.V26.Lib;

namespace Tyuiu.ReneDS.Sprint2.Task3.V26
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Ренье Д. С. | АСОиУБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Вложенные операторы if-else                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Ренье Дмитрий Сергеевич | АСОиУБ-26-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить значение функции Y с использованием вложенных if-else.        *");
            Console.WriteLine("* Значение X вводится с клавиатуры.                                        *");
            Console.WriteLine("* Результат округлить до трёх знаков после запятой.                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x;

            Console.WriteLine("Введите X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (x == -30)
            {
                Console.WriteLine("При x = -30 функция не задана.");
            }
            else
            {
                double res;
                res = ds.Calculate(x);

                if (double.IsNaN(res) || double.IsInfinity(res))
                {
                    Console.WriteLine(
                        "Для этого X нет конечного действительного значения Y.");
                }
                else
                {
                    Console.WriteLine("Y = " + res);
                }
            }

            Console.ReadLine();
        }
    }
}