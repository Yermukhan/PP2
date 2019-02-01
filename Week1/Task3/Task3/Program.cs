using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        // Функция, которая будет извлекать из массива целых чисел еще один массив целых чисел, где каждый элемент повторяется 2 раза
        public static void NewArr(int[] a, int n)
        {
            List<int> list = new List<int>(); // Создание списка (динамического массива), в который будут добавлены дублируемые элементы массива «а»
            for (int i = 0; i < a.Length; i++)
            {
                list.Add(a[i]); // Добавление каждого элемента массива «а» в список два раза (чтобы они дублировались)
                list.Add(a[i]);
            }

            foreach (int k in list)
            {
                Console.Write(k + " "); //Вывод элементов списка
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n]; // Создание массива
            string s = Console.ReadLine(); // Ввод строки
            string[] arr = s.Split(); // Разделение строки на подэлементы и добавление их в массив строк

            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(arr[i]); // Присвоение каждого элемента массива строк обычному массиву «а»
            }

            NewArr(a, n); // Вызов функций, которые будут выводить элементы списка

            Console.ReadKey();
        }
    }
}
