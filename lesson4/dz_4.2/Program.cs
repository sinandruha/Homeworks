using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SimpleLibrary;

//Синицын
/*
2. а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив заданной размерности и заполняющий массив
числами от начального значения с заданным шагом. Создать свойство Sum, которые возвращают сумму элементов массива, метод Inverse,
меняющий знаки у всех элементов массива, метод Multi, умножающий каждый элемент массива на определенное число, свойство MaxCount,
возвращающее количество максимальных элементов. В Main продемонстрировать работу класса.
б)Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
*/

namespace dz_4._2
{
    class Program
    {
        /// <summary>
        /// Метод для вывода всех элементов массива на экран
        /// </summary>
        /// <param name="a">Массив к которому нужно применить данный метод</param>
        public static void Print(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + "; ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Создал экземпляр класса MyArray");
            MyArray arr = new MyArray(20, 0, (short)1);
            Console.WriteLine(arr.ConvertToString());
            Console.ReadLine();

            Console.WriteLine("Демонстрирую работу свойства Sum");
            Console.WriteLine(arr.Sum);
            Console.ReadLine();

            Console.WriteLine("Демонстрирую работу свойства MaxCount");
            MyArray arr2 = new MyArray(10, 1, 3);
            Console.WriteLine(arr2.ConvertToString());
            Console.WriteLine(arr2.MaxCount);
            Console.ReadLine();

            Console.WriteLine("Заполнил массив с помощью метода FillArray");
            int[] a = arr.FillArray(10);
            Print(a);
            Console.ReadLine();

            Console.WriteLine("Демонстрирую работу метода Multi");
            a = arr.Multi(a, 2);
            Print(a);
            Console.ReadLine();

            Console.WriteLine("Демонстрирую работу метода Inverse");
            a = arr.Inverse(a);
            Print(a);
            Console.ReadLine();

            MyArray arrtxt = new MyArray("1.txt");
            Console.WriteLine(arrtxt.ConvertToString());
            Console.ReadLine();

            int[] b = arrtxt.FillArray(10);
            b = arrtxt.FillFromFile(b, "1.txt");
            Print(b);
            Console.ReadLine();

            arrtxt.WriteInFile(b, "2.txt");
            Console.ReadLine();
        }
    }
}
