using System.Collections.Specialized;
using System.Reflection.Metadata;

namespace PersonInfo
{
    public class Citizen : IPerson, IIdentifiable, IBirthable
    {
        private string name;
        private int age;
        private string id;
        private string birhtdate;

        public Citizen(string name,int age,string id,string birhtdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birhtdate;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public string Id
        {
            get => id;
            set => id = value;
        }

        public string Birthdate
        {
            get => birhtdate;
            set => birhtdate = value;
        }
    }
}
