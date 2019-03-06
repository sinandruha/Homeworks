using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Синицын
//*Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).

namespace SimpleLibrary
{
    public class Help
    {
        /// <summary>
        /// Ставит паузу при выполнении программы, до того момента пока не будет нажата любая клавиша
        /// </summary>
        static public void Pause()
        {
            Console.ReadKey();
        }
        /// <summary>
        /// Выводит на экран переменную типа string
        /// </summary>
        /// <param name="text">Текст который нужно вывести</param>
        /// <returns></returns>
        static public void Print(string text)
        {
            Console.WriteLine(text);
        }

    }
}
