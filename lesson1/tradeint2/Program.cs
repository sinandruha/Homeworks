using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Синицын
//Написать программу обмена значениями двух переменных.
//б) * без использования третьей переменной.
//Доделал задание, оказывается все было проще)

namespace tradeint2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Здравствуйте, вас приветствует программа обмена значениями переменных.
");

            Console.WriteLine("Задайте значение первой переменной (используйте целые числа)");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Задайте значение второй переменной (используйте целые числа)");
            int x2 = Convert.ToInt32(Console.ReadLine());
            x2 = x1 + x2;
            x1 = x2 - x1;
            x2 = x2 - x1;

            Console.WriteLine("Теперь нажмите Enter для обмена значениями переменных");
            Console.ReadLine();

            Console.WriteLine($@"Теперь первая переменная равняется {x1}
А вторая переменная равняется {x2}");
            Console.ReadLine();

        }
    }
}
