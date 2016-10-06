using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LaboratoireData.Models;

namespace LaboratoireData
{
    public class LaboratoireContext : DbContext
    {
        public DbSet<Analyse> Analyses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source=(LocalDb)\v11.0;Initial Catalog=LaboratoireDB;Integrated Security=True;MultipleActiveResultSets=true"; // providerName = "System.Data.SqlClient";

            optionsBuilder.UseSqlServer(connectionString);

            base.OnConfiguring(optionsBuilder);
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //   modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        //   modelBuilder.Entity<Course>()
        //       .HasMany(c => c.Instructors).WithMany(i => i.Courses)
        //       .Map(t => t.MapLeftKey("CourseID")
        //           .MapRightKey("PersonID")
        //           .ToTable("CourseInstructor"));
        //}

    }
}
