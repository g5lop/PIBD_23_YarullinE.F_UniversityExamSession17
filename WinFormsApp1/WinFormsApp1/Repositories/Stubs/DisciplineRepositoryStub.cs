using System.Collections.Generic;
using System.Linq;
using WinFormsApp1.Models;
using WinFormsApp1.Repositories.Interfaces;

namespace WinFormsApp1.Repositories.Stubs
{
    public class DisciplineRepositoryStub : IDisciplineRepository
    {
        private readonly List<Discipline> _disciplines = new List<Discipline>();
        private int _currentId = 1;

        public IEnumerable<Discipline> GetAll() => _disciplines;

        public void Add(Discipline discipline)
        {
            var newDiscipline = Discipline.Create(_currentId++, discipline.Name, discipline.Teacher);
            _disciplines.Add(newDiscipline);
        }

        public void Update(Discipline discipline)
        {
            var existing = _disciplines.FirstOrDefault(d => d.Id == discipline.Id);
            if (existing != null)
            {
                _disciplines.Remove(existing);
                _disciplines.Add(discipline);
            }
        }

        public void Delete(int id)
        {
            var existing = _disciplines.FirstOrDefault(d => d.Id == id);
            if (existing != null) _disciplines.Remove(existing);
        }
    }
}