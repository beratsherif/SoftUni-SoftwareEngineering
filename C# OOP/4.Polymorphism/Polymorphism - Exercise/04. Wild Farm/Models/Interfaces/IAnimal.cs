namespace _04._Wild_Farm.Models.Interfaces
{
    public interface IAnimal
    {
        string Name { get; }
        double Weight { get; }
        int FoodEaten { get; }
        string PoduceSound();
        void Eat(IFood food);
    }
}
