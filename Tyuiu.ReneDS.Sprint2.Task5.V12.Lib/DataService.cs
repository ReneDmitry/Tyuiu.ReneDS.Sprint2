using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ReneDS.Sprint2.Task5.V12.Lib
{
    public class DataService : ISprint2Task5V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            if (n > 1)
            {
                n--;
            }
            else
            {
                switch (m)
                {
                    case 1:
                        g--;
                        m = 12;
                        n = 31;
                        break;

                    case 3:
                        m--;
                        n = 29;
                        break;

                    case 5:
                    case 7:
                    case 10:
                    case 12:
                        m--;
                        n = 30;
                        break;

                    default:
                        m--;
                        n = 31;
                        break;
                }
            }

            string res = n.ToString("D2") + "." +
                         m.ToString("D2") + "." +
                         g.ToString("D4");

            return res;
        }
    }
}
