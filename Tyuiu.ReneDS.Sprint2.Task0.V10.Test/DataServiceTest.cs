using tyuiu.cources.programming.interfaces.Sprint2;

using Tyuiu.ReneDS.Sprint2.Task0.V10.Lib;

namespace Tyuiu.ReneDS.Sprint2.Task0.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 1305;
            int y = 475;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { false, true, false, true, false, true };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
