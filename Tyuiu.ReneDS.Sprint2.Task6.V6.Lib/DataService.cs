using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ReneDS.Sprint2.Task6.V6.Lib
{
    public class DataService : ISprint2Task6V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string suit = value1 switch
            {
                1 => "пик",
                2 => "треф",
                3 => "бубен",
                4 => "червей",
                _ => throw new ArgumentException("Номер масти должен быть от 1 до 4.")
            };

            string name = value2 switch
            {
                6 => "шестерка",
                7 => "Семерка",
                8 => "Восьмерка",
                9 => "Девятка",
                10 => "Десятка",
                11 => "Валет",
                12 => "дама",
                13 => "Король",
                14 => "Туз",
                _ => throw new ArgumentException("Достоинство должно быть от 6 до 14.")
            };

            string res = name + " " + suit;

            return res;
        }
    }
}
