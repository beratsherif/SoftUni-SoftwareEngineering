namespace _04._Wild_Farm.Models.Foods
{
    using Interfaces;
    public abstract class Food : IFood
    {
        public Food(int quantity)
        {
            this.Quantity = quantity;
        }
        public int Quantity { get; private set; }
    }
}
