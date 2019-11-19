using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Создать рекурсивный метод, реализующий один из следующих алгоритмов обработки массива.
 * Массив заполняется случайными образом числами от -256 до +256. 
 * 1) Сумма элементов массива 
 */

namespace lab7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] array = new int[n];
            Random randNum = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = randNum.Next(-256, 256);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("\nСумма элементов массива  = " + sum(array));
            Console.ReadKey();
        }

        static int sum(int[] array, int index = 0)
        {
            if (index == array.Length - 1)
            {
                return array[index];
            }
            return array[index] + sum(array, index + 1);
        }
    }
}
