using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//*Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей.
// Написать программу, демонстрирующую все разработанные элементы класса.
//* Добавить свойства типа int для доступа к числителю и знаменателю;
//* Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
//** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
//*** Добавить упрощение дробей.

namespace SimpleLibrary
{
    /// <summary>
    /// Класс обыкновенных дробей. Предоставляет константы и статические методы для общих математических функций с этими дробями.
    /// </summary>
    public class Fraction
    {
        private int Denominator;
        public int denominator
        {
            get
            {
                return Denominator;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Знаменатель не может быть меньше или равен 0");
                }
                Denominator = value;
            }
        }
        public int numerator { get; set; }
        public int sign { get; }
        /// <summary>
        /// Cвойство для получения десятичной дроби числа (экземпляра класса Fraction)
        /// </summary>
        public double Decimal
        {
            get
            {
                return Convert.ToDouble(numerator) / Convert.ToDouble(denominator);
            }
        }

        public Fraction()
        {
            numerator = 1;
            denominator = 1;
        }
        /// <summary>
        /// Инициализирует новый экземпляр класса Fraction с числителем x и знаменателем 1
        /// </summary>
        /// <param name="x">Числитель</param>
        public Fraction(int x)
        {
            numerator = x;
            denominator = 1;
            if (numerator * denominator < 0)
            {
                this.sign = -1;
            }
            else
            {
                this.sign = 1;
            }
        }
        /// <summary>
        /// Инициализирует новый экземпляр класса Fraction с числителем a и знаменателем b
        /// </summary>
        /// <param name="a">Числитель</param>
        /// <param name="b">Знаменатель</param>
        public Fraction(int a, int b)
        {
            numerator = a;
            denominator = b;
            if (numerator * denominator < 0)
            {
                this.sign = -1;
            }
            else
            {
                this.sign = 1;
            }
        }
        /// <summary>
        /// Возвращает сумму двух простых дробей
        /// </summary>
        /// <param name="x">Первая дробь</param>
        /// <param name="y">Вторая дробь</param>
        /// <returns></returns>
        static public Fraction Sum(Fraction x, Fraction y)
        {
            Fraction a = new Fraction();

            if (x.denominator == y.denominator)
            {
                a.numerator = x.numerator + y.numerator;
                a.denominator = x.denominator;
            }
            else
            {
                a.denominator = getLeastCommonMultiple(x.denominator, y.denominator);
                a.numerator = (x.numerator * (a.denominator / x.denominator)) +
                    (y.numerator * (a.denominator / y.denominator));
            }
            return a;
        }
        /// <summary>
        /// Возвращает разность двух простых дробей
        /// </summary>
        /// <param name="x">Первая дробь</param>
        /// <param name="y">Вторая дробь</param>
        /// <returns></returns>
        static public Fraction Minus(Fraction x, Fraction y)
        {
            Fraction a = new Fraction();

            if (x.denominator == y.denominator)
            {
                a.numerator = x.numerator - y.numerator;
                a.denominator = x.denominator;
            }
            else
            {
                a.denominator = getLeastCommonMultiple(x.denominator, y.denominator);
                a.numerator = (x.numerator * (a.denominator / x.denominator)) -
                    (y.numerator * (a.denominator / y.denominator));
            }
            return a;
        }
        /// <summary>
        /// Возвращает результат произведения двух простых дробей
        /// </summary>
        /// <param name="x">Первая дробь</param>
        /// <param name="y">Вторая дробь</param>
        /// <returns></returns>
        static public Fraction Multi(Fraction x, Fraction y)
        {
            Fraction a = new Fraction();

            a.numerator = x.numerator * y.numerator;
            a.denominator = x.denominator * y.denominator;
            return a.Reduce();
        }
        /// <summary>
        /// Возвращает результат деления двух простых дробей
        /// </summary>
        /// <param name="x">Первая дробь</param>
        /// <param name="y">Вторая дробь</param>
        /// <returns></returns>
        static public Fraction Div(Fraction x, Fraction y)
        {
            Fraction a = new Fraction();

            a.numerator = x.numerator * y.denominator;
            a.denominator = x.denominator * y.numerator;
            return a.Reduce();
        }
        /// <summary>
        /// Возвращает наибольший общий делитель (Алгоритм Евклида)
        /// </summary>
        /// <param name="a">Первый знаменатель</param>
        /// <param name="b">Второй знаменатель</param>
        /// <returns></returns>
        private static int getGreatestCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                int temp = Math.Abs(b);
                b = Math.Abs(a) % b;
                a = temp;
            }
            return a;
        }
        /// <summary>
        /// Возвращает наименьшее общее кратное (приведение к наименьшему общему знаменателю)
        /// </summary>
        /// <param name="a">Первый знаменатель</param>
        /// <param name="b">Второй знаменатель</param>
        /// <returns></returns>
        private static int getLeastCommonMultiple(int a, int b)
        {
            // Деление здесь -- целочисленное, что не искажает результат, так как
            // числитель и знаменатель делятся на свои делители,
            // т.е. при делении не будет остатка
            return a * b / getGreatestCommonDivisor(a, b);
        }
        /// <summary>
        /// Возвращает сокращенную дробь
        /// </summary>
        /// <returns></returns>
        public Fraction Reduce()
        {
            Fraction result = this;
            int greatestCommonDivisor = getGreatestCommonDivisor(this.numerator, this.denominator);
            result.numerator /= greatestCommonDivisor;
            result.denominator /= greatestCommonDivisor;
            return result;
        }
        /// <summary>
        /// Возвращает стороковое представление дроби (экземпляра класса Fraction)
        /// </summary>
        /// <returns></returns>
        public string Print()
        {
            if (this.numerator == 0)
            {
                return "0";
            }
            string result = "";
            if (this.numerator == this.denominator)
            {
                return result + "1";
            }
            if (this.denominator == 1)
            {
                return result + this.numerator;
            }
            return result + this.numerator + "/" + this.denominator;
        }
    }
}
