using Demo.Domain.Entittes;
using System.Collections.Generic;

namespace Demo.Domain.Contract
{
    public interface IStudentRepositroy
    {
        List<Student> GetStudents();
        int AddStudent(Student student);
        Student GetStudent(int id);

        Student UpdateStudent(Student student);
    }
}
