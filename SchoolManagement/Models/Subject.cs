using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace SchoolManagement.Models
{
    public class Subject
    {
        public string SubjectId { get; set; }

        public string SubjectName { get; set; }

        public string Coefficient { get; set; }

        public int Mark { get; set; } 

        public string SchoolYear { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Subject>(this);
       
    }
}
