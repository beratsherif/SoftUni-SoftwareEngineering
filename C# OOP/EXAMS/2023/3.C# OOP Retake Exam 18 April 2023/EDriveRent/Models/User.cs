namespace EDriveRent.Models
{
    using Utilities.Messages;
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;


    public class User : IUser
    {
        private string firstName;
        private string lastName;
        private string drivingLicenseNumber;
        public User(string firstName, string lastName, string drivingLicenseNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DrivingLicenseNumber = drivingLicenseNumber;
            this.Rating = 0;
            this.IsBlocked = false;
        }
        
        public string FirstName
        {
            get
            {
                return firstName;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.FirstNameNull);
                }
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.LastNameNull);
                }
                lastName = value;
            }
        }

        public double Rating { get; private set; }

        public string DrivingLicenseNumber
        {
            get
            {
                return drivingLicenseNumber;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.DrivingLicenseRequired);
                }
                drivingLicenseNumber = value;
            }
        }

        public bool IsBlocked { get; private set; }

        public void DecreaseRating()
        {
            this.Rating -= 2;
            if (this.Rating < 0)
            {
                this.Rating = 0;
                this.IsBlocked = true;
            }
        }

        public void IncreaseRating()
        {
            this.Rating += 0.5;
            if (this.Rating > 10)
            {
                this.Rating = 10;
            }
        }
        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} Driving license: {this.drivingLicenseNumber} Rating: {this.Rating}";
        }
    }
}
