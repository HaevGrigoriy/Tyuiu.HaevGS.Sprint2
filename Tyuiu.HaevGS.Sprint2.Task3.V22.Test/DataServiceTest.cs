using Tyuiu.HaevGS.Sprint2.Task3.V22.Lib;

namespace Tyuiu.HaevGS.Sprint2.Task3.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCindition()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 13;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCindition1()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.333;
            Assert.AreEqual(wait, res);
        }


        [TestMethod]
        public void ValidCindition2()
        {
            DataService ds = new DataService();
            double x = -2;
            double res = ds.Calculate(x);
            double wait = -0.909;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCindition3()
        {
            DataService ds = new DataService();
            double x = -6;
            double res = ds.Calculate(x);
            double wait = -2;
            Assert.AreEqual(wait, res);
        }   

    }
}
