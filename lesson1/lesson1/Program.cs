using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Синицын
/*Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
а) используя склеивание;
б) используя форматированный вывод;
в) используя вывод со знаком $.*/


namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Привет, я провожу опрос для начинающих программистов.
Можешь рассказать мне о себе? Для этого нужно заполнить анкету");

            for (int i = 0; i < 1;)
            {
                var yesOrNo = Console.ReadLine();
                if (yesOrNo == "да")
                {
                    Console.WriteLine("Спасибо! Тогда приступим.");
                    Console.WriteLine("Как тебя зовут?");
                    var name = Console.ReadLine();
                    Console.WriteLine("Какая у тебя фамилия?");
                    var surname = Console.ReadLine();
                    Console.WriteLine("Сколько тебе лет?");
                    var age = Console.ReadLine();
                    Console.WriteLine("Какой у тебя рост?");
                    var height = Console.ReadLine();
                    Console.WriteLine("Сколько ты весишь?");
                    var weight = Console.ReadLine();

                    Console.WriteLine($@"Вот так выглядит твоя анкета
* Имя
{name}
* Фамилия
{surname}
* Возраст
{age}
* Рост
{height}
* Вес
{weight}");
                    i++;
                }
                else if (yesOrNo == "нет")
                {
                    Console.WriteLine("Очень жаль, пока.");
                    i++;
                }
                else
                {
                    Console.WriteLine("Введите да или нет");

                }
            }

            Console.ReadLine();

        }
    }
}
