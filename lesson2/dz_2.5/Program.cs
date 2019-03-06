using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Синицын
//а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает,
//   нужно ли человеку похудеть, набрать вес или всё в норме.
//б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.


namespace dz_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа по расчету индекса массы тела(ИМТ)");

            Console.WriteLine("Введите массу тела в килограммах");
            double m = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите рост в метрах, пример: (1,86)");
            double h = Convert.ToDouble(Console.ReadLine());

            var I = m / (h * h);//индекс массы тела

            double GoodWeiqht = 22 * (h * h);//оптимальная масса тела исходя из роста
            double NeedWeight;

            Console.WriteLine("Ваша оптимальная масса тела равна: " + GoodWeiqht.ToString("f2"));

            Console.WriteLine("Индекс массы тела равен: " + I.ToString("f2"));

            if (I < 16) Console.WriteLine("У вас выраженный дефицит массы тела");
            else if (I >= 16 && I < 18.5) Console.WriteLine("У вас недостаточная(дефицит) масса тела");
            else if (I >= 18.5 && I < 24.99) Console.WriteLine("Ваша масса тела в норме");
            else if (I >= 25 && I < 30) Console.WriteLine("У вас избыточная масса тела(предожирение)");
            else if (I >= 30 && I < 35) Console.WriteLine("У вас ожирение");
            else if (I >= 35 && I < 40) Console.WriteLine("У вас резкое ожирение");
            else if (I >= 40) Console.WriteLine("У вас очень резкое ожирение");

            if (I < 18.5)
            {
                NeedWeight = GoodWeiqht - m;
                Console.WriteLine("Для нормализации веса вам нужно набрать " + NeedWeight.ToString("f2") + " кг");
            }
            else if (I >= 25)
            {
                NeedWeight = m - GoodWeiqht;
                Console.WriteLine("Для нормализации веса вам нужно похудеть на " + NeedWeight.ToString("f2") + " кг");
            }
            Console.ReadLine();
        }
    }
}
