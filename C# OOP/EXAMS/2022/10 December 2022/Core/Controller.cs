namespace ChristmasPastryShop.Core
{
    using ChristmasPastryShop.Core.Contracts;
    using ChristmasPastryShop.Models.Booths;
    using ChristmasPastryShop.Models.Booths.Contracts;
    using ChristmasPastryShop.Models.Cocktails;
    using ChristmasPastryShop.Models.Cocktails.Contracts;
    using ChristmasPastryShop.Models.Delicacies;
    using ChristmasPastryShop.Models.Delicacies.Contracts;
    using ChristmasPastryShop.Repositories;
    using ChristmasPastryShop.Utilities.Messages;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Controller : IController
    {
        private BoothRepository booths;
        public Controller()
        {
            booths = new BoothRepository();
        }
        public string AddBooth(int capacity)
        {
            IBooth currBooth = new Booth(booths.Models.Count + 1, capacity);
            booths.AddModel(currBooth);

            return string.Format(OutputMessages.NewBoothAdded, currBooth.BoothId, currBooth.Capacity);
        }

        public string AddDelicacy(int boothId, string delicacyTypeName, string delicacyName)
        {
            IDelicacy currDelicacy;

            if (delicacyTypeName == "Gingerbread")
            {
                currDelicacy = new Gingerbread(delicacyName);
            }
            else if (delicacyTypeName == "Stolen")
            {
                currDelicacy = new Stolen(delicacyName);
            }
            else
            {
                return string.Format(OutputMessages.InvalidDelicacyType, delicacyTypeName);
            }

            if (booths.Models.Any(b => b.DelicacyMenu.Models.Any(d => d.Name == delicacyName)))
            {
                return string.Format(OutputMessages.DelicacyAlreadyAdded, delicacyName);
            }

            IBooth currBooth = booths.Models.First(b => b.BoothId == boothId);
            currBooth.DelicacyMenu.AddModel(currDelicacy);

            return string.Format(OutputMessages.NewDelicacyAdded, delicacyTypeName, delicacyName);
        }

        public string AddCocktail(int boothId, string cocktailTypeName, string cocktailName, string size)
        {
            ICocktail currCocktail;
            

            if (cocktailTypeName == "MulledWine")
            {
                currCocktail = new MulledWine(cocktailName, size);
            }
            else if (cocktailTypeName == "Hibernation")
            {
                currCocktail = new Hibernation(cocktailName, size);
            }
            else
            {
                return string.Format(OutputMessages.InvalidCocktailType, cocktailTypeName);
            }

            if (size != "Small" && size != "Middle" && size != "Large")
            {
                return string.Format(OutputMessages.InvalidCocktailSize, size);
            }

            if (booths.Models.Any(b => b.CocktailMenu.Models.Any(c => c.Name == cocktailName && c.Size == size)))
            {
                return string.Format(OutputMessages.CocktailAlreadyAdded, size, cocktailName);
            }

            IBooth currBoth = booths.Models.First(b => b.BoothId == boothId);
            currBoth.CocktailMenu.AddModel(currCocktail);
            return string.Format(OutputMessages.NewCocktailAdded, size, cocktailName, cocktailTypeName);
        }

        public string ReserveBooth(int countOfPeople)
        {
            List<IBooth> currBooths = booths.Models.Where(b => b.IsReserved == false && b.Capacity >= countOfPeople).OrderBy(b=> b.Capacity).ThenByDescending(b=> b.BoothId).ToList();

            

            IBooth currBooth = currBooths.FirstOrDefault();

            if (currBooth == null)
            {
                return string.Format(OutputMessages.NoAvailableBooth, countOfPeople);
            }

            currBooth.ChangeStatus();

            return string.Format(OutputMessages.BoothReservedSuccessfully, currBooth.BoothId, countOfPeople);

        }

        public string TryOrder(int boothId, string order)
        {
            string[] inputs = order.Split("/", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string itemTypeName = inputs[0];
            string itemName = inputs[1];
            int countOfOrderedPieces = int.Parse(inputs[2]);
            string cocktailSize = string.Empty;
            if (inputs.Length == 4)
            {
                cocktailSize = inputs[3];
            }

            IBooth currBooth = booths.Models.First(b => b.BoothId == boothId);

            if (itemTypeName != "Gingerbread" && itemTypeName != "Stolen" && itemTypeName != "MulledWine" && itemTypeName != "Hibernation")
            {
                return string.Format(OutputMessages.NotRecognizedType, itemTypeName);
            }


            if (cocktailSize == string.Empty)
            {
                var currDelicacy = currBooth.DelicacyMenu.Models.FirstOrDefault(d => d.Name == itemName);
                if (currDelicacy == null)
                {
                    return string.Format(OutputMessages.DelicacyStillNotAdded, itemTypeName, itemName);
                }
            }
            else
            {
                var currCokctail = currBooth.CocktailMenu.Models.FirstOrDefault(c => c.Name == itemName);
                if (currCokctail == null)
                {
                    return string.Format(OutputMessages.CocktailStillNotAdded, itemTypeName, itemName);
                }
            }

            if (cocktailSize == string.Empty)
            {
                var currDelicacy = currBooth.DelicacyMenu.Models.FirstOrDefault(d => d.Name == itemName && d.GetType().Name == itemTypeName);
                if (currDelicacy == null)
                {
                    return string.Format(OutputMessages.DelicacyStillNotAdded, itemTypeName, itemName);
                }

                double priceAmount = currDelicacy.Price * countOfOrderedPieces;
                currBooth.UpdateCurrentBill(priceAmount);

                return string.Format(OutputMessages.SuccessfullyOrdered, currBooth.BoothId, countOfOrderedPieces, itemName);
            }
            else
            {
                var currCokctail = currBooth.CocktailMenu.Models.FirstOrDefault(c => c.Name == itemName && c.GetType().Name == itemTypeName && c.Size == cocktailSize);
                if (currCokctail == null)
                {
                    return string.Format(OutputMessages.CocktailStillNotAdded, cocktailSize, itemName);
                }

                double priceAmount = currCokctail.Price * countOfOrderedPieces;
                currBooth.UpdateCurrentBill(priceAmount);
                return string.Format(OutputMessages.SuccessfullyOrdered, currBooth.BoothId, countOfOrderedPieces, itemName);
            }

           
        }

        public string LeaveBooth(int boothId)
        {
            var currBooth = booths.Models.FirstOrDefault(b => b.BoothId == boothId);
            var currBill = currBooth.CurrentBill;

            currBooth.Charge();
            currBooth.ChangeStatus();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Bill {currBill:f2} lv");
            sb.AppendLine($"Booth {boothId} is now available!");

            return sb.ToString().TrimEnd();
        }

        public string BoothReport(int boothId)
        {
            var currBooth = booths.Models.FirstOrDefault(b => b.BoothId == boothId);
            return currBooth.ToString();
        }

       

    }
}
