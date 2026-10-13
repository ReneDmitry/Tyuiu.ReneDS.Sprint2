using tyuiu.cources.programming.interfaces.Sprint2;

using Tyuiu.ReneDS.Sprint2.Task6.V6.Lib;

namespace Tyuiu.ReneDS.Sprint2.Task6.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void FindCardNameAndValue1()
        {
            DataService ds = new DataService();

            int m = 1;
            int k = 12;

            string wait = "Дама пик";
            string res = ds.FindCardNameAndValue(m, k);

            Assert.AreEqual(wait, res);

            
        }

        [TestMethod]
        public void FindCardNameAndValue2()
        {
            DataService ds = new DataService();

            int m = 3;
            int k = 6;

            string wait = "Шестерка бубен";
            string res = ds.FindCardNameAndValue(m, k);

            Assert.AreEqual(wait, res);
        }
    }
}
