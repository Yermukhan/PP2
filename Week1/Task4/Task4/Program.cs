using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // Размер массива
            string[,] a = new string[n, n]; //  Выделяем область памяти для двумерного массива
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j || i > j) a[i, j] = "[*]";// Если это условие выполняется, мы присваиваем массиву этот «[*]»
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j]); // Вывод двумерного массива
                }
                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}
