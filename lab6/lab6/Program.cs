using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
 * Лабораторная работа №6 
 * Методы
 * 
 * Вариант 1
 * Написать программу, реализующую десятичный счетчик,
 * который может увеличивать или уменьшать свое значение на единицу в заданном диапазоне. 
 * Предусмотреть инициализацию счетчика значениями по умолчанию и произвольными значениями. 
 * Счетчик имеет два метода: увеличения и уменьшения, — и свойство, позволяющее получить его текущее состояние. 
 */

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            counter counter1 = new counter();
            counter counter2 = new counter(50, 0, 100);

            Console.WriteLine("Счетчик 1 = " + counter1.get());
            Console.WriteLine("Счетчик 2 = " + counter2.get());

            counter1.increase();
            counter1.increase();
            counter2.decrease();

            Console.WriteLine("");
            Console.WriteLine("Счетчик 1 = "+ counter1.get());
            Console.WriteLine("Счетчик 2 = " + counter2.get());
            Console.ReadKey();
        }
    }

    class counter
    {
        private int count;
        private int min;
        private int max;

        public counter()
        {
            min = -10;
            max = 10;
            count = min;
        }

        public counter(int count, int min, int max)
        {
            if (count < min || count > max)
            {
                Console.WriteLine("Значение счетчика не может быть меньше или больше заданного диапозона!");
                count = min;
            }
            this.count = count;
            this.min = min;
            this.max = max;
        }

        public void increase()
        {
            if (count > max - 1)
            {
                Console.WriteLine("Значение счетчика максимально!");
                count = min;
            }
            else
            {
                count++;
            }
        }

        public void decrease()
        {
            if (count > max - 1)
            {
                Console.WriteLine("Значение счетчика минимально!");
                count = max;
            }
            else
            {
                count--;
            }
        }

        public int get()
        {
            return count;
        }
    }
}
