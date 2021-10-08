using System;

namespace Задание_06
{
    class Program
    {
        /*6. Запросить у пользователя целочисленное значение N.
         Сформировать двумерный массив размера NxN.
         Заполнить массив числами, вводимыми с клавиатуры.
         Проверить, является ли введенная с клавиатуры матрица магическим квадратом.
         Магическим квадратом называется матрица, сумма элементов которой в каждой строке,
         в каждом столбце и по каждой диагонали одинакова.*/

        static void Main(string[] args)
        {
            Console.WriteLine("Введите величину больше единицы для стороны двумерного массива NхN:");
            byte N = Convert.ToByte(Console.ReadLine());
            int[,] array = new int[N, N];

            Console.WriteLine("Введите последовательно элементы двумерного массива NхN:");
            for (byte y = 0; y < N; y++)
            {
                for (byte x = 0; x < N; x++)
                {
                    array[y, x] = Convert.ToInt16(Console.ReadLine());
                }
                Console.WriteLine();
            }

            //Создаём массив для сохранения данных о сумме элементов всех строк, столбцов и диаганалей квадрата
            int[] magicArray = new int[(N + N + 2)];

            //Сохраняем суммы всех строк
            for (int i = 0; i < N; i++)
            {
                for (int x = 0; x < N; x++)
                {
                    magicArray[i] = magicArray[i] + array[i, x];
                }
            }
            //Сохраняем суммы всех столбцов
            for (int i = 0; i < N; i++)
            {
                for (int y = 0; y < N; y++)
                {
                    magicArray[N + i] = magicArray[N + i] + array[y, i];
                }
            }
            //Сохраняем суммы диаганалей
            for (int i = 0; i < N; i++)
            {
                magicArray[2 * N] = magicArray[2 * N] + array[i, i];
                magicArray[2 * N + 1] = magicArray[2 * N + 1] + array[N - 1 - i, N - 1 - i];
            }

            Console.WriteLine();
            //Вывод на консоль значений сумм
            Console.WriteLine("Суммы всех строк, столбцов и диаганалей следующие:");
            for (int i = 0; i < (N + N + 2); i++)
            {
                Console.WriteLine("{0}", magicArray[i]);
            }

            Console.WriteLine();
            //Проверка на признак "магический квадрат"
            bool M = true;
            for (int i = 1; i < (N + N + 1); i++)
            {
                if (magicArray[0] != magicArray[i])
                {
                    M = false;
                }
            }
            if (M == true) { Console.WriteLine("Данная матрица размерами {0}х{0} отвечает признаку 'магический квадрат'", N); }

            Console.ReadKey();
        }
    }
}
