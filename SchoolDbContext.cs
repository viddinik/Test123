using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NTierArchitecture.Entities.Models;
using System;

namespace DataAccessKatmaný.Context
{
    public class SchoolDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public SchoolDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Attendance> Attendances { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _configuration.GetConnectionString("MertDb");
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Veritabaný iliþkileri
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
