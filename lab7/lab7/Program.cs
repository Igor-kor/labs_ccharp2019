using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Лабораторная работа 7
 * 
 * Рекурсия
 * 
 * Создать рекурсивный метод, реализующий один из следующих алгоритмов обработки последовательности чисел. 
 * 1) Последовательность Фибоначчи 
 */

namespace lab7
{
    class Program
    {
        static void fibonachi(int x, int y, int max)
        {
            if (y > max) return;
            Console.WriteLine(y);
            fibonachi(y, x + y, max);
        }

        static void Main(string[] args)
        {
            fibonachi(1, 1, 1000);
            Console.ReadKey();
        }

    }
}
