using tyuiu.cources.programming.interfaces.Sprint2;
using Tyuiu.ReneDS.Sprint2.Task4.V1.Lib;

namespace Tyuiu.ReneDS.Sprint2.Task4.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        
            [TestMethod]
            public void ValidCondition1()
            {
                DataService ds = new DataService();

                double x = 1;
                double y = 3;
                double wait = 1.333;

                double res = ds.Calculate(x, y);

                Assert.AreEqual(wait, res, 0.000001);
            }

            [TestMethod]
            public void ValidCondition2()
            {
                DataService ds = new DataService();

                double x = 5;
                double y = 1;
                double wait = 2;

                double res = ds.Calculate(x, y);

                Assert.AreEqual(wait, res, 0.000001);
            }
        
    }
}
