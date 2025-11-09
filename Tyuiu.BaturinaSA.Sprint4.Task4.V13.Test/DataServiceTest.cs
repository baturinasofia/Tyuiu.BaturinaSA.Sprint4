using Tyuiu.BaturinaSA.Sprint4.Task4.V13.Lib;

namespace Tyuiu.BaturinaSA.Sprint4.Task4.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] numsArray = new int[5, 5] 
            { 
              { 6, 3, 5, 7, 5 }, 
              { 3, 5, 7, 4, 5 }, 
              { 5, 6, 4, 5, 4 }, 
              { 7, 4, 7, 3, 3 }, 
              { 4, 6, 5, 5, 6 } 
            };
            int res = ds.Calculate(numsArray);
            Assert.AreEqual(44, res);
        }
    }
}
