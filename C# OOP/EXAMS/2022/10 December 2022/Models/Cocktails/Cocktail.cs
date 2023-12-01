namespace ChristmasPastryShop.Models.Cocktails
{
    using System;
    using System.Text;
    using ChristmasPastryShop.Models.Cocktails.Contracts;
    using ChristmasPastryShop.Utilities.Messages;
    public abstract class Cocktail : ICocktail
    {
        private string name;
        private double price;
        public Cocktail(string cocktailName, string size, double price)
        {
            this.Name = cocktailName;
            this.Size = size;
            this.Price = price;
        }
        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.NameNullOrWhitespace);
                }

                name = value;
            }
        }

        public string Size { get; private set; }

        public double Price
        {
            get
            {
                return price;
            }
            private set
            {
                double currValue;

                if (this.Size == "Middle")
                {
                    currValue = (value / 3) * 2;
                }
                else if (this.Size == "Small")
                {
                    currValue = value / 3;
                }
                else
                {
                    currValue = value;
                }

                price = currValue;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.Name} ({this.Size}) - {this.Price:f2} lv");

            return sb.ToString().TrimEnd();
        }
    }
}
