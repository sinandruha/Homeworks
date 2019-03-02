using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrary
{
    public class SimpleMath
    {
        /// <summary>
        /// Возвращает сумму двух чисел типа double
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
        /// <returns>Сумма</returns>
        public static double Sum(double a, double b)
        {
            double sum = a + b;
            return sum;
        }
        /// <summary>
        /// Возвращает сумму двух чисел типа int
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
        /// <returns>Сумма</returns>
        public static int Sum(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        /// <summary>
        /// Проверяет, является ли число нечетным и положительным. В случае если число не соотвествует условию, возвращет 0.
        /// </summary>
        /// <param name="i">Число</param>
        /// <returns></returns>
        public static double PosOddNum(double i)
        {
            if (i > 0 && !(i % 2 == 0))
            {
                return i;
            }
            return 0;
        }
        /// <summary>
        /// Проверяет, является ли число нечетным и положительным. В случае если число не соотвествует условию, возвращет 0.
        /// </summary>
        /// <param name="i">Число</param>
        /// <returns></returns>
        public static int PosOddNum(int i)
        {
            if (i > 0 && !(i % 2 == 0))
            {
                return i;
            }
            return 0;
        }
    }
}
