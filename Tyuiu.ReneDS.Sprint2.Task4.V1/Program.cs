using Tyuiu.ReneDS.Sprint2.Task4.V1.Lib;

namespace Tyuiu.ReneDS.Sprint2.Task4.V1
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Ренье Д. С. | АСОиУБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Ренье Дмитрий Сергеевич | АСОиУБ-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить значение Z с использованием тернарного оператора.             *");
            Console.WriteLine("* Если X < Y, то Z = (X + 3) / Y,                                         *");
            Console.WriteLine("* иначе Z = (X + 1) / (X - 2).                                            *");
            Console.WriteLine("* Значения X и Y вводятся с клавиатуры.                                   *");
            Console.WriteLine("* Результат округлить до трёх знаков после запятой.                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x;
            double y;

            Console.WriteLine("Введите X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Y:");
            y = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Значение функции = " + res);

            Console.ReadKey();
        }
    }
}