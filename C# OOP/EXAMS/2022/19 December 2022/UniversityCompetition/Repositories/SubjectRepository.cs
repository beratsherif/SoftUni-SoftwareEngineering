﻿namespace UniversityCompetition.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using UniversityCompetition.Models.Contracts;
    using UniversityCompetition.Repositories.Contracts;

    public class SubjectRepository : IRepository<ISubject>
    {
        private List<ISubject> subjects;
        public SubjectRepository()
        {
            subjects = new List<ISubject>();
        }
        public IReadOnlyCollection<ISubject> Models => subjects.AsReadOnly();

        public void AddModel(ISubject model)
        {
            subjects.Add(model);
        }

        public ISubject FindById(int id)
        {
            return subjects.FirstOrDefault(s => s.Id == id);
        }

        public ISubject FindByName(string name)
        {
            return subjects.FirstOrDefault(s => s.Name == name);
        }
    }
}
