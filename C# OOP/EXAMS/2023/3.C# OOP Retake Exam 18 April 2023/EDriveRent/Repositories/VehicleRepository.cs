namespace EDriveRent.Repositories
{
    using EDriveRent.Models.Contracts;
    using EDriveRent.Repositories.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class VehicleRepository : IRepository<IVehicle>
    {
        private List<IVehicle> vehicles;
        public VehicleRepository()
        {
            vehicles = new List<IVehicle>();
        }
        public void AddModel(IVehicle model)
        {
            vehicles.Add(model);
        }
        public bool RemoveById(string identifier)
        {
            IVehicle currVehicle = vehicles.FirstOrDefault(v => v.LicensePlateNumber == identifier);
            if (currVehicle == null)
            {
                return false;
            }
            else
            {
                vehicles.Remove(currVehicle);
                return true;
            }
        }
        public IVehicle FindById(string identifier)
        {
            IVehicle currVehicle = vehicles.FirstOrDefault(v => v.LicensePlateNumber == identifier);
            if (currVehicle == null)
            {
                return null;
            }
            else
            {
                return currVehicle;

            }
        }

        public IReadOnlyCollection<IVehicle> GetAll()
        {
            return vehicles.AsReadOnly();
        }

        
    }
}
