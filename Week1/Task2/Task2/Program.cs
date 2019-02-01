using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 
Реализуем класс Студентa. У студента есть имя, идентификатор и год обучения. Предоставить конструктор
с двумя параметрами и создать методы для доступа к имени, идентификатору и увеличить год обучения.*/

namespace Task2
{
    class Student         // Cоздаем класс студента
    {
        public string name; // Создание глобальных переменных, то есть имени, идентификатора и года
        public string id;
        public int year; // переменная "year" не будет отправлена ​​в конструктор, так как конструктор имеет только два параметра
        // Таким образом, год будет просто вычислен после имени и идентификатора, и каждый раз, когда он выводится, его значение будет увеличиваться на 1
        // По умолчанию переменная "year" равна 1. Она будет пересчитана 4 раза, поскольку бакалавриат включает только 4 года обучения

        public Student(string name, string id)// Создание конструктора с двумя парметрами который булет инциализировать объект
        {
            this.name = name;
            this.id = id;
        }

            // Способ 1 для доступа к названию объекта
            public string getName()
        {
            return name;
        }

        
        // Способ 2 для доступа к идентификатору
        public string getID()
        {
            return id;
        }

        // Способ 3, чтобы получить доступ к году и увеличить его на 1
        public int getYear()
        {
            year++;  // year ++ увеличивать год на 1 каждый раз, когда это считается
            return year;
        }

         //Способ доступа к полной информации о студенте

        public string getInfo()
        {
            return ("Name: " + getName() + "\nID: " + getID() + "\nYear: " + getYear());
        }

    }


    class Program
    {
        //Основной метод
        static void Main(string[] args)
        {
            string name = Console.ReadLine(); // Входные данные
            string id = Console.ReadLine();
            Student st = new Student(name, id); //Создание объекта и отправка его конструктору
            // Создание цикла для расчета объекта 4 раза и каждый год для увеличения на 1
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine();
                Console.WriteLine(st.getInfo()); //  Вывод всей информации о студенте
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}



