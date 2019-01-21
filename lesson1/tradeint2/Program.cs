using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Синицын
//Написать программу обмена значениями двух переменных.
//б) * без использования третьей переменной.
//Программу дописать не смог. Не понял как в переменную MyString заводить данные от пользователя.

namespace tradeint2
{
    class MyString
    {
        public int MyProperty { get; set; }

        public MyString (int a)
        {
            MyProperty = a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Здравствуйте, вас приветствует программа обмена значениями переменных.
");

            Console.WriteLine("Задайте значение первой переменной (используйте целые числа)");
            MyString x1 = new MyString(Console.ReadLine());
            Console.WriteLine("Задайте значение второй переменной (используйте целые числа)");
            MyString x2 = new MyString(Console.ReadLine());
            x1 = x2;
            x2 = x1;

            Console.WriteLine("Теперь нажмите Enter для обмена значениями переменных");
            Console.ReadLine();

            Console.WriteLine($@"Теперь первая переменная равняется {x1}
А вторая переменная равняется {x2}");
            Console.ReadLine();

        }
    }
}
