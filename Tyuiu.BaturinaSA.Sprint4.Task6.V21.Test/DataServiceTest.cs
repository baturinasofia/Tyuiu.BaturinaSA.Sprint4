using Tyuiu.BaturinaSA.Sprint4.Task6.V21.Lib;

namespace Tyuiu.BaturinaSA.Sprint4.Task6.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValivCalculate()
        {
            DataService ds = new DataService();

            var week = new string[] { "Facebook", "Twitter", "Instagram", "Snapchat", "LinkedIn", "Pinterest", "Reddit" };
            int res = ds.Calculate(week);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
