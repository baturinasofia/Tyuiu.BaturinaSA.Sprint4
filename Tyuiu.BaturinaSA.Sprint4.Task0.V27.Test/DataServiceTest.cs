using Tyuiu.BaturinaSA.Sprint4.Task0.V27.Lib;

namespace Tyuiu.BaturinaSA.Sprint4.Task0.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] Array = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };
            int res = ds.GetMultOddArrEl(Array);
            int wait = 6615;

            Assert.AreEqual(res, wait);
        }
    }
}