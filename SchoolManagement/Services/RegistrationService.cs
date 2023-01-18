using Microsoft.AspNetCore.Hosting;
using SchoolManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement.Services
{
    public class RegistrationService
    {

        private readonly DataContext _context;

        public RegistrationService(DataContext dataContext)
        {
            _context = dataContext;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        public string StudentRegister(Student student)
        {
            
            var _student = new Student
            {
                Name = student.Name,
                StudentId = student.StudentId,
                DateOfBirth = student.DateOfBirth,
                SurName = student.SurName,
                ClasseId = student.ClasseId,
                Age = student.Age,
                gender=student.gender,
                ResponsableLegal=student.ResponsableLegal,
                Profession = student.Profession,
                Adresse = student.Adresse,
                Ville = student.Ville,
                Telephone = student.Telephone,
                Email = student.Email,
                AcademicYear = student.AcademicYear

            };

            _context.Add(_student);
            _context.SaveChanges();
            return _student.StudentId;
        }

    }
}
