using System;

namespace Задание_05
{
    class Program
    {
        /*5. Запросить у пользователя целочисленное значение N.
         Сформировать двумерный массив размера NxN следующего вида:
         1 0 1 0 1
         0 1 0 1 0
         1 0 1 0 1
         0 1 0 1 0
         1 0 1 0 1
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите величину больше единицы для стороны двумерного массива NхN:");
            byte N = Convert.ToByte(Console.ReadLine());
            byte[,] array = new byte[N, N];

            //Заполнение массива символом '1'
            for (byte i = 0; i < N; i++)
            {
                for (byte j = 0; j < N; j++)
                {
                    array[i, j] = 1;
                }

            }

            //Заполняем исходный массив символом '0' через одну ячейку
            byte f = 1;
            for (byte i = 0; i < N; i++)
            {
                for (byte j = 0; j < N; j++)
                {
                    if (f % 2 == 0)
                    {
                        array[i, j] = 0;
                    }
                    f++;
                }
                if (N % 2 == 0) { f++; } //В случае чётоности значения величины массива NхN 
            }

            for (byte i = 0; i < N; i++)
            {
                for (byte j = 0; j < N; j++)
                {
                    Console.Write("{0,3}", array[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

    }
}
