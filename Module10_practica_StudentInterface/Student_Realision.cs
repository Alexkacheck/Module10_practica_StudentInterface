using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10_practica_StudentInterface
{
     class Student : Studentici
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public int[] Grades { get; set; }

        public string GetName() => Name;
        public string GetFullName() => FullName;

        public double GetAvgGrade()
        {
            if (Grades == null || Grades.Length == 0) return 0.0;

            return Grades.Average();
        }
    }
}
