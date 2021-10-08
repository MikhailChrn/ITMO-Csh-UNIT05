using System;

namespace Задание_03
{
    class Program
    {
        /*3. Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50;50].
         Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.*/
        static void Main(string[] args)
        {
            const byte n = 10; //Константой задаём количество элементов массива

            Console.WriteLine("Массив создаётся из {0} элементов:", n);
            int[] array = new int[n];
            int[] halfArray = new int[n];
            Random random = new Random();

            //Провожу заполнение исходного массива случайными числами
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0,4}", array[i]);
            }
            //Произвожу сортировку элементов исходного массива в порядке возрастания
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] > array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }

            //Создаю копию исходного массива для фиксации данных
            for (int i = 0; i < n; i++)
            {
                halfArray[i] = array[i];
            }

            //Начиная со второй половины элементов исходного массива переношу в обратном порядке значения из зафиксированной копии
            int q = 1;
            for (int i = n / 2; i < n; i++)
            {
                array[i] = halfArray[(n - q)];
                q++;
            }

            //Вывожу на консоль все отсортированные элементы исходного массива
            Console.WriteLine();
            Console.WriteLine("Результат сортировки:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0,4}", array[i]);
            }

            Console.ReadKey();
        }
    }
}
