﻿namespace UniversityCompetition.Models
{
    public class TechnicalSubject : Subject
    {
        private const double SUBJECT_RATE = 1.3;
        public TechnicalSubject(int subjectId, string subjectName) : base(subjectId, subjectName,SUBJECT_RATE)
        {

        }
    }
}
