using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace SchoolManagement.Models
{
    public class Accounter : User
    {
        //public string AccounterId { get; set; }
        public Profession Profession = Profession.Accompter;

        public override string ToString() => JsonSerializer.Serialize<Accounter>(this);
    }
}
