using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Синицын
//2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке).
//Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
//б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.При возникновении ошибки вывести сообщение.
//Напишите соответствующую функцию;

namespace dz_3._2
{
    class Program
    {
        static string console_message = "Введите число:";

        /// <summary>
        /// Метод для получения числа типа double при вводе с клиентской консоли
        /// </summary>
        /// <param name="message">Сообщение которое выдается перед запросом ввода числа</param>
        /// <returns>Число типа double</returns>
        static double GetValue(string message)
        {
            double i;
            string s;
            bool flag;

            do
            {
                Console.WriteLine(message);
                s = Console.ReadLine();
                flag = double.TryParse(s, out i);

                if (!flag)
                {
                    Console.WriteLine("Введены некорректные данные. Попробуйте еще раз.");
                }
            }
            while (!flag);
            return i;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Эта программа считатет сумму всех введенных вами нечетных положительных чисел
Для вывода суммы чисел на экран напишите 0
");

            double sum = 0;

            for (; ; )
            {
                double i = GetValue(console_message);

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
