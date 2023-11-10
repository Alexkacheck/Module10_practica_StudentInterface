using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10_practica_StudentInterface
{
    class Program
    {
        static void Main()
        {
            Student student = new Student
            {
                Name = "Вова",
                FullName = "Вова Щербаков Алексеевич",
                Grades = new int[] { 3, 4, 2, 5, 5 }
            };

            Console.WriteLine($"Имя: {student.GetName()}");
            Console.WriteLine($"ФИ0): {student.GetFullName()}");
            Console.WriteLine($"Средняя оценка: {student.GetAvgGrade()}");

            Console.ReadKey();
        }
    }
}
