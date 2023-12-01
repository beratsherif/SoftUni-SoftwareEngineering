namespace EDriveRent.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;


    public class PassengerCar : Vehicle
    {
        private const double CURR_MAX_MILLAGE = 450;
        public PassengerCar(string brand, string model, string licensePlateNumber) : base(brand, model, CURR_MAX_MILLAGE, licensePlateNumber)
        {

        }
    }
}
