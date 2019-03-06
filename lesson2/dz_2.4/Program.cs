using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Синицын
//4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь,
//если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу:
//пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
//С помощью цикла do while ограничить ввод пароля тремя попытками.


namespace dz_2._4
{
    class Program
    {
        /// <summary>
        /// Метод проверки логина и пароля.
        /// </summary>
        /// <param name="l">Заданный логин</param>
        /// <param name="p">Заданный пароль</param>
        /// <param name="ul">Логин введенный пользователем</param>
        /// <param name="up">Пароль введенный пользователем</param>
        /// <returns>Возвращает истину, если прошел авторизацию, и ложь, если не прошел</returns>
        static bool Access(string l, string p, string ul, string up)
        {
            if (ul == l && up == p)
            {
                return true;
            }
            else return false;
        }
        static void Main(string[] args)
        {
            string l = "root";//задается логин
            string p = "GeekBrains";//задается пароль

            int count = 1;
            do
            {
                Console.WriteLine("Введите логин");
                string ul = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                string up = Console.ReadLine();

                if (count < 3 && Access(l,p,ul,up))
                {
                    Console.WriteLine("Данные введены верно. Доступ разрешен.");
                    break;
                }
                else if (count < 3)
                {
                    Console.WriteLine($@"Проверьте правильность ввода логина и пароля и попробуйте еще раз.
У вас осталость {3 - count} попытки(а)");
                    count++;
                }
                else if (count >= 3)
                {
                    Console.WriteLine("Вы ввели неверные данные слишком много раз. Доступ заблокирован");
                }
            }
            while (true);
            
            Console.WriteLine("Добро пожаловать в личный кабинет.");
            Console.ReadLine();
        }
    }
}
