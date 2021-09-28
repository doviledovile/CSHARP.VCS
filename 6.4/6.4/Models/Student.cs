using System;


namespace _6._4.Models
{
    public class Student 
    {
        public Student(string name, string surname, DateTime birthday, string documentId)
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;
            DocumentId = documentId;
            Age = 0; //TODO apskaiciuoti
        }

        public string Name { get; }

        public string Surname { get; }

        public DateTime Birthday { get; }

        public string DocumentId { get; }

        public int Age { get; }

    }
}
