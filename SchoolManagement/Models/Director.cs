using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace SchoolManagement.Models
{
    public class Director : User
    {
        public Profession Profession = Profession.Director;

        public override string  ToString() => JsonSerializer.Serialize<Director>(this);
    }
}
