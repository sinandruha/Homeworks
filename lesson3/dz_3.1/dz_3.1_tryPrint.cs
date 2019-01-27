using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Синицын
//1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;
//б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса;

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
            double a = y.im;

            return y;
        }
        string x;

        public string Print(double a, double b)
        {
            string x = "";

            if (a >= 0 && b >= 0)
            {
                x = re + "+" + im + "i";
            }
            else
            {
                x = re + im + "i";
            }
            return x;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;

            Complex complex2;
            complex2.re = 4;
            complex2.im = 4;

            double a = complex2.im;
            double b = complex1.im;

            Complex resultsum = complex1.Plus(complex2);
            Console.WriteLine("Сумма комплексных чисел = " + resultsum.Print(a, b));
            Complex resultmulti = complex1.Multi(complex2);
            Console.WriteLine("Произведение комплексных чисел = " + resultmulti.Print(a, b));
            Complex resultminus = complex1.Minus(complex2);
            Console.WriteLine("Разность комплексных чисел = " + resultminus.Print(a, b));

            Console.ReadLine();
        }
    }
}
