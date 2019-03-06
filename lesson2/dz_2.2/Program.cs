using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Синицын
//2. Написать метод подсчета количества цифр числа.

namespace dz_2._2
{
    class Program
    {
        /// <summary>
        /// Подсчитывает количество цифр в целом положительном числе
        /// </summary>
        /// <param name="x">Число</param>
        /// <returns>Количество цифр в числе</returns>
        static int Num(int x)
        {
            int count = 0;
            while (x > 0)
            {
                x = x / 10;
                count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Программа подсчета количества цифр числа\n");

            Console.WriteLine("Напишите любое целое положительное число");
            int x = Convert.ToInt32(Console.ReadLine());
            int i = Num(x);

            Console.WriteLine($"В вашем числе {i} цифр");

            Console.ReadLine();
        }
    }
}
