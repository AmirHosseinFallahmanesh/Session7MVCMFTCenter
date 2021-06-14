using Demo.Domain.Contract;
using Demo.Domain.Entittes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo.Infrastructure.DAL
{
    public class StudentRepository : IStudentRepositroy
    {
        SchoolContext context;
        public StudentRepository()
        {
            context = new SchoolContext();
        }
        public int AddStudent(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
            return student.StudentId;
        }

        public Student GetStudent(int id)
        {
            return context.Students.Find(id);
        }

        public List<Student> GetStudents()
        {
            return context.Students.ToList();
        }

        public Student UpdateStudent(Student student)
        {
            context.Students.Update(student);
            context.SaveChanges();
            return student;
        }
    }
}
