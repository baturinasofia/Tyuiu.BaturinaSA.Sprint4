using Tyuiu.BaturinaSA.Sprint4.Task2.V30.Lib;

namespace Tyuiu.BaturinaSA.Sprint4.Task2.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 3, 6, 5, 4, 2, 5, 2, 7, 2, 3, 6, 4 };
            int res = ds.Calculate(array);
            int wait = 1575;
            
            Assert.AreEqual(wait, res);
        }
    }
}