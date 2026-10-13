using Tyuiu.ReneDS.Sprint2.Task7.V11.Lib;
namespace Tyuiu.ReneDS.Sprint2.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckDotInShadedArea1()
        {
            DataService ds = new DataService();

            double x = 0.7;
            double y = 0.7;

            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = true;

            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void CheckDotInShadedArea2()
        {
            DataService ds = new DataService();

            double x = 0.5;
            double y = 0.2;

            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = false;

            Assert.AreEqual(wait, res);
        }


    }
}
