using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace SchoolManagement.Models
{
    public class Student
    {
        public string StudentId { get; set; }

        public string Name { get; set; }

        public string SurName { get; set; }
        
        public Classe SteudentClass { get; set; }

        public string ClasseId { get; set; }

        public string Age { get; set; }

        public string gender { get; set; }

        public string DateOfBirth { get; set; }

        public string ResponsableLegal { get; set; }

        public string Profession { get; set; }

        public string Adresse { get; set; }

        public string Ville { get; set; }

        public string Telephone { get; set; }

        public string Email { get; set; }

        public string AcademicYear { get; set; }


        public override string ToString() => JsonSerializer.Serialize<Student>(this);
    }
}
