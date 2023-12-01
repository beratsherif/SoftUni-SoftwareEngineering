namespace ChristmasPastryShop.Models
{
    using System;
    using System.Text;
    using ChristmasPastryShop.Utilities.Messages;
    using Models.Delicacies.Contracts;
    public abstract class Delicacy : IDelicacy
    {
        private string name;
        public Delicacy(string delicacyName, double price)
        {
            this.Name = delicacyName;
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

        public double Price { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.Name} - {this.Price:f2} lv");

            return sb.ToString().TrimEnd();
        }
    }
}
