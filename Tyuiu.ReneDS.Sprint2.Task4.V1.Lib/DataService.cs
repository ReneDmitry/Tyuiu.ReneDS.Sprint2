using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ReneDS.Sprint2.Task4.V1.Lib
{
    public class DataService : ISprint2Task4V1
    {
        public double Calculate(double x, double y)
        {
            double res;

            res = (x < y) ? (x + 3) / y : (x + 1) / (x - 2);

            return Math.Round(res, 3);
        }
    }
}
