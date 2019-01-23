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
        static void compare(int a, int b, int c)
        {
            if (a < b && a < c)
            {
                Console.WriteLine(a);
            }
            else if (b < a && b < c)
            {
                Console.WriteLine(b);
            }
            else if (c < a && c < b)
            {
                Console.WriteLine(c);
            }
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

            compare(a, b, c);

            Console.ReadLine();
        }
    }
}
