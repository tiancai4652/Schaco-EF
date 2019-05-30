using CodeFirstWithFluentAPI.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstWithFluentAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolContext schoolContext = new SchoolContext();
            schoolContext.Database.Log = (c) => { System.Diagnostics.Debug.WriteLine("0529:" + c); };
            schoolContext.Database.CreateIfNotExists() ;
        }
    }

    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("SC")
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("ZR644Schema");
            modelBuilder.Entity<Student>().ToTable("StudentTable").HasKey<string>(t=>t.Key);
            modelBuilder.Entity<Grade>().ToTable("GradeTable").HasKey<string>(t => t.Key);
            modelBuilder.Entity<Teacher>().ToTable("TeacherTable").HasKey<string>(t => t.Key);
        }
    }
}
