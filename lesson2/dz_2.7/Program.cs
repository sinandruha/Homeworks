using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Синицын
//a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
//б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.

namespace dz_2._7
{
    class Program
    {
        /// <summary>
        /// Выводит на экран числа от a до b (a должно быть меньше b)
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
        /// <returns></returns>
        static int Counter(int a, int b)
        {
            if (a == b)
            {
                return b;
            }
            else
            {
                Console.Write(a + " ");
                return Counter(a+1, b);
            }
        }
        /// <summary>
        /// Считает сумму чисел от a до b
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
        /// <returns></returns>
        static int CounterSum(int a, int b)
        {
            if (a == b)
            {
                return b;
            }
            else
            {
                return a + CounterSum(a + 1, b);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Демонстрация работы метода Counter");
            Console.WriteLine(Counter(1, 65));
            Console.WriteLine("Демонстрация работы метода CounterSum\n" + CounterSum(2, 7));
            Console.ReadLine();
        }
    }
}
