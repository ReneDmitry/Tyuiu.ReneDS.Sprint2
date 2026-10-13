using Tyuiu.ReneDS.Sprint2.Task6.V6.Lib;

namespace Tyuiu.ReneDS.Sprint2.Task6.V6
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Ренье Д. С. | АСОиУБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Сокращённая форма оператора switch                                 *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Ренье Дмитрий Сергеевич | АСОиУБ-26-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* По номеру масти M и достоинству K определить полное название карты.     *");
            Console.WriteLine("* Масти: 1 — пики, 2 — трефы, 3 — бубны, 4 — червы.                        *");
            Console.WriteLine("* Достоинства: 6–10 — числовые карты, 11 — валет,                          *");
            Console.WriteLine("* 12 — дама, 13 — король, 14 — туз.                                        *");
            Console.WriteLine("* Использовать сокращённую форму оператора switch.                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int m;
            int k;

            Console.WriteLine("Введите номер масти (от 1 до 4):");
            m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите достоинство карты (от 6 до 14):");
            k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (m < 1 || m > 4 || k < 6 || k > 14)
            {
                Console.WriteLine("Масть должна быть от 1 до 4, достоинство — от 6 до 14.");
            }
            else
            {
                string res;
                res = ds.FindCardNameAndValue(m, k);

                Console.WriteLine(res);
            }

            Console.ReadLine();
        }
    }
}