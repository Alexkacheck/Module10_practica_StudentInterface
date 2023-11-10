using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10_practica_StudentInterface
{
    interface Studentici
    {
        string Name { get; set; }
        string FullName { get; set; }
        int[] Grades { get; set; }

        string GetName();
        string GetFullName();
        double GetAvgGrade();
    }
}
