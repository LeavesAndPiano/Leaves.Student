using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leaves.Student.Models
{
    public class SqlStudentRepository : IStudentRepository
    {
        private readonly LeavesDbContext _context;

        public SqlStudentRepository(LeavesDbContext context)
        {
            _context = context;
        } 

        public Student Add(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;

        }

        public Student Delete(int id)
        {
            Student student = _context.Students.Find(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
            return student;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _context.Students;
        }

        public Student GetStudent(int id)
        {
            return _context.Students.Find(id);
        }

        public Student Update(Student updateStudent)
        {
            var student = _context.Students.Attach(updateStudent);
            student.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return updateStudent; 
        }
    }
}
