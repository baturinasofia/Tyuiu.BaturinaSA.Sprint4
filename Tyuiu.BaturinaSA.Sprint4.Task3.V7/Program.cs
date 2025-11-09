using Tyuiu.BaturinaSA.Sprint4.Task3.V7.Lib;

namespace Tyuiu.BaturinaSA.Sprint4.Task3.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 4 | Выполнила: Батурина С.А. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 4                                                                *");
            Console.WriteLine("* Тема: Базовые навыки работы с массивами в C#                            *");
            Console.WriteLine("* Задание 3                                                               *");
            Console.WriteLine("* Вариант 7                                                               *");
            Console.WriteLine("* Выполнила: Батурина Софья Алексеевна | ИСТНб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный массив 5×5, заполненный статическими значениями           *");
            Console.WriteLine("* в диапазоне от 1 до 9. Подсчитать количество нечетных элементов.        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix =
            {
                {9, 6, 9, 3, 7},
                {3, 3, 3, 8, 2},
                {2, 1, 3, 5, 2},
                {6, 2, 3, 2, 5},
                {4, 5, 6, 9, 5}
            };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            DataService ds = new DataService();
            int result = ds.Calculate(matrix);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество нечетных элементов массива = " + result);
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}