using System.Collections.Generic;
using WinFormsApp1.Models;

namespace WinFormsApp1.Repositories.Interfaces
{
    public interface IFacultyRepository
    {
        IEnumerable<Faculty> GetAll();
        Faculty GetById(int id);
        void Add(Faculty faculty);
        void Update(Faculty faculty);
        void Delete(int id);
    }
}