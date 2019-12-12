
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//
using Microsoft.EntityFrameworkCore;
namespace Leaves.Student.Migrations.SeedDate
{
    public static class StudentSeedDate
    {
        public static void SeedStudent(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Leaves.Student.Models.Student>().HasData(
                new Leaves.Student.Models.Student
                {
                    Id = 1,
                    Name = "李贝",
                    ClassName = Leaves.Student.Models.ClassNameEnum.FirstGrade,
                    Email = "123@126.com"
                },
                new Leaves.Student.Models.Student { Id = 2, Name = "青帝", ClassName = Leaves.Student.Models.ClassNameEnum.GradeThree, Email = "qiqiyi@qq.com" }
                );
        }
    }
}
