using Tyuiu.ReneDS.Sprint2.Task0.V10.Lib;

namespace Tyuiu.ReneDS.Sprint2.Task0.V10
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Ренье Д. С. | АСОиУБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Ренье Дмитрий Сергеевич | АСОиУБ-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Выполнить сравнения в порядке: ==, !=, <, >, <=, >=.                    *");
            Console.WriteLine("* При x = 1305 и y = 475 получить последовательность:                     *");
            Console.WriteLine("* False, True, False, True, False, True.                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 1305;
            int y = 475;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for(int i=0; i<6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadLine();
        }
    }
}
