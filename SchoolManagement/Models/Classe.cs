using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace SchoolManagement.Models
{
    public class Classe
    {
        public string ClasseId { get; set; }

        public string ClasseName { get; set; }

        public ICollection<Subject> Subjects { get; set; }


        public override string ToString() => JsonSerializer.Serialize<Classe>(this);
    }
}
