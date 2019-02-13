using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        public static string s;

        // Метод, чтобы проверить, является ли строка полиндормой или нет
        public static bool Pol(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                //если какая-либо буква в начале не совпадает с соответствующей буквой в конце, то это не полиндром
                if (s[i] != s[s.Length - 1 - i])
                {
                    return false;
                }
            }

            
            // в противном случае это полиндром
            return true;
        }

        // Метод для чтения из файла
        public static void Read()
        {
            // Использование команды StreamReader для чтения из файла с именем «input.txt»
            StreamReader sr = new StreamReader(@"C:\PP2\Week2\Task1\input.txt");
            s = sr.ReadLine();
            sr.Close();
        }

        // Способ записи в файл
        public static void Write()
        {
            //Использование команды StreamWriter для записи в файл с именем «output.txt»
            StreamWriter sw = File.AppendText(@"C:\PP2\Week2\Task1\output.txt");

            //Если строка, полученная из файла «input.txt», является полиндромом, напишим «yes» в файл «output.txt»

            if (Pol(s)) sw.WriteLine("yes");

            //В противном случае напишим «нет» в файл «output.txt»
            else sw.WriteLine("no");

            sw.Close(); // sw.Close () для сохранения введенного текста в «output.txt»
        }

        static void Main(string[] args)
        {
            Read(); //Вызываем метод Read ()
            Write(); //Вызываем метод Write() 

            Console.ReadKey();


        }

    }
}