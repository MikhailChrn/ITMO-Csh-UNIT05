using System;

namespace Задание_04
{
    class Program
    {
        /*4. Сформировать одномерный массив из 20 случайных чисел в диапазоне [-50;50].
         Определить количество нечетных положительных элементов, стоящих на четных местах.*/

        static void Main(string[] args)
        {
            const byte n = 20; //Константой задаём количество элементов массива

            Console.WriteLine("Массив создаётся из {0} элементов:", n);
            int[] array = new int[n];
            Random random = new Random();

            //Провожу формирование исходного массива случайными числами
            int i = 0;
            for (i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0,4} ", array[i]);
            }

            int t = 0; //Счётчик нечётных положительных элементов
            i = 1;
            while (i <= n)
            {
                if ((array[i] % 2 != 0) && (array[i] > 0))
                {
                    t++;
                }
                i = i + 2;
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Количество нечётных положительных элементов, стоящих на чётных местах составляет: {0}", t);
            Console.ReadKey();

        }
    }
}
