using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace SchoolManagement.Models
{
    public class Teacher : User
    {

        public Classe ResponsibleClasse { get; set; }

        public string ClasseId { get; set; }

        public Profession Profession = Profession.Teacher;

        public override string ToString()
        {
            return JsonSerializer.Serialize<Teacher>(this);
        }
    }
}
