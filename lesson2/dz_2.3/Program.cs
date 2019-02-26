using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Синицын
//3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

namespace dz_2._3
{
    class Program
    {
        /// <summary>
        /// Проверяет, является ли число нечетным и положительным. В случае если число не соотвествует условию, возвращет 0.
        /// </summary>
        /// <param name="i">Число</param>
        /// <returns></returns>
        static int PosOddNum(int i)
        {
            if (i > 0 && !(i % 2 == 0))
            {
                return i;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Эта программа считает сумму всех введенных вами нечетных положительных чисел
Для вывода суммы чисел на экран напишите 0
");

            int sum = 0;

            for (; ; )
            {
                Console.WriteLine("Введите целое число");
                int i = Convert.ToInt32(Console.ReadLine());

                sum += PosOddNum(i);

                if (i == 0) break;                
            }
            Console.WriteLine($"Сумма всех введенных нечетных положительных чисел равняется {sum}");
            Console.ReadLine();
        }
    }
}
