using Tyuiu.HaevGS.Sprint2.Task6.V10.Lib;

namespace Tyuiu.HaevGS.Sprint2.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthSeason()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Январь", ds.FindDateOfPreviousDay(1, 1, 1));
            Assert.AreEqual("Февраль", ds.FindDateOfPreviousDay(2, 2, 2));
            Assert.AreEqual("Март", ds.FindDateOfPreviousDay(3, 3, 3));
            Assert.AreEqual("Апрель", ds.FindDateOfPreviousDay(4, 4, 4));
            Assert.AreEqual("Май", ds.FindDateOfPreviousDay(5, 5, 5));
            Assert.AreEqual("Июнь", ds.FindDateOfPreviousDay(6, 6, 6));
            Assert.AreEqual("Июль", ds.FindDateOfPreviousDay(7, 7, 7));
            Assert.AreEqual("Август", ds.FindDateOfPreviousDay(8, 8, 8));
            Assert.AreEqual("Сентябрь", ds.FindDateOfPreviousDay(9, 9, 9));
            Assert.AreEqual("Октябрь", ds.FindDateOfPreviousDay(10, 10, 10));
            Assert.AreEqual("Ноябрь", ds.FindDateOfPreviousDay(11, 11, 11));
            Assert.AreEqual("Декабрь", ds.FindDateOfPreviousDay(12, 12, 12));


            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfPreviousDay(-1, -1, -1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfPreviousDay(13, 13, 13);
            });
        }
    }
}
