using tyuiu.cources.programming.interfaces.Sprint2;
using Tyuiu.ReneDS.Sprint2.Task3.V26.Lib;

namespace Tyuiu.ReneDS.Sprint2.Task3.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        
            [TestMethod]
            public void ValidCoundition1()
            {
                DataService ds = new DataService();

                double x = 1;
                double wait = 4.702;
                double res = ds.Calculate(x);

                Assert.AreEqual(wait, res, 0.000001);
            }

            [TestMethod]
            public void ValidCoundition2()
            {
                DataService ds = new DataService();

                double x = 0;
                double wait = 1.667;
                double res = ds.Calculate(x);

                Assert.AreEqual(wait, res, 0.000001);
            }

            [TestMethod]
            public void ValidCoundition3()
            {
                DataService ds = new DataService();

                double x = -1;
                double wait = -4.754;
                double res = ds.Calculate(x);

                Assert.AreEqual(wait, res, 0.000001);
            }

            [TestMethod]
            public void ValidCoundition4()
            {
                DataService ds = new DataService();

                double x = -31;
                double wait = -247.968;
                double res = ds.Calculate(x);

                Assert.AreEqual(wait, res, 0.000001);
            }
    }
}
