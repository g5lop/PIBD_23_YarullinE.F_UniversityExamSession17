using System.Collections.Generic;
using WinFormsApp1.Models;

namespace WinFormsApp1.Repositories.Interfaces
{
    public interface IExamResultRepository
    {
        IEnumerable<ExamResult> GetAll();
        IEnumerable<ExamResultDto> GetAllForDisplay(); 
        void Add(ExamResult result);
    }
}