using System;

namespace UNIT_05
{
    class Program
    {
        /*1. Сформировать одномерный массив из 7 элементов.
         Заполнить массив числами, вводимыми с клавиатуры,
         определить среднее арифметическое элементов.*/
        static void Main(string[] args)
        {
            const int n = 7;
            int[] array = new int[n];
            float Sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите {0}-й элемент массива", i + 1);
                array[i] = Convert.ToInt32(Console.ReadLine());
                Sum = Sum + array[i];
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Среднее арифметическое {0} шт. элементов составляет: {1}", n, (Sum/n));

            Console.ReadKey();
        }
    }
}
