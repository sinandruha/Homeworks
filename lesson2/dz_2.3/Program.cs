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
        static void Main(string[] args)
        {
            Console.WriteLine(@"Эта программа считатет сумму всех введенных вами нечетных положительных чисел
Для вывода суммы чисел на экран напишите 0
");

            int sum = 0;

            for (; ; )
            {
                Console.WriteLine("Введите целое число");
                int i = Convert.ToInt32(Console.ReadLine());

                if (i > 0 && !(i % 2 == 0))
                {
                    sum = sum + i;
                }
                else if (i == 0)
                {
                    break;
                }
            }
            Console.WriteLine($"Сумма всех введенных нечетных положительных чисел равняется {sum}");
            Console.ReadLine();
        }
    }
}
