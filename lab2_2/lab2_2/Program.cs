﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
 * Операторы ветвления: условный оператор, оператор выбора switch.
 * 
 * 1 вариант
 * 
 * задача 5.2 Попадание точки в заштрихованную область
 */

namespace lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // координаты точки
            Console.WriteLine("Введите x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y");
            double y = Convert.ToDouble(Console.ReadLine());
            // радиус
             Console.WriteLine("Введите R");
            double R = Convert.ToDouble(Console.ReadLine());
            // формула окружности 
            // Math.Sqrt(R - x * x); при х > 0
            // -Math.Sqrt(R - x * x); при х <0
            // формула для линий 
            // y = sqrt((x)^2) при х > 0
            // y = -sqrt((x)^2) при х <0
            if (Math.Abs(y) <= Math.Abs(Math.Sqrt(R * R - x * x)) && ((x >= 0) && y >= Math.Sqrt(x * x) || (x < 0) && y <= -1 * Math.Sqrt(x * x)))
            {
                Console.WriteLine("Точка в заштрихованной области");
            }else
            {
                Console.WriteLine("Точка не принадлежит заштрихованной области");
            }
            Console.ReadKey();

        }
    }
}
