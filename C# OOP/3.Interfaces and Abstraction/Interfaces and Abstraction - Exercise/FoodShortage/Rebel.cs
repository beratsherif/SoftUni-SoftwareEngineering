namespace FoodShortage
{
    public class Rebel: IPerson, IRebel, IBuyer
    {
        public Rebel(string name,int age,string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
        }
        public int Food { get;private set; }
        public string Name { get;private set; }
        public int Age { get;private set; }
        public string Group { get;private set; }

        public int BuyFood()
        {
            return this.Food += 5;
        }
    }
}
