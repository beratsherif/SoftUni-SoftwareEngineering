namespace EDriveRent.Models
{
    using System;


    public class CargoVan : Vehicle
    {
        private const double CURR_MAX_MILLAGE = 180;
        public CargoVan(string brand, string model, string licensePlateNumber) : base(brand,model,CURR_MAX_MILLAGE,licensePlateNumber)
        {

        }
    }
}
