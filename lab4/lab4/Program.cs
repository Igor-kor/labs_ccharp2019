using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Вариант 1
 * В одномерном массиве, состоящем из п вещественных элементов, вычислить:
 * сумму отрицательных элементов массива;
 * произведение элементов массива, расположенных между максимальным и минимальным элементами.
 * Упорядочить элементы массива по возрастанию.
 */

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32( Console.ReadLine());
            int[] array = new int[n];
            Random randNum = new Random();
            for (int i = 0; i < n; i++)
            {                
                array[i] = randNum.Next(-100, 100);
            }
            int sum = 0, minindex =0,maxindex = 0,min = array[0],max = array[0];
            for (int i = 0; i < n; i++)
            {
                if (array[i] < 0) sum += array[i];
                if (array[i] < min) {
                    min = array[i];
                    minindex = i;
                }
                if (array[i] > max)
                {
                    max = array[i];
                    maxindex = i;
                }
            }
            int indexstart = 0, indexfinish = 0;
            if(maxindex > minindex)
            {
                indexstart = minindex;
                indexfinish = maxindex;
            }
            else
            {
                indexstart = maxindex;
                indexfinish = minindex;
            }
            int proizved = 1;
            for(int i = indexstart;i < indexfinish; i++)
            {
                proizved *= array[i];
            }
            array = array.OrderBy(x => x).ToArray();

            Console.WriteLine(sum);
            Console.WriteLine(proizved);
            Console.WriteLine(string.Join(" ", array));
            Console.ReadKey();
        }
    }
}
;