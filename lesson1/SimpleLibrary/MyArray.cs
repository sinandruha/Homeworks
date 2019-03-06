using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimpleLibrary
{
    public class MyArray
    {
        int[] a;

        public int this[int i]
        {
            get { return a[i]; }
            set { a[i] = value; }
        }
        /// <summary>
        /// Заполнение массива числовыми значениями из текстового файла
        /// </summary>
        /// <param name="filename">Файл со значениями</param>
        public MyArray(string filename)
        {
            if (File.Exists(filename))
            {
                try
                {
                    string[] ss = File.ReadAllLines(filename);
                    a = new int[ss.Length];
                    for (int i = 0; i < ss.Length; i++)
                        a[i] = int.Parse(ss[i]);
                }
                catch
                {
                    Console.WriteLine("Невозможно считать данные из файла, возможно указан неверный тип данных");
                }
            }
            else Console.WriteLine("Error load file");
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
        public MyArray(int n, int min, int max)
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
        }
        /// <summary>
        /// Конструктор, создающий массив размерности n и заполняющий массив числами от начального значения с заданным шагом
        /// </summary>
        /// <param name="n">Размер массива</param>
        /// <param name="primary">Начальное значение</param>
        /// <param name="step">Заданный шаг</param>
        public MyArray(int n, int primary, short step)
        {
            a = new int[n];
            a[0] = primary;
            for (int i = 1; i < n; i++)
            {
                a[i] = a[i - 1] + Convert.ToInt32(step);
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
                    sum += a[i];
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
                    else if (a[i] == max)
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
            try
            {
                string s = "";
                foreach (int v in a)
                    s = s + v + " ";
                return s;
            }
            catch
            {
                string s = "Не удалось преобразовать в строковое значение";
                return s;
            }
        }
        /// <summary>
        /// Метод для заполнения массива длинны a случайными числами от -10000 до 10000
        /// </summary>
        /// <param name="a">Размер массива</param>
        /// <returns></returns>
        public int[] FillArray(int a)
        {
            Random rnd = new Random();
            int[] arr = new int[a];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-10000, 10000);
            }
            return arr;
        }
        /// <summary>
        /// Метод умножающий каждый элемент массива на множитель multi
        /// </summary>
        /// <param name="arr">Массив к которому нужно применить данный метод</param>
        /// <param name="multi">Множитель</param>
        public int[] Multi(int[] arr, int multi)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * multi;
            }
            return arr;
        }
        /// <summary>
        /// Метод меняющий знаки у всех элементов массива
        /// </summary>
        /// <param name="arr">Массив к которому нужно применить данный метод</param>
        /// <returns></returns>
        public int[] Inverse(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = -arr[i];
            }
            return arr;
        }
        /// <summary>
        /// Метод который загружает данные из файла в массив типа int
        /// </summary>
        /// <param name="arr">Массив который заполняется данными из файла</param>
        /// <param name="filename">Файл для считывания данных</param>
        /// <returns></returns>
        public int[] FillFromFile(int[] arr, string filename)
        {
            if (File.Exists(filename))
            {
                try
                {
                    string[] ss = File.ReadAllLines(filename);
                    arr = new int[ss.Length];
                    for (int i = 0; i < ss.Length; i++)
                        arr[i] = int.Parse(ss[i]);

                }
                catch
                {
                    Console.WriteLine("Невозможно считать данные из файла, возможно указан неверный тип данных");
                }
            }
            else Console.WriteLine("Error load file");
            return arr;
        }
        /// <summary>
        /// Метод для записи данных в файл из массива типа int
        /// </summary>
        /// <param name="arr">Массив из которого берутся данные</param>
        /// <param name="filename">Файл для записи</param>
        /// <returns></returns>
        public int[] WriteInFile(int[] arr, string filename)
        {
            StreamWriter sw = new StreamWriter(filename);
            string s = "";
            for (int i = 0; i < arr.Length; i++)
            {
                s += Convert.ToString(arr[i] + "; ");
                sw.WriteLine(s);
            }
            sw.Close();
            return arr;
        }
    }
}
