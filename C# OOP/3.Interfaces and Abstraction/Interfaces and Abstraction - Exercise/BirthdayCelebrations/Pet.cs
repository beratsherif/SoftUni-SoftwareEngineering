namespace BirthdayCelebrations
{
    public class Pet : IPet, IBirthdayable
    {
        public Pet(string name,string birthDate)
        {
            this.Name = name;
            this.BirthDate = birthDate;
        }
        public string Name { get;private set; }
        public string BirthDate { get;private set; }
    }
}
