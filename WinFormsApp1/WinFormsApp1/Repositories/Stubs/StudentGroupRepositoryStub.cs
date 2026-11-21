using System.Collections.Generic;
using System.Linq;
using WinFormsApp1.Models;
using WinFormsApp1.Repositories.Interfaces;

namespace WinFormsApp1.Repositories.Stubs
{
    public class StudentGroupRepositoryStub : IStudentGroupRepository
    {
        private readonly List<StudentGroup> _groups = new List<StudentGroup>();
        private int _currentId = 1;

        public IEnumerable<StudentGroup> GetAll() => _groups;

        public StudentGroup? GetById(int id) => _groups.FirstOrDefault(g => g.Id == id);

        public void Add(StudentGroup group)
        {
            var newGroup = StudentGroup.Create(_currentId++, group.GroupNumber);
            _groups.Add(newGroup);
        }

        public void Update(StudentGroup group)
        {
            var existing = GetById(group.Id);
            if (existing != null)
            {
                _groups.Remove(existing);
                _groups.Add(group);
            }
        }

        public void Delete(int id)
        {
            var existing = GetById(id);
            if (existing != null) _groups.Remove(existing);
        }
    }
}