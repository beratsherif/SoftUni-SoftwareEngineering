namespace UniversityCompetition.Models
{
    using System;
    using Models.Contracts;
    using UniversityCompetition.Utilities.Messages;

    public abstract class Subject : ISubject
    {
        private string name;
        public Subject(int subjectId, string subjectName, double subjectRate)
        {
            this.Id = subjectId;
            this.Name = subjectName;
            this.Rate = subjectRate;
        }
        public int Id { get; private set; }

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.NameNullOrWhitespace);
                }

                name = value;
            }
        }

        public double Rate { get; private set; }
    }
}
