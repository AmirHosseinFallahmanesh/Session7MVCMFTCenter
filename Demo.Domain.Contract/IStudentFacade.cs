using Demo.Domain.Entittes;
using System;
using System.Collections.Generic;

namespace Demo.Domain.Contract
{
    public interface IStudentFacade
    {
        List<Student> GetStudents();
        int AddStudent(Student student);

        Student GetStudent(int id);

        Student EditStudent(Student student);
    }
}
