using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
 * Операторы ветвления: условный оператор, оператор выбора switch.
 * 
 * 1 вариант
 * 
 * задача 5.1 (вычислите значение функции)
 * 
 */

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x < -9 || x > 9)
            {
                Console.WriteLine("Число x за пределами функции");
            }
            if (x == -9)
            {
                Console.WriteLine("y = 0");
            }
            //y=-1sqrt(9-(x+6)^2) окружность
            if (x > -9 && x < -6)
            {
                Console.WriteLine("y = " + (-1 * Math.Sqrt(9 - Math.Pow(x + 6,2) )));
            }
            if (x == -6)
            {
                Console.WriteLine("y = -3");
            }
            // y=x+3
            if (x > -6 && x < -3)
            {
                Console.WriteLine("y = " + (x + 3));
            }
            if (x == -3)
            {
                Console.WriteLine("y = 0");
            }
            // y=sqrt(9-(x)^2) окружность
            if (x > -3 && x < -0)
            {        
                Console.WriteLine("y = " + ( Math.Sqrt(9 - x*x)));
            }
            if (x == 0)
            {
                Console.WriteLine("y = 3");
            }
            // y=3-x
            if (x > 0 && x < 3)
            {
                Console.WriteLine("y = " + (3 - x));
            }
            if (x == 3)
            {
                Console.WriteLine("y = 0");
            }
            // y= (x-3)/2
            if (x > 3 && x < 9)
            {
                Console.WriteLine("y = " + ((x - 3) / 2));
            }

            Console.ReadKey();
        }
    }
}
