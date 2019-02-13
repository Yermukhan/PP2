using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Task3
{
    class Program
    {
        //Метод для print spaces, когда каталоги выводятся рекурсивно
        static void PrintSpaces(int level)
        {
            for (int i = 0; i < level; i++)
                Console.Write("    "); 
            // print spaces по мере повышения уровня
        }

        
        // Метод для получения директориев и файлов
        static void GetDir(DirectoryInfo directory, int level)
        {
            // используя класс FileInfo и команду GetFiles, чтобы получить все файлы из текущего каталога
            // и сохраняем их в массиве "файлы"
            FileInfo[] files = directory.GetFiles();
            //используя класс DirectoryInfo и команду GetDirectories, чтобы получить все дироктори внутри текущего дироктория
            // и сохраняем их в массиве "Directories"
            DirectoryInfo[] directories = directory.GetDirectories();

            //Цикл для запуска всех файлов в «Files»
            foreach (FileInfo file in files)
            {
                //Когда начинается новый круг цикла, выведим соответствующее количество пробелов
                // сделать  структуру tree
                PrintSpaces(level);
                Console.WriteLine(file.Name);
            }

            //Цикл для запуска всех дироктириев в "directories"
            foreach (DirectoryInfo d in directories)
            {
                
               // Когда начинается новый круг цикла, выведим соответствующее количество пробелов
                // сделаем структуру tree(деревидную)
                PrintSpaces(level);
                Console.WriteLine(d.Name);
                GetDir(d, level + 1);
            }
        }

        //метод  Main
        static void Main(string[] args)
        {
            //Указание пути к папке, которая будет проверяться на наличие дирикторив и файлов
            string path = @"C:\PP2\Week2";
            DirectoryInfo directory = new DirectoryInfo(path);
            //Вывод имени основной папки
            Console.WriteLine(directory.Name);
            GetDir(directory, 1); //Вызываем функцию GetDir (), чтобы получить все дириктории и файлы внутри папки "Week2"
            Console.ReadKey();
        }

    }

}