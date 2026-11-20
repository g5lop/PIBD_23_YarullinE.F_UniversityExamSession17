using System;

namespace WinFormsApp1.Models
{
    public class StudentGroup
    {
        public int Id { get; private set; }
        public string GroupNumber { get; private set; }

        private StudentGroup(int id, string groupNumber)
        {
            Id = id;
            GroupNumber = groupNumber;
        }

        public static StudentGroup Create(int id, string groupNumber)
        {
            if (string.IsNullOrWhiteSpace(groupNumber))
                throw new ArgumentException("Номер группы не может быть пустым", nameof(groupNumber));

            return new StudentGroup(id, groupNumber);
        }
    }
}