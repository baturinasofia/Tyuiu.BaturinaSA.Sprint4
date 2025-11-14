using Tyuiu.BaturinaSA.Sprint4.Task7.V7.Lib;

namespace Tyuiu.BaturinaSA.Sprint4.Task7.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int rows = 4;
            int columns = 2;
            int[,] mtrx = new int[rows, columns];
            string str = "31415926";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, columns, str);
            int wait = 5;
            Assert.AreEqual(wait, res);
        }
    }
}
