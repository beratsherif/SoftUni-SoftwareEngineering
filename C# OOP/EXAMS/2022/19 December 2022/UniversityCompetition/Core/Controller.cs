namespace UniversityCompetition.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Core.Contracts;
    using UniversityCompetition.Models;
    using UniversityCompetition.Models.Contracts;
    using UniversityCompetition.Repositories;
    using UniversityCompetition.Utilities.Messages;

    public class Controller : IController
    {
        private SubjectRepository subjects;
        private StudentRepository students;
        private UniversityRepository universities;
        public Controller()
        {
            subjects = new SubjectRepository();
            students = new StudentRepository();
            universities = new UniversityRepository();
        }

        public string AddSubject(string subjectName, string subjectType)
        {
            if (subjects.Models.Any(s=> s.Name == subjectName))
            {
                return string.Format(OutputMessages.AlreadyAddedSubject, subjectName);
            }

            ISubject currSup;
            if (subjectType == "TechnicalSubject")
            {
                currSup = new TechnicalSubject(subjects.Models.Count + 1, subjectName);
            }
            else if (subjectType == "EconomicalSubject")
            {
                currSup = new EconomicalSubject(subjects.Models.Count + 1, subjectName);
            }
            else if (subjectType == "HumanitySubject")
            {
                currSup = new HumanitySubject(subjects.Models.Count + 1, subjectName);
            }
            else
            {
                return string.Format(OutputMessages.SubjectTypeNotSupported, subjectType);
            }

            subjects.AddModel(currSup);
            return string.Format(OutputMessages.SubjectAddedSuccessfully, subjectType, subjectName, subjects.GetType().Name);
            
        }

        public string AddUniversity(string universityName, string category, int capacity, List<string> requiredSubjects)
        {
            if (universities.Models.Any(u=> u.Name == universityName))
            {
                return string.Format(OutputMessages.AlreadyAddedUniversity, universityName);
            }


            List<int> currRequiredSubjects = new List<int>();

            
            foreach (var subject in requiredSubjects)
            {
                currRequiredSubjects.Add(subjects.FindByName(subject).Id);
            }

            IUniversity currUni = new University(universities.Models.Count + 1, universityName, category, capacity, currRequiredSubjects);
            universities.AddModel(currUni);

            return string.Format(OutputMessages.UniversityAddedSuccessfully, universityName, universities.GetType().Name);
        }

        public string AddStudent(string firstName, string lastName)
        {
            if (students.Models.Any(s=> s.FirstName == firstName && s.LastName == lastName))
            {
                return string.Format(OutputMessages.AlreadyAddedStudent, firstName, lastName);
            }

            IStudent currStudent = new Student(students.Models.Count + 1, firstName,lastName);
            students.AddModel(currStudent);
            return string.Format(OutputMessages.StudentAddedSuccessfully, firstName, lastName, students.GetType().Name);
        }

        public string TakeExam(int studentId, int subjectId)
        {
            if (students.FindById(studentId) == null)
            {
                return OutputMessages.InvalidStudentId;
            }
            else if (subjects.FindById(subjectId) == null)
            {
                return OutputMessages.InvalidSubjectId;
            }

            IStudent currStudent = students.Models.First(s => s.Id == studentId);
            string examName = subjects.FindById(subjectId).Name;

            if (currStudent.CoveredExams.Contains(subjectId))
            {
                return string.Format(OutputMessages.StudentAlreadyCoveredThatExam,currStudent.FirstName,currStudent.LastName,examName);
            }

            
            currStudent.CoverExam(subjects.FindById(subjectId));
            return string.Format(OutputMessages.StudentSuccessfullyCoveredExam, currStudent.FirstName, currStudent.LastName, examName);
        }


        public string ApplyToUniversity(string studentName, string universityName)
        {
            string[] fullName = studentName.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if (students.FindByName(studentName) == null)
            {
                return string.Format(OutputMessages.StudentNotRegitered, fullName[0], fullName[1]);
            }
            if (universities.FindByName(universityName) == null)
            {
                return string.Format(OutputMessages.UniversityNotRegitered, universityName);
            }

            IStudent currStudent = students.FindByName(studentName);
            IUniversity currUni = universities.FindByName(universityName);

            foreach (var exam in currUni.RequiredSubjects)
            {
                if (!currStudent.CoveredExams.Contains(exam))
                {
                    return string.Format(OutputMessages.StudentHasToCoverExams, currStudent.FirstName, currUni.Name);
                }
            }

            if (currStudent.University != null)
            {
                return string.Format(OutputMessages.StudentAlreadyJoined, currStudent.FirstName, currStudent.LastName, universityName);
            }

            currStudent.JoinUniversity(currUni);

            return string.Format(OutputMessages.StudentSuccessfullyJoined, currStudent.FirstName, currStudent.LastName, universityName);
        }

       

        public string UniversityReport(int universityId)
        {
            IUniversity currUni = universities.FindById(universityId);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"*** {currUni.Name} ***");
            sb.AppendLine($"Profile: {currUni.Category}");

            int studentsCOunt = 0;
            foreach (var student in students.Models)
            {
                if (student.University != null && student.University.Name == currUni.Name)
                {
                    studentsCOunt++;
                }
            }

            sb.AppendLine($"Students admitted: {studentsCOunt}");
            sb.AppendLine($"University vacancy: {currUni.Capacity - studentsCOunt}");

            return sb.ToString().TrimEnd();
        }
    }
}
