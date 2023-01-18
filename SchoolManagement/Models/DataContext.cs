using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement.Models
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {
        }
        protected readonly IConfiguration _Configuration;
        public DataContext(IConfiguration configuration)
        {
            _Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder option)
        {

            option.UseSqlServer(
                _Configuration
                .GetConnectionString
                ("dataAccess"));

        }


        public DbSet<User> Users { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Accounter> Accounters { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Classe> Classes { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<ReportCard> ReportCards { get; set; }
 
    }
}
