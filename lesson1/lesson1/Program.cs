using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleLibrary;

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
            Help.Print(@"Привет, я провожу опрос для начинающих программистов.
Можешь рассказать мне о себе? Для этого нужно заполнить анкету");

            for (int i = 0; i < 1;)
            {
                var yesOrNo = Console.ReadLine();
                if (yesOrNo == "да")
                {
                    // (имя, фамилия, возраст, рост, вес)
                    Help.Print("Спасибо! Тогда приступим.");
                    Help.Print("Как тебя зовут?");
                    var name = Console.ReadLine();
                    Help.Print("Какая у тебя фамилия?");
                    var surname = Console.ReadLine();
                    Help.Print("Сколько тебе лет?");
                    var age = Console.ReadLine();
                    Help.Print("Какой у тебя рост?");
                    var height = Console.ReadLine();
                    Help.Print("Сколько ты весишь?");
                    var weight = Console.ReadLine();

                    Help.Print($@"Вот так выглядит твоя анкета
* Имя {name}
* Фамилия {surname}
* Возраст {age} лет
* Рост {height} см
* Вес {weight} кг");
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
