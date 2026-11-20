using System.Collections.Generic;
using WinFormsApp1.Models;

namespace WinFormsApp1.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
        void Add(Student student);
    }
}