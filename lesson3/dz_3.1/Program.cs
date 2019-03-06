using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Синицын
//1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;

namespace dz_3._1
{
    struct Complex
    {
        public double im;
        public double re;

        /// <summary>
        /// Метод сложения комплексных чисел
        /// </summary>
        /// <param name="x">Второе слагаемое</param>
        /// <returns>Сумма</returns>
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }

        /// <summary>
        /// Метод вычитания комплексных чисел
        /// </summary>
        /// <param name="x">Вычитаемое</param>
        /// <returns>Разность</returns>
        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - (x.im);
            y.re = re - (x.re);
            return y;
        }

        /// <summary>
        /// Метод произведения комплексных чисел
        /// </summary>
        /// <param name="x">Второй множитель</param>
        /// <returns>Результат произведения</returns>
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }

        /// <summary>
        /// Метод вывода результата вычислений для комплексных чисел
        /// </summary>
        /// <returns></returns>
        public string Print(double b)
        {
            string x = "";

            if (b < 0)
            {
                x = re + "" + im + "i";
            }
            else
            {
                x = re + "+" + im + "i";
            }
            return x;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Демонстрирую работу структуры Complex
");

            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;

            Complex complex2;
            complex2.re = -4;
            complex2.im = -4;

            double b;
            Complex resultsum = complex1.Plus(complex2);
            b = resultsum.im;
            Console.WriteLine("Сумма комплексных чисел = " + resultsum.Print(b));
            Complex resultmulti = complex1.Multi(complex2);
            b = resultmulti.im;
            Console.WriteLine("Произведение комплексных чисел = " + resultmulti.Print(b));
            Complex resultminus = complex1.Minus(complex2);
            b = resultminus.im;
            Console.WriteLine("Разность комплексных чисел = " + resultminus.Print(b));

            //Добавил в методе Print доп проверку при выводе числа.
            //Для улучшенного вывода мнимой части комплексного числа(в том случае если она отрицательная, чтобы не было лишнего знака +)

            Console.ReadLine();
        }
    }
}
