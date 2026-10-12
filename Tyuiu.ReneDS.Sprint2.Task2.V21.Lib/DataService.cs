using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ReneDS.Sprint2.Task2.V21.Lib
{
    public class DataService : ISprint2Task2V21
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if (
        (y >= 3 && y <= 4 && (x == 3 || (x >= 9 && x <= 12))) ||
        (y == 5 && (x == 3 || (x >= 6 && x <= 12))) ||
        (y >= 6 && y <= 7 && x >= 3 && x <= 13) ||
        (y == 8 && ((x >= 4 && x <= 6) || (x >= 10 && x <= 13))) ||
        (y == 9 && ((x >= 4 && x <= 6) || (x >= 10 && x <= 12))) ||
        (y == 10 && x >= 10 && x <= 12) ||
        (y == 11 && x >= 9 && x <= 12) ||
        (y == 12 && x >= 9 && x <= 10)
       )
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}
