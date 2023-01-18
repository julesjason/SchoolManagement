using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace SchoolManagement.Models
{
    public enum Profession
    {
        Accompter,
        Director,
        Teacher

    }
    public class User
    {
        public string UserId { get; set; }

        public string UserName { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Age { get; set; }
         
        public string gender { get; set; }

        public string DateOfBirth { get; set; }

        //public Profession Profession { get; set; }

        public string Adresse { get; set; }

        public string Ville { get; set; }

        public string Telephone { get; set; }

        public string Email { get; set; }

        public string AcademicYear { get; set; }

        // User() {  }

        public override string ToString() => JsonSerializer.Serialize<User>(this);
    }
}
