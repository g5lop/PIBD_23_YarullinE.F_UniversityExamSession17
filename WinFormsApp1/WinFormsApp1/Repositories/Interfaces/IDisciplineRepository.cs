using System.Collections.Generic;
using WinFormsApp1.Models;

namespace WinFormsApp1.Repositories.Interfaces
{
    public interface IDisciplineRepository
    {
        IEnumerable<Discipline> GetAll();
        void Add(Discipline discipline);
        void Update(Discipline discipline);
        void Delete(int id);
    }
}