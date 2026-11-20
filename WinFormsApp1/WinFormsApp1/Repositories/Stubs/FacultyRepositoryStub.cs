using System.Collections.Generic;
using System.Linq;
using WinFormsApp1.Models;
using WinFormsApp1.Repositories.Interfaces;

namespace WinFormsApp1.Repositories.Stubs
{
    public class FacultyRepositoryStub : IFacultyRepository
    {
        private readonly List<Faculty> _faculties = new List<Faculty>();
        private int _currentId = 1;

        public IEnumerable<Faculty> GetAll() => _faculties;

        public Faculty GetById(int id) => _faculties.FirstOrDefault(f => f.Id == id)!;

        public void Add(Faculty faculty)
        {
            var newFaculty = Faculty.Create(_currentId++, faculty.Name);
            _faculties.Add(newFaculty);
        }

        public void Update(Faculty faculty)
        {
            var existing = GetById(faculty.Id);
            if (existing != null)
            {
                _faculties.Remove(existing);
                _faculties.Add(faculty);
            }
        }

        public void Delete(int id)
        {
            var existing = GetById(id);
            if (existing != null) _faculties.Remove(existing);
        }
    }
}