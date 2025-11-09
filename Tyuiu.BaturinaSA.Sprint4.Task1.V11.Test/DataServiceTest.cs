using Tyuiu.BaturinaSA.Sprint4.Task1.V11.Lib;

namespace Tyuiu.BaturinaSA.Sprint4.Task1.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 2, 6, 5, 5, 1, 5, 6, 5, 5, 5, 1, 5, 3, 6, 6, 1, 6 };
            int res = ds.Calculate(array);
            int wait = 32;

            Assert.AreEqual(wait, res);
        }
    }
}