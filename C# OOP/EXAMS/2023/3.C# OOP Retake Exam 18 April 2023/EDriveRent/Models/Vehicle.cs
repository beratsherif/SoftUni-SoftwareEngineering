namespace EDriveRent.Models
{
    using Utilities.Messages;
    using EDriveRent.Models.Contracts;
    using System;


    public abstract class Vehicle : IVehicle
    {
        private string brand;
        private string model;
        private string licensePlateNumber;
        public Vehicle(string brand, string model, double maxMileage, string licensePlateNumbe)
        {
            this.Brand = brand;
            this.Model = model;
            this.MaxMileage = maxMileage;
            this.LicensePlateNumber = licensePlateNumbe;
            this.BatteryLevel = 100;
            this.IsDamaged = false;
        }
        public string Brand
        {
            get
            {
                return brand;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.BrandNull);
                }
                brand = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.ModelNull);
                }
                model = value;
            }
        }

        public double MaxMileage { get; private set; }

        public string LicensePlateNumber
        {
            get
            {
                return licensePlateNumber;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.LicenceNumberRequired);
                }
                licensePlateNumber = value;
            }
        }

        public int BatteryLevel { get; private set; }

        public bool IsDamaged { get; private set; }

        public  void Drive(double mileage)
        {
            string type = this.GetType().Name;
            if (type == "PassengerCar")
            {
                double decreaseBatLevel = Math.Round((mileage / MaxMileage) * 100);
                BatteryLevel -= (int)decreaseBatLevel;
            }
            else
            {
                double decreaseBatLevel = Math.Round((mileage / MaxMileage) * 105);
                BatteryLevel -= (int)decreaseBatLevel;
            }
        }

        public void Recharge()
        {
            this.BatteryLevel = 100;
        }
        public void ChangeStatus()
        {
            this.IsDamaged = !IsDamaged;
        }

        public override string ToString()
        {
            string status = IsDamaged ? "damaged" : "OK";
            return $"{this.brand} {this.model} License plate: {this.LicensePlateNumber} Battery: {this.BatteryLevel}% Status: {status}";
        }
    }
}
