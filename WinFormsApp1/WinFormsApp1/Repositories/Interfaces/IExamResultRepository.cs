using System.Collections.Generic;
using WinFormsApp1.Models;

namespace WinFormsApp1.Repositories.Interfaces
{
    public interface IExamResultRepository
    {
        IEnumerable<ExamResult> GetAll();
        IEnumerable<ExamResultDto> GetAllForDisplay(); // Метод для красивой таблицы
        void Add(ExamResult result);
    }
}