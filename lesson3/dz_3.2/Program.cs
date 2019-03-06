using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleLibrary;

//Синицын
//2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке).
//Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
//б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.При возникновении ошибки вывести сообщение.
//Напишите соответствующую функцию;

namespace dz_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Эта программа считатет сумму всех введенных вами нечетных положительных чисел
Для вывода суммы чисел на экран напишите 0
");
            double a;
            double sum = 0;
            bool flag;
            do
            {
                Console.WriteLine("Введите число:");
                string s = Console.ReadLine();
                flag = double.TryParse(s, out a);

                sum += SimpleMath.PosOddNum(a);

                if (!flag && a == 0)
                {
                    Console.WriteLine("Введены некорректные данные. Попробуйте еще раз.");
                }
            }
            while (!(flag && a == 0));

            Console.WriteLine($"Сумма всех введенных нечетных положительных чисел равняется {sum}");
            Console.ReadLine();
        }
    }
}
