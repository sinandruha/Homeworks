using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Синицын
/*Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h);
 где m — масса тела в килограммах, h — рост в метрах*/

namespace imt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа по расчету индекса массы тела(ИМТ)");

            Console.WriteLine("Введите массу тела в килограммах");
            double m = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите рост в метрах");
            double h = Convert.ToDouble(Console.ReadLine());
            
            var I = m / (h * h);
            Console.WriteLine("Индекс массы тела равен: " + I.ToString("f2"));
            Console.ReadLine();
        }
    }
}
