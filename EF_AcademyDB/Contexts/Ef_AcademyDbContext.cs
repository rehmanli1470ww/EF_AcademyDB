using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_AcademyDB.Entitiy;
using Microsoft.EntityFrameworkCore;

namespace EF_AcademyDB.Contexts
{
    public class Ef_AcademyDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=RUBAIL\\SQLEXPRESS;Initial Catalog=Ef_AcademyDbContext;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Curator> Curators { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Facultie> Faculties { get; set;}
        public DbSet<Group> Groups { get; set; } 
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }    
        public DbSet<Teacher> Teachers { get; set; }

    }
}
