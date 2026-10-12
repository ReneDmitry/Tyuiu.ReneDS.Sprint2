using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ReneDS.Sprint2.Task3.V26.Lib
{
    public class DataService : ISprint2Task3V26
    {
        public double Calculate(double x)
        {
            double res;

            if (x > 0)
            {
                res = x + Math.Pow(
                    (x + 1) / Math.Cos(Math.Pow(x, 2)), x);
            }
            else
            {
                if (x == 0)
                {
                    res = (15 + x) /
                        (Math.Pow(3, 2) - Math.Sin(Math.Pow(x, 2)));
                }
                else
                {
                    if (x > -30)
                    {
                        res = Math.Pow(
                            Math.Sin(Math.Pow(x, 3)) / (x + 5), x);
                    }
                    else
                    {
                        if (x < -30)
                        {
                            res = x + 7 * x - 1 / x;
                        }
                        else
                        {
                            res = double.NaN;
                        }
                    }
                }
            }

            return Math.Round(res, 3);
        }
    }
}
