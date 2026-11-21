using System;
using WinFormsApp1.Enums;

namespace WinFormsApp1.Models
{
    public class Student
    {
        public int Id { get; private set; }
        public string FullName { get; private set; }
        public int GroupId { get; private set; }
        public StudentStatus Status { get; private set; }
        public decimal AverageScore { get; private set; }
        public decimal ScholarshipAmount { get; private set; }

        private Student(int id, string fullName, int groupId, StudentStatus status, decimal averageScore, decimal scholarship)
        {
            Id = id;
            FullName = fullName;
            GroupId = groupId;
            Status = status;
            AverageScore = averageScore;
            ScholarshipAmount = scholarship;
        }

        public static Student Create(int id, string fullName, int groupId, StudentStatus status, decimal averageScore)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentException("ФИО не может быть пустым", nameof(fullName));
            if (groupId <= 0)
                throw new ArgumentException("Выберите группу", nameof(groupId));
            if (averageScore < 2 || averageScore > 5)
                throw new ArgumentException("Средний балл должен быть от 2 до 5", nameof(averageScore));

            decimal scholarship = CalculateScholarship(averageScore, status);
            return new Student(id, fullName, groupId, status, averageScore, scholarship);
        }

        private static decimal CalculateScholarship(decimal avgScore, StudentStatus status)
        {
            decimal baseScholarship = 600m;
            decimal total = baseScholarship;

            if (avgScore == 5.0m) total += baseScholarship * 1.0m;
            else if (avgScore >= 4.5m && avgScore < 5.0m) total += baseScholarship * 0.5m;

            if (status.HasFlag(StudentStatus.Married)) total += baseScholarship;
            if (status.HasFlag(StudentStatus.InDormitory)) total -= 100m;

            return total;
        }
    }
}