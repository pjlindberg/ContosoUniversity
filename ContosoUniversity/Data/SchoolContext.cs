﻿using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }
        // You could have omitted the DbSet<Enrollment> and DbSet<Course> statements and it would work the same. 
        // The Entity Framework would include them implicitly because the Student entity references the 
        // Enrollment entity and the Enrollment entity references the Course entity.
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        // When the database is created, EF creates tables that have names the same as the DbSet property names.
        // Property names for collections are typically plural (Students rather than Student), but developers 
        // disagree about whether table names should be pluralized or not.For these tutorials you'll override 
        // the default behavior by specifying singular table names in the DbContext. To do that, add the following 
        // highlighted code after the last DbSet property.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}