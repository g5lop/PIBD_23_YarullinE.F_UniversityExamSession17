using System.Collections.Generic;
using System.Linq;
using WinFormsApp1.Models;
using WinFormsApp1.Repositories.Interfaces;

namespace WinFormsApp1.Repositories.Stubs
{
    public class ExamResultRepositoryStub : IExamResultRepository
    {
        private readonly List<ExamResult> _results = new List<ExamResult>();
        private int _currentId = 1;
        private readonly IStudentRepository _studentRepo;
        private readonly IDisciplineRepository _disciplineRepo;

        public ExamResultRepositoryStub(IStudentRepository studentRepo, IDisciplineRepository disciplineRepo)
        {
            _studentRepo = studentRepo;
            _disciplineRepo = disciplineRepo;
        }

        public IEnumerable<ExamResult> GetAll() => _results;

        public void Add(ExamResult result)
        {
            var newResult = ExamResult.Create(_currentId++, result.StudentId, result.DisciplineId, result.Grade);
            _results.Add(newResult);
        }

        public IEnumerable<ExamResultDto> GetAllForDisplay()
        {
            var students = _studentRepo.GetAll().ToList();
            var disciplines = _disciplineRepo.GetAll().ToList();

            return from res in _results
                   join st in students on res.StudentId equals st.Id
                   join disc in disciplines on res.DisciplineId equals disc.Id
                   select new ExamResultDto
                   {
                       StudentName = st.FullName,
                       DisciplineName = disc.Name,
                       GradeText = res.Grade.ToString()
                   };
        }
    }
}