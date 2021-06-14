using Demo.Domain.Contract;
using Demo.Domain.Entittes;
using Demo.Infrastructure.DAL;
using System;
using System.Collections.Generic;

namespace Demo.Domain.ApplicationService
{
    public class StudentFacade : IStudentFacade
    {
        IStudentRepositroy repositroy;
        public StudentFacade()
        {
            repositroy = new StudentRepository();
        }
        public int AddStudent(Student student)
        {
            return repositroy.AddStudent(student);
        }

        public Student EditStudent(Student student)
        {
            return repositroy.UpdateStudent(student);
        }

        public Student GetStudent(int id)
        {
            return repositroy.GetStudent(id);
        }

        public List<Student> GetStudents()
        {
            return repositroy.GetStudents();
        }
    }

 
}
