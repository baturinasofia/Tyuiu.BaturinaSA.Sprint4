using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.BaturinaSA.Sprint4.Task4.V13.Lib
{
    public class DataService : ISprint4Task4V13
    {
        public int Calculate(int[,] matrix)
        {
            int sum = 0;
            foreach (int c in matrix)
            {
                if (c % 2 == 0) sum += c;
            }
            return sum;
        }
    }
}
