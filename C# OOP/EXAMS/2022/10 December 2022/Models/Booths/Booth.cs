namespace ChristmasPastryShop.Models.Booths
{
    using ChristmasPastryShop.Models.Booths.Contracts;
    using ChristmasPastryShop.Models.Cocktails.Contracts;
    using ChristmasPastryShop.Models.Delicacies.Contracts;
    using ChristmasPastryShop.Repositories;
    using ChristmasPastryShop.Repositories.Contracts;
    using ChristmasPastryShop.Utilities.Messages;
    using System;
    using System.Text;

    public class Booth : IBooth
    {
        private int capacity;
        private DelicacyRepository delicacyMenu;
        private CocktailRepository cocktailMenu;

        public Booth(int boothId, int capacity)
        {
            this.BoothId = boothId;
            this.Capacity = capacity;

            this.IsReserved = false;
            delicacyMenu = new DelicacyRepository();
            cocktailMenu = new CocktailRepository();
        }

        public int BoothId { get; private set; }

        public int Capacity
        {
            get
            {
                return capacity;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.CapacityLessThanOne);
                }

                capacity = value;
            }
        }

        public IRepository<IDelicacy> DelicacyMenu => delicacyMenu;

        public IRepository<ICocktail> CocktailMenu => cocktailMenu;

        public double CurrentBill { get; private set; }

        public double Turnover { get; private set; }

        public bool IsReserved { get; private set; }

        public void ChangeStatus()
        {
            IsReserved = !IsReserved;
        }

        public void Charge()
        {
            this.Turnover += this.CurrentBill;
            this.CurrentBill = 0;
        }

        public void UpdateCurrentBill(double amount)
        {
            this.CurrentBill += amount;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Booth: {this.BoothId}");
            sb.AppendLine($"Capacity: {this.Capacity}");
            sb.AppendLine($"Turnover: {this.Turnover:f2} lv");

            sb.AppendLine($"-Cocktail menu:");

            foreach (var cocktail in CocktailMenu.Models)
            {
                sb.AppendLine($"--{cocktail.ToString()}");
            }

            sb.AppendLine($"-Delicacy menu:");

            foreach (var delicacy in DelicacyMenu.Models)
            {
                sb.AppendLine($"--{delicacy.ToString()}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
