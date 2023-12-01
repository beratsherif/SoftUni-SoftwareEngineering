namespace UniversityCompetition.Models
{
    using Models.Contracts;
    using System;
    using System.Collections.Generic;
    using UniversityCompetition.Utilities.Messages;

    public class Student : IStudent
    {
        private string firstName;
        private string lasrName;
        private List<int> coveredExams;
        public Student(int studentId, string firstName, string lastName)
        {
            this.Id = studentId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.coveredExams = new List<int>();
        }
        public int Id { get; private set; }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.NameNullOrWhitespace);
                }

                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lasrName;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.NameNullOrWhitespace);
                }

                lasrName = value;
            }
        }

        public IReadOnlyCollection<int> CoveredExams => coveredExams.AsReadOnly();

        public IUniversity University { get; private set; }

        public void CoverExam(ISubject subject)
        {
            coveredExams.Add(subject.Id);
        }

        public void JoinUniversity(IUniversity university)
        {
            University = university;
        }
    }
}
