using Microsoft.EntityFrameworkCore;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessKatmanı.Context
{
    public class SchoolDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Attendance> Attendances { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("YourConnectionStringHere");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Veritabanı ilişkileri
            modelBuilder.Entity<Student>()
                .HasOne<Class>()
                .WithMany()
                .HasForeignKey(s => s.ClassId);

            modelBuilder.Entity<Attendance>()
                .HasOne<Student>()
                .WithMany()
                .HasForeignKey(a => a.StudentId);

            modelBuilder.Entity<Attendance>()
                .HasOne<Course>()
                .WithMany()
                .HasForeignKey(a => a.CourseId);
        }
    }

}
