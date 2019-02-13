using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        public static string FolderName = @"C:\PP2\Week2\Task4\FileToCopy";
        public static string fileName = "FileToCopy.txt";

        
       // Способ скопировать файл из одного места в другое
        public static void Copy(string source, string dest)
        {
            File.Copy(source, dest, true); //Копирование файла из одного дирикторией в другой
            Delete(source); //Вызываем функцию Delete (), чтобы удалить файл из исходного дириктория
        }

        //Метод для удаления файла из исходного местоположения, когда он уже скопирован в другое местоположение
        public static void Delete(string source)
        {
            File.Delete(source); 
           // Удаление файла из исходного дириктрия
        }

        // Или вместо этих двух методов мы можем использовать функцию File.Move для перемещения файла из одного места в другое.

                               /*public static void Move(string source, string dest)
                                      {
                                         File.Move(source, dest);
                                                                        }*/


        // Метод Main(основной)
        static void Main(string[] args)
        {
            string path = Path.Combine(FolderName, "From");
            string path1 = Path.Combine(FolderName, "To");
            Directory.CreateDirectory(path); //Создание дироктория 1 называемого "path"
            Directory.CreateDirectory(path1); //Создания дириктория 2 называемого "path1"
            path = Path.Combine(path, fileName); //Создание пути к файлу в дириктории 1
            path1 = Path.Combine(path1, fileName); // Создание пути к файлу в дириктории 2

            FileInfo fi = new FileInfo(path); // Получение информации о файле, чтобы проверить, существует файл или нет

            // Если файл не существует, выполняется следующее условие
            if (!fi.Exists)
            {
                
                // Создание файла и запись в него текста
                // используя StreamWriter
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("Be more serious please!!!!!");
                }
            }

            //Если файл уже существует, выполняется следующее условие
            else
            {
                Console.WriteLine("File already exists!");

            }


            Copy(path, path1); //Вызываем функцию Copy (), которая затем вызовет функцию Delete ().

            // Move (path, path1);



            Console.ReadKey();
        }
    }
}