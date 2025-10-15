using Tyuiu.NasadukJA.Sprint2.Task4.V6.Lib;

namespace Tyuiu.NasadukJA.Sprint2.Task4.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 1;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 20;
            double res = ds.Calculate(x, y);
            double wait = 408;
            Assert.AreEqual(wait, res);
        }
    }
}
