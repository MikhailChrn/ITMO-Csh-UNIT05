using System;

namespace Задание_2
{
    class Program
    {
        /*2. Сформировать одномерный массив из 15 элементов,
         которые выбираются случайным образом из диапазона [0; 50].
         Определить сумму максимального и минимального элементов массива.*/
        static void Main(string[] args)
        {
            const byte n = 15;
            Console.WriteLine("Массив создаётся из {0} элементов:", n);
            int[] array = new int[n];
            Random random = new Random();

            //Заполнение массива случайными целыми числами из диапазонеа 0-50
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0} ", array[i]);
            }

            //Выполнение поиска максимального и минимального значения в массиве
            int max = array[0];
            int min = array[0];
            foreach (int a in array)
            {
                if (a > max) max = a;
                if (a < min) min = a;
            }

            Console.WriteLine();
            Console.WriteLine("Меньший элемент массива min = {0}, ,больший элемент max = {1}", min, max);
            Console.WriteLine("Сумма максимального и минимального элементов max + min = {0}", (max + min));
            Console.ReadKey();
        }
    }
}
