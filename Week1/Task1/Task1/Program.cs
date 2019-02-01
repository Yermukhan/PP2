using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // Размер массива
            List<int> list = new List<int>(); // Создание списка (динамический массив), к которому будут добавлены простые числа
            int[] a = new int[n]; // Создание Массива

            string s = Console.ReadLine(); // Ввод строки
            string[] arr = s.Split(); // Разделение элементов строки на подэлементы и добавление каждого подэлемента в массив строк
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(arr[i]); // Ввод элементов массива
            }

            foreach (int k in a)
            {
                
                bool flag = true; // Создание переменно bool для возврата "true",если число простое, и "false" если оно не простое
                




                if (k == 1) flag = false; // flag "false", потому что 1 не простое число
                for (int j = 2; j <= Math.Sqrt(k); j++)
                {
                    if (k % j == 0) flag = false; // если число делится на любое другое число (кроме 1 и самого себя) без остатка, следовательно, оно не является простым

                }

                if (flag == true) list.Add(k); // если элемент массива яаляется простым,добавляем его в список
                
            }
            

            Console.WriteLine(list.Count()); // Выводим размер списка то есть количество простых чисел
            
            foreach (int m in list)
            {
                Console.Write(m + " "); // Вывод элементов списка, то есть простых чисел
            }

            Console.ReadKey();
        }
    }
}
        
    

