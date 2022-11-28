using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp12
{
    static class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int> { -12, 0, -4, 0, 0, 0, 5, -12, 0, -5, 0, 0, 4 }; //дана последовательность

            int nonZeroCount = nums.Where(num => num != 0).Count(); //переменная целого типа

            Console.WriteLine($"Количество ненулевых чисел равно {nonZeroCount}");  //программа считает 

            Console.ReadKey(); //вывод на консоль
        }
    }
}