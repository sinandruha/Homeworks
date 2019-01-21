using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Синицын
//а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
//Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
//б) * Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;

namespace cord
{
    class Program
    {
        static public double getDistance (int x1, int y1, int x2, int y2)
        {
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return r;
        } 

        static void Main(string[] args)
        {
            Console.WriteLine("Эта программа расчитывает расстояние между двумя точками на координатной плоскости");

            Console.WriteLine("Укажите первую координату по оси X");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Укажите первую координату по оси Y");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Укажите вторую координату по оси X");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Укажите вторую координату по оси Y");
            int y2 = Convert.ToInt32(Console.ReadLine());

            var r = getDistance(x1, y1, x2, y2);

            Console.WriteLine("Расстояние между заданными координатами = " + r.ToString("f2"));
            Console.ReadLine();
        }
    }
}
