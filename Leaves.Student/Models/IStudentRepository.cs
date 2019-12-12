﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leaves.Student.Models
{
    public interface IStudentRepository
    {
        Student GetStudent(int id); 

        IEnumerable<Student> GetAllStudents();

        Student Add(Student student);

        Student Update(Student updateStudent);

        Student Delete(int id);
    }
}
