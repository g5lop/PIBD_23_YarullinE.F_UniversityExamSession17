using System;

namespace WinFormsApp1.Models
{
    public class Faculty
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        private Faculty(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static Faculty Create(int id, string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Название факультета не может быть пустым", nameof(name));

            return new Faculty(id, name);
        }
    }
}