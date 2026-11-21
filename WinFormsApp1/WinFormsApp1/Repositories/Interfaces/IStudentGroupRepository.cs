using System.Collections.Generic;
using WinFormsApp1.Models;

namespace WinFormsApp1.Repositories.Interfaces
{
    public interface IStudentGroupRepository
    {
        IEnumerable<StudentGroup> GetAll();
        StudentGroup? GetById(int id); 
        void Add(StudentGroup group);
        void Update(StudentGroup group);
        void Delete(int id);
    }
}