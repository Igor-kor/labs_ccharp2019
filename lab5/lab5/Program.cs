using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
 * Вариант 1
 * Дана целочисленная прямоугольная матрица. Определить:
 * количество строк, не содержащих ни одного нулевого элемента;
 * максимальное из чисел, встречающихся в заданной матрице более одного раза.
 */
namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int m = 8;
            int[,] array = new int[n,m];
            Random randNum = new Random();
            bool nullElement = false;
            int countNotNull = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i,j] = randNum.Next(-100, 100);
                    Console.Write(array[i,j] + " ");
                    if (array[i, j] == 0) nullElement = true;
                }
                if (!nullElement) countNotNull++;
                nullElement = false;
                Console.Write("\n");
            }
            int[] array1d = array.Cast<int>().ToArray().OrderBy(x => x).ToArray();
            for(int i = array1d.Length - 1; i > 1; i--)
            {
                if(array1d[i] == array1d[i - 1])
                {
                    Console.WriteLine("Максимальное из чисел, встречающихся в заданной матрице более одного раза = " + array1d[i]);
                    break;
                }
            }
            Console.WriteLine("Количество строк, не содержащих ни одного нулевого элемента = " + countNotNull);
            Console.ReadKey();
        }
    }
}
