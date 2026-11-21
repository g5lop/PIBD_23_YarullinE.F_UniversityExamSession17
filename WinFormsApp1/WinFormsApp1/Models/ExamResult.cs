using System;
using WinFormsApp1.Enums;

namespace WinFormsApp1.Models
{
    public class ExamResult
    {
        public int Id { get; private set; }
        public int StudentId { get; private set; }
        public int DisciplineId { get; private set; }
        public Grade Grade { get; private set; }

        private ExamResult(int id, int studentId, int disciplineId, Grade grade)
        {
            Id = id;
            StudentId = studentId;
            DisciplineId = disciplineId;
            Grade = grade;
        }

        public static ExamResult Create(int id, int studentId, int disciplineId, Grade grade)
        {
            if (studentId <= 0) throw new ArgumentException("Выберите студента");
            if (disciplineId <= 0) throw new ArgumentException("Выберите дисциплину");

            return new ExamResult(id, studentId, disciplineId, grade);
        }
    }
}