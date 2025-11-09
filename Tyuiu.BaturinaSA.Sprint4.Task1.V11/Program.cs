using Tyuiu.BaturinaSA.Sprint4.Task1.V11.Lib;

namespace Tyuiu.BaturinaSA.Sprint4.Task1.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 4 | Выполнила: Батурина С. А. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 4                                                                *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание 1                                                               *");
            Console.WriteLine("* Вариант 11                                                               *");
            Console.WriteLine("* Выполнила: Батурина Софья Алексеевна | ИСТНб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 17 элементов,                    *");
            Console.WriteLine("* заполненный значениями с клавиатуры в диапазоне от 1 до 6.              *");
            Console.WriteLine("* Подсчитать сумму четных элементов массива.                              *");
            Console.WriteLine("* С клавиатуры: 2, 6, 5, 5, 1, 5, 6, 5, 5, 5, 1, 5, 3, 6, 6, 1, 6         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] nums = new int[17];
            Console.WriteLine("Введите 17 целых чисел:");

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"Введите значение {i + 1}-го элемента массива: ");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Введённый массив:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();

            DataService ds = new DataService();
            int result = ds.Calculate(nums);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма четных элементов массива = " + result);

            Console.ReadKey();
        }
    }
}