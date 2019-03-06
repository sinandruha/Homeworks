using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Синицын
//1. Написать метод, возвращающий минимальное из трех чисел.

namespace dz_2._1
{
    class Program
    {
        /// <summary>
        /// Возвращает минимальное из трех чисел
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
        /// <param name="c">Третье число</param>
        /// <returns>Минимальное значение</returns>
        static int Compare(int a, int b, int c)
        {
            int min = 0;
            if (a < b && a < c)
            {
                min = a;
            }
            else if (b < c)
            {
                min = b;
            }
            else min = c;
            return min;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три числа, и программа выведет на экран наименьшее из них");

            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Compare(a, b, c));

            Console.ReadLine();
        }
    }
}
