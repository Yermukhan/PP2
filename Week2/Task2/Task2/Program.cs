using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        //Список для хранения данных из «input.txt»
        public static List<int> list = new List<int>();

        //Метод, чтобы проверить, является ли число праймом  или нет
        public static bool Prime(int k)
        {
            if (k == 1) return false; //1 не является праймом => False

            //Цикл от 2 до квадратного корня числа, которое будет проверяться
            for (int j = 2; j <= Math.Sqrt(k); j++)
            {   // если это число делится без остатка на любое число от 2 до квадрата от этого числа
                // тогда это не простое число
                if (k % j == 0) return false;
            }

            //В противном случае это prime
            return true;
        }

        //Метод для чтения из файла
        public static void Read()
        {
            //Использование StreamReader для чтения из «input.txt»
            StreamReader sr = new StreamReader(@"C:\PP2\Week2\Task2\input.txt");

            //Создание массива строк, в котором хранится разделенная строка, взятая из «input.txt»
            string[] str = sr.ReadLine().Split();

            for (int i = 0; i < str.Length; i++)
            {
                //каждый элемент из массива строк добавляется в список (динамический массив)
                list.Add(int.Parse(str[i]));
            }
            sr.Close();
        }

        //Способ записи в файл
        public static void Write()
        {
            //Использование StreamWriter для записи в «output.txt»
            StreamWriter sw = File.AppendText(@"C:\PP2\Week2\Task2\output.txt");

            //Цикл для бега по списку
            foreach (int k in list)
            {
                if (Prime(k)) sw.Write(k + " "); //если элемент prime, то запишим его в файл «output.txt»
            }

            sw.Close();
        }

        static void Main(string[] args)
        {
            Read(); // Вызываем метод Read;
            Write(); // Вызываем метод Write;


            Console.ReadKey();

        }

    }
}