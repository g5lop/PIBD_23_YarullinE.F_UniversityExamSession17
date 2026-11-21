using System.Collections.Generic;
using WinFormsApp1.Models;
using WinFormsApp1.Repositories.Interfaces;

namespace WinFormsApp1.Repositories.Stubs
{
    public class StudentRepositoryStub : IStudentRepository
    {
        private readonly List<Student> _students = new List<Student>();
        private int _currentId = 1;

        public IEnumerable<Student> GetAll() => _students;

        public void Add(Student student)
        {
            var newStudent = Student.Create(_currentId++, student.FullName, student.GroupId, student.Status, student.AverageScore);
            _students.Add(newStudent);
        }
    }
}