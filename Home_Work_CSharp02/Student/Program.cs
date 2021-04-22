using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Придумать класс, описывающий студента. Преду-
    смотреть в нем следующие моменты: фамилия, имя,
    отчество, группа, возраст, массив (зубчатый) оценок по
    программированию, администрированию и дизайну.
    А также добавить методы по работе с перечисленными
    данными: возможность установки/получения оцен-
    ки, получение среднего балла по заданному предмету,
    распечатка данных о студенте.
*/

namespace Student
{
    enum Disciplines                                // Предметы
    {
        Programming,                                // Программирование
        Administration,                             // Администрирование
        Design                                      // Дизайн
    }
    class Student
    {
        public string name { get; set; }            // Имя студента
        public string middle_name { get; set; }     // Отчество студента
        public string surname { get; set; }         // Фамилия студента
        public string group { get; set; }           // Группа
        public int age { get; set; }                // Возраст студента
        public decimal[][] estimates { get; set; } = new decimal[3][]; // Массив оценок
        // Установка оценки по предмету
        public void AddEstimates(Disciplines ds, decimal estimate)
        {
            // Если строка пустая
            if (estimates[(int)ds] == null)
            {
                estimates[(int)ds] = new decimal[1];
            }
            // Если уже существует, расширяем
            else
            {
                Array.Resize<decimal>(ref estimates[(int)ds], estimates[(int)ds].Length + 1);
            }
            // Присваиваем
            estimates[(int)ds][estimates[(int)ds].Length - 1] = estimate;
        }
        // Средний балл
        public decimal EstimAverage(Disciplines ds)
        {
            return estimates[(int)ds].Average();
        }
        // Показать студента(вывести информацию о студенте в консоль)
        public void Show()
        {
            Console.WriteLine($"ФИО: {name} {middle_name} {surname}");
            Console.WriteLine($"Группа: {group}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Оценки: ");
            // Берем данные из перечисления по порядку
            foreach (int ds in Enum.GetValues(typeof(Disciplines)))
            {
                // Пероеводим на человеческий язык
                string disc = string.Empty;
                if(ds == 0)
                {
                    disc = "Программирование";
                }
                else if(ds == 1)
                {
                    disc = "Администрирование";
                }
                else if(ds == 2)
                {
                    disc = "Дизайн";
                }
                Console.WriteLine(disc);
                if(estimates[ds] != null)
                {
                    foreach (decimal estimate in estimates[ds])
                    {
                        Console.Write($"{estimate} ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Программирование, средний балл: {EstimAverage(Disciplines.Programming)}");
            Console.WriteLine($"Администрирование, средний балл: {EstimAverage(Disciplines.Administration)}");
            Console.WriteLine($"Дизайн, средний балл: {EstimAverage(Disciplines.Design)}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student_1 = new Student();
            student_1.name = "Тимофей";
            student_1.middle_name = "Аркадиевич";
            student_1.surname = "Ёлкин";
            student_1.group = "СПУ21";
            student_1.age = 39;
            student_1.AddEstimates(Disciplines.Programming, 12);
            student_1.AddEstimates(Disciplines.Programming, 11);
            student_1.AddEstimates(Disciplines.Programming, 12);
            student_1.AddEstimates(Disciplines.Programming, 10);
            student_1.AddEstimates(Disciplines.Programming, 8);
            student_1.AddEstimates(Disciplines.Administration, 10);
            student_1.AddEstimates(Disciplines.Administration, 11);
            student_1.AddEstimates(Disciplines.Administration, 11);
            student_1.AddEstimates(Disciplines.Administration, 9);
            student_1.AddEstimates(Disciplines.Administration, 7);
            student_1.AddEstimates(Disciplines.Design, 7);
            student_1.AddEstimates(Disciplines.Design, 6);
            student_1.AddEstimates(Disciplines.Design, 9);
            student_1.AddEstimates(Disciplines.Design, 8);
            student_1.AddEstimates(Disciplines.Design, 10);
            student_1.Show();
        }
    }
}