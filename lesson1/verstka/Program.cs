using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Синицын
//а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
//б) Сделать задание, только вывод организуйте в центре экрана
//в) * Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)
namespace verstka
{
    class Program
    {
        //Сделал метод и возможность вводить имя, фамилию, город, но это все здесь явно лишнее, с моим колхозом)
        static void WriteInCentre(string name, string surname, string city)
        {
            Console.WriteLine($@"









                            Меня зовут: {name} {surname}
                         Проживаю в городе {city}");
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Как тебя зовут?");
            //var name = Console.ReadLine();
            //Console.WriteLine("Какая у тебя фамилия?");
            //var surname = Console.ReadLine();
            //Console.WriteLine("В каком городе ты живешь?");
            //var city = Console.ReadLine();

            //WriteInCentre(name, surname, city);

            //Очень колхозное форматирование получилось, но по другому я пока не умею)
            Console.WriteLine($@"









                            Меня зовут: Андрей Синицын
                         Проживаю в городе Санкт-Петербург");
            Console.ReadLine();

        }
    }
}
