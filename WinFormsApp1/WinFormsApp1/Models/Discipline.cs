using System;

namespace WinFormsApp1.Models
{
    public class Discipline
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Teacher { get; private set; }

        private Discipline(int id, string name, string teacher)
        {
            Id = id;
            Name = name;
            Teacher = teacher;
        }

        public static Discipline Create(int id, string name, string teacher)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Название дисциплины не может быть пустым", nameof(name));
            if (string.IsNullOrWhiteSpace(teacher))
                throw new ArgumentException("ФИО преподавателя не может быть пустым", nameof(teacher));

            return new Discipline(id, name, teacher);
        }
    }
}