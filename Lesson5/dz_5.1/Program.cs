using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//Синицын
/* Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов,
содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
а) без использования регулярных выражений;
б) ** с использованием регулярных выражений.
*/

namespace dz_5._1
{
    class Program
    {
        /// <summary>
        /// Проверяет содержит ли строка только буквы латинского алфавита или цифры, если да - то возвращает true, если строка содержит другие символы  - то false
        /// </summary>
        /// <param name="ss">Строка</param>
        /// <returns>Возвращает true или false</returns>
        public static bool LatsOrNumbers_Found(string ss)
        {
            bool found = false;
            int count = 0;
            for (int i = 0; i < ss.Length; i++)
            {
                if (((ss[i] >= 'a') && (ss[i] <= 'z')) || ((ss[i] >= 'A') && (ss[i] <= 'Z')) || char.IsDigit(ss[i]))
                {
                    count++;
                    if(count == ss.Length)
                    {
                        found = true;
                    }
                }
            }
            return found;
        }
        /// <summary>
        /// Проверяет строку на обязательное наличие хотя-бы одного числа в ней
        /// </summary>
        /// <param name="ss">Строка</param>
        /// <returns>Возвращает true или false</returns>
        public static bool AtLeastOneNumber(string ss)
        {
            bool found = false;
            for (int i = 0; i < ss.Length; i++)
            {
                if (char.IsDigit(ss[i]))
                {
                    found = true;
                }
            }
            return found;
        }
        static void Main(string[] args)
        {
            //Задание а)
            while (true)
            {
                Console.WriteLine("Введите логин:");
                string login = Console.ReadLine();

                //Также я добавил проверку логина на то, чтобы в нем обязательно присутствовали цифры
                if (LatsOrNumbers_Found(login) && !char.IsDigit(login[0]) && AtLeastOneNumber(login) && login.Length >= 2 && login.Length <= 10)
                {
                    Console.WriteLine("Логин принят");
                    break;
                }
                else
                {
                    Console.WriteLine("Данные введены некорректно. Попробуйте еще раз");
                }
            }
            Console.ReadLine();



            //Задание б)
            while (true)
            {
                Regex myReg = new Regex(@"^[A-Za-z][A-Za-z0-9]{1,9}");
                Console.WriteLine("Введите логин:");
                string login = Console.ReadLine();

                if (myReg.IsMatch(login))
                {
                    Console.WriteLine("Логин принят");
                    break;
                }
                else
                {
                    Console.WriteLine("Данные введены некорректно. Попробуйте еще раз");
                }
            }
            Console.ReadLine();

            //Еще один способ проверки с помощью регулярных выражений
            while (true)
            {
                Console.WriteLine("Введите логин:");
                string login = Console.ReadLine();

                Console.WriteLine(Regex.Matches(login, @"^[a-z][a-z0-9]{1,9}", RegexOptions.IgnoreCase));
            }
        }
    }
}
