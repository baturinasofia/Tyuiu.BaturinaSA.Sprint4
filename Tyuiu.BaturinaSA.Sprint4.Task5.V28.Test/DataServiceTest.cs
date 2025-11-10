using Tyuiu.BaturinaSA.Sprint4.Task5.V28.Lib;

namespace Tyuiu.BaturinaSA.Sprint4.Task5.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = new int[,] 
            {
                { -6, -2, 1, 3, -2 },
                { -3, 2, -1, 1, -2 }, 
                { 1, 3, 1, 2, -4 },
                { -3, 2, 0, -5, 1 }, 
                { -1, 2, -4, 1, -6 } 
            };
            int[,] result = new int[,] 
            { 
                { 0, 0, 1, 3, 0 }, 
                { 0, 2, 0, 1, 0 }, 
                { 1, 3, 1, 2, 0 }, 
                { 0, 2, 0, 0, 1 }, 
                { 0, 2, 0, 1, 0 } 
            };
            CollectionAssert.AreEqual(result, ds.Calculate(array));
        }
    }
}
