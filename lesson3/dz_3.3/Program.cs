using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleLibrary;

//Синицын
//*Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей.
// Написать программу, демонстрирующую все разработанные элементы класса.
//* Добавить свойства типа int для доступа к числителю и знаменателю;
//* Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
//** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
//*** Добавить упрощение дробей.

namespace dz_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Fraction(-12, 36);
            var b = new Fraction(2, 5);

            var c = Fraction.Sum(a, b);
            Console.WriteLine(c.Print());

            c = Fraction.Minus(a, b);
            Console.WriteLine(c.Print());

            c = Fraction.Multi(a, b);
            Console.WriteLine(c.Print());

            c = Fraction.Div(a, b);
            Console.WriteLine(c.Print());

            a.Reduce();
            Console.WriteLine(a.Print());
            Console.WriteLine(b.Decimal);

            Console.ReadKey();
        }
    }
}
