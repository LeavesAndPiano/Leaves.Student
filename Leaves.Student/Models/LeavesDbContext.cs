
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//
using Microsoft.EntityFrameworkCore;
using Leaves.Student.Migrations.SeedDate;
namespace Leaves.Student.Models
{
    public class LeavesDbContext:DbContext
    {
        public LeavesDbContext(DbContextOptions<LeavesDbContext> options):base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Seed();
            modelBuilder.SeedStudent();
        }
    }
}
