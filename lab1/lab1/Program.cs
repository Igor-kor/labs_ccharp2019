using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Лабораторная работа №1
 * 
 * Программы линейной структуры
 * 
 * 1 вариант
 * 
 */

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите альфа");
            double alpha = Convert.ToDouble(Console.ReadLine());

            double z1 = Math.Cos(2 * alpha) + Math.Sin(3 * alpha) + Math.Cos(3 * alpha) + Math.Sin(2 * alpha);
            double z2 = 1 / 3 -( Math.Sin(Math.PI / 2 - 6 * alpha) / 2);

            Console.WriteLine("z1 = " + z1);
            Console.WriteLine("z2 = " + z2);
            Console.ReadKey();
        }
    }
}
