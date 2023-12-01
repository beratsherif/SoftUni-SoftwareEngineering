namespace UniversityCompetition.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using UniversityCompetition.Models.Contracts;
    using UniversityCompetition.Repositories.Contracts;

    public class StudentRepository : IRepository<IStudent>
    {
        private List<IStudent> students;
        public StudentRepository()
        {
            students = new List<IStudent>();
        }
        public IReadOnlyCollection<IStudent> Models => students.AsReadOnly();

        public void AddModel(IStudent model)
        {
            students.Add(model);
        }

        public IStudent FindById(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }

        public IStudent FindByName(string name)
        {
            string[] fullName = name.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            return students.FirstOrDefault(s => s.FirstName == fullName[0] && s.LastName == fullName[1]);
        }
    }
}
