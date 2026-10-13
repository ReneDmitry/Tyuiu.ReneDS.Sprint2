
using tyuiu.cources.programming.interfaces.Sprint2;
using Tyuiu.ReneDS.Sprint2.Task5.V12.Lib;

namespace Tyuiu.ReneDS.Sprint2.Task5.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void FindDateOfPreviousDay1()
        {
            DataService ds = new DataService();

            int g = 2024;
            int m = 3;
            int n = 1;

            string wait = "29.02.2024";
            string res = ds.FindDateOfPreviousDay(g, m, n);

            Assert.AreEqual(wait, res);
        }

            [TestMethod]
            
            public void FindDateOfPreviousDay2()
            {
            DataService ds = new DataService();

            int g = 2024;
            int m = 1;
            int n = 1;

            string wait = "31.12.2023";
            string res = ds.FindDateOfPreviousDay(g, m, n);

            Assert.AreEqual(wait, res);


            }

        
    }
}
