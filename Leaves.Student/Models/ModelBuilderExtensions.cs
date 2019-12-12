
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//
using Microsoft.EntityFrameworkCore;
namespace Leaves.Student.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 1,Name="李贝",ClassName= ClassNameEnum.FirstGrade , Email="123@126.com"
                },
                new Student {Id=2,Name="青帝",ClassName= ClassNameEnum.GradeThree,Email="qiqiyi@qq.com"}
                );
        }
    }
}
