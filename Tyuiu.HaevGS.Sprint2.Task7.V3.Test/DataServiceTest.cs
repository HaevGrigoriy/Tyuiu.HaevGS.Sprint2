using Tyuiu.HaevGS.Sprint2.Task7.V3.Lib;

namespace Tyuiu.HaevGS.Sprint2.Task7.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 0.5;
            double y = 0.5;

            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
