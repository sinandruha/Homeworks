using SimpleLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Синицын
//е) ***Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary< int,int>)


namespace dz_4._3.e
{
    class Program
    {
        static void Main(string[] args)
        {
            var y = new MyArray(10, 1, 4);

            int[] mas = new int[10];

            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = y[i];
                Console.Write(mas[i] + " ");
            }

            Console.ReadLine();

            var freq = new Dictionary<int, int>();

            for (int i = 0; i < mas.Length; i++)
            {
                int a = mas[i];
                int count = 0;
                for (int j = 0; j < mas.Length; j++)
                {
                    if (a == mas[j])
                    {
                        count++;
                    }

                }
                freq[a] = count;
            }

            foreach (KeyValuePair<int, int> keyValue in freq)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }

            Console.ReadKey();
        }
    }
}
