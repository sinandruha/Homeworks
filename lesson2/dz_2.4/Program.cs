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
        static void access(string l, string p)
        {
                int count = 1;
            do
            {
                Console.WriteLine("Введите логин");
                string ul = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                string up = Console.ReadLine();

                if (count < 3 && ul == l && up == p)
                {
                    Console.WriteLine("Данные введены верно. Доступ разрешен");
                    break;
                }
                else if (count < 3)
                {
                    Console.WriteLine($@"Проверьте правильность логина и пароля и попробуйте еще раз.
У вас осталость {3 - count} попытки(а)");
                    count++;
                }
                else if (count >= 3)
                {
                    Console.WriteLine("Вы ввели неверные данные слишком много раз. Доступ заблокирован");
                }
            }
            while (true);
        }
        static void Main(string[] args)
        {
            string l = "root";//задается логин
            string p = "GeekBrains";//задается пароль

            access(l,p);
            
            Console.WriteLine("Добро пожаловать в личный кабинет.");
            Console.ReadLine();
        }
    }
}
