using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica090921
{
    class Student
    {
        public int idStudent { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public int age { get; set; }
        public string nacionalidad { get; set; }

        public static List<Student> GetStudents()
        {
            List<Student> Students = new List<Student>
            {
            new Student {idStudent=1001, firstName = "Nohely", lastName = "Robles", age = 20, nacionalidad = "Salvadoreña"},
            new Student {idStudent=1002, firstName = "Jose", lastName = "Gamez", age = 19, nacionalidad = "Hondureño"},
            new Student {idStudent=1003, firstName = "Esmeralda", lastName = "Yanez", age = 17, nacionalidad = "Francesa"},
            new Student {idStudent=1004, firstName = "Deysi", lastName = "Fuentes", age = 5, nacionalidad = "Mexicana"},
            new Student {idStudent=1005, firstName = "Daylin", lastName = "Medina", age = 24, nacionalidad = "Chilena"},
            };

            return Students;
        }

    }
}
    

