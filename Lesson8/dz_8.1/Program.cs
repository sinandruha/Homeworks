using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Threading;

//Синицын
//1. С помощью рефлексии выведите все свойства структуры DateTime

namespace dz_8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            object date2 = new DateTime(1999, 10, 31, 11, 46, 54, 999, (DateTimeKind)2);


            if (date2.GetType() == typeof(DateTime))
            {
                DateTime date1 = (DateTime)date2;
                Console.WriteLine(date1.Date);
                Console.WriteLine(date1.Day);
                Console.WriteLine(date1.DayOfWeek);
                Console.WriteLine(date1.DayOfYear);
                Console.WriteLine(date1.Hour);
                Console.WriteLine(date1.Kind);
                Console.WriteLine(date1.Millisecond);
                Console.WriteLine(date1.Minute);
                Console.WriteLine(date1.Month);
                Console.WriteLine(date1.Second);
                Console.WriteLine(date1.Ticks);
                Console.WriteLine(date1.TimeOfDay);
                Console.WriteLine(date1.Year);
            }

            Console.ReadLine();
        }
    }
}
