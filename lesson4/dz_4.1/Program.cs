﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Синицын
//1. Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
//Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3.
//В данной задаче под парой подразумевается два подряд идущих элемента массива.
//Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.

namespace lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Эта программа позволяет найти и вывести количество пар элементов массива, 
в которых хотя бы одно число делится на 3.
Под парой подразумевается два подряд идущих элемента массива.
");

            int n = 20;//предполагаемая длинна массива
            int[] arr = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(-10000, 10001);
                Console.WriteLine(arr[i]);
            }

            int count = 0;
            ///цикл реализующий линейный поиск по массиву, и проверку каждой пары массива на возможность деления на 3.
            for (int i = 0; i < n - 1; i++)
            {
                int x = arr[i];
                if (arr[i] % 3 == 0)
                {
                    count++;
                }
                else if (arr[i + 1] % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("В этом массиве " + count + " пар элементов соответствуют условию");
            Console.ReadLine();
        }
    }
}