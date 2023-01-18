using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace SchoolManagement.Models
{
    public class ReportCard
    {
        public string ReportCardId { get; set; }

        public Classe Classe { get; set; }

        public string ClasseId { get; set; }

        public Student Student { get; set; }

        public string StudentId { get; set; }


        public override string ToString() => JsonSerializer.Serialize<ReportCard>(this);
    }
}
