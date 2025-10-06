using Tyuiu.HaevGS.Sprint2.Task4.V7.Lib;

namespace Tyuiu.HaevGS.Sprint2.Task4.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 3.5;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 15;
            double res = ds.Calculate(x, y);
            double wait = 1.167;
            Assert.AreEqual(wait, res);
        }
    }
}
