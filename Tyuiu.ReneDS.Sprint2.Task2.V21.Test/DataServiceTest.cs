using tyuiu.cources.programming.interfaces.Sprint2;

using Tyuiu.ReneDS.Sprint2.Task2.V21.Lib;

namespace Tyuiu.ReneDS.Sprint2.Task2.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            int x = 6;
            int y = 7;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
