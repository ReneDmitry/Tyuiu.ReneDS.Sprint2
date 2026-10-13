using Tyuiu.ReneDS.Sprint2.Task7.V11.Lib;

namespace Tyuiu.ReneDS.Sprint2.Task7.V11
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Ренье Д. С. | АСОиУБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Ренье Дмитрий Сергеевич | АСОиУБ-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Ввести вещественные координаты X и Y с клавиатуры.                      *");
            Console.WriteLine("* Определить, находится ли точка в заштрихованной области.                *");
            Console.WriteLine("* Область лежит внутри круга X^2 + Y^2 <= 1                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x;
            double y;

            Console.WriteLine("Введите X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Y:");
            y = Convert.ToDouble(Console.ReadLine());

            bool res;
            res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);

            Console.ReadLine();
        }
    }
}