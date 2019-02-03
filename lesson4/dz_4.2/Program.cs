using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    class MyArray
    {
        int[] a;

        public int this[int i]
        {
            get { return a[i]; }
            set { a[i] = value; }
        }
        /// <summary>
        /// Создание массива и заполнение его одним значением el
        /// </summary>
        /// <param name="n">Размер массива</param>
        /// <param name="el">Значение элемента</param>
        public MyArray(int n, int el)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = el;
        }
        /// <summary>
        /// Создание массива и заполнение его случайными числами от min до max
        /// </summary>
        /// <param name="n">Размер массива</param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        //public MyArray(int n, int min, int max)
        //{
        //    a = new int[n];
        //    Random rnd = new Random();
        //    for (int i = 0; i < n; i++)
        //        a[i] = rnd.Next(min, max);
        //}
        /// <summary>
        /// Конструктор, создающий массив размерности n и заполняющий массив числами от начального значения с заданным шагом
        /// </summary>
        /// <param name="n">Размер массива</param>
        /// <param name="primary">Начальное значение</param>
        /// <param name="step">Заданный шаг</param>
        public MyArray(int n, int primary, int step)
        {
            a = new int[n];
            a[0] = primary;
            for (int i = 1; i < n; i++)
            {
                a[i] = a[i - 1] + step;
            }
        }
        /// <summary>
        /// Cвойство которое возвращает сумму элементов массива
        /// </summary>
        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    sum = a[i] + sum;
                }
                return sum;
            }
        }
        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }
        /// <summary>
        /// Cвойство возвращающее количество максимальных элементов массива
        /// </summary>
        public int MaxCount
        {
            get
            {
                int max = a[0];
                int count = 1;
                for (int i = 1; i < a.Length; i++)
                {
                    if (a[i] > max)
                    {
                        max = a[i];
                    }
                    else if(a[i]==max)
                    {
                        count++;
                    }
                }
                return count;
            }
        }
        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }
        public int CountPositiv
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > 0) count++;
                return count;
            }
        }
        /// <summary>
        /// Возвращает массив в виде строки
        /// </summary>
        /// <returns></returns>
        public string ConvertToString()
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }
        //я не понял как сделать метод в классе чтобы он не ругался на массив, так что сделал это. Я так понимаю это свойство)
        //если честно я не до конца понимаю как оно работает)
        public int[] Inverse
        {
            get
            {
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = -a[i];
                }
                return a;
            }
        }
    }
        class Program
    {
        /// <summary>
        /// Метод меняющий знаки у всех элементов массива
        /// </summary>
        /// <param name="a">Массив к которому нужно применить данный метод</param>
        static public void Inverse(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = -a[i];
            }
        }
        /// <summary>
        /// Метод умножающий каждый элемент массива на множитель multi
        /// </summary>
        /// <param name="a">Массив к которому нужно применить данный метод</param>
        /// <param name="multi">Множитель</param>
        static public void Multi(int[] a, int multi)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = a[i]*multi;
            }
        }
        /// <summary>
        /// Метод для вывода всех элементов массива на экран
        /// </summary>
        /// <param name="a">Массив к которому нужно применить данный метод</param>
        static public void Print(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Создал массив класса MyArray");
            MyArray arr = new MyArray(20, 0, 1);
            Console.WriteLine(arr.ConvertToString());
            Console.ReadLine();

            Console.WriteLine("Демонстрирую работу свойства Sum");
            Console.WriteLine(arr.Sum);
            Console.ReadLine();

            Console.WriteLine("Демонстрирую работу метода Inverse на примере массива класса MyArray");
            int[] x = arr.Inverse;
            Console.WriteLine(arr.ConvertToString());
            Console.ReadLine();

            Console.WriteLine("Демонстрирую работу метода Inverse на примере обычного массива");
            int[] arr1 = { -5, 6, -1, 5, -8 };
            Print(arr1);
            Inverse(arr1);
            Console.WriteLine();
            Print(arr1);
            Console.ReadLine();

            Console.WriteLine("Демонстрирую работу метода Multi на примере обычного массива");
            Multi(arr1, 2);
            Print(arr1);
            Console.ReadLine();

            Console.WriteLine("Демонстрирую работу свойства MaxCount");
            MyArray arr2 = new MyArray(5, 1, 2);
            arr2[0] = 1;
            arr2[1] = 1;
            arr2[2] = 2;
            arr2[3] = 2;
            arr2[4] = 1;
            Console.WriteLine(arr2.ConvertToString());
            Console.WriteLine(arr2.MaxCount);
            Console.ReadLine();
        }
    }
}
