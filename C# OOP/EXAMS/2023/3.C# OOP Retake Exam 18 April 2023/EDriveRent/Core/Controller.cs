namespace EDriveRent.Core
{
    using System.Linq;
    using Core.Contracts;
    using EDriveRent.Repositories;
    using EDriveRent.Models.Contracts;
    using EDriveRent.Utilities.Messages;
    using EDriveRent.Models;
    using System.Collections.Generic;
    using System.Text;

    public class Controller : IController
    {
        private UserRepository users;
        private VehicleRepository vehicles;
        private RouteRepository routes;
        public Controller()
        {
            users = new UserRepository();
            vehicles = new VehicleRepository();
            routes = new RouteRepository();
        }
        public string RegisterUser(string firstName, string lastName, string drivingLicenseNumber)
        {
            IUser currUser = users.FindById(drivingLicenseNumber);
            if (currUser != null)
            {
                return string.Format(OutputMessages.UserWithSameLicenseAlreadyAdded, drivingLicenseNumber);
            }

            IUser createdUser = new User(firstName,lastName,drivingLicenseNumber);
            users.AddModel(createdUser);
            return string.Format(OutputMessages.UserSuccessfullyAdded, firstName, lastName, drivingLicenseNumber);
        }
        public string UploadVehicle(string vehicleType, string brand, string model, string licensePlateNumber)
        {
            IVehicle checkVehicle = vehicles.FindById(licensePlateNumber);
            if (checkVehicle != null && (vehicleType == "PassengerCar" || vehicleType == "CargoVan"))
            {
                return string.Format(OutputMessages.LicensePlateExists, licensePlateNumber);
            }
            IVehicle currVehicle;
            if (vehicleType == "PassengerCar")
            {
                currVehicle = new PassengerCar(brand, model, licensePlateNumber);
            }
            else if (vehicleType == "CargoVan")
            {
                currVehicle = new CargoVan(brand, model, licensePlateNumber);
            }
            else
            {
                return string.Format(OutputMessages.VehicleTypeNotAccessible, vehicleType);
            }

            vehicles.AddModel(currVehicle);
            return string.Format(OutputMessages.VehicleAddedSuccessfully, brand, model, licensePlateNumber);
        }
        public string AllowRoute(string startPoint, string endPoint, double length)
        {
            IReadOnlyCollection<IRoute> currRoutes = routes.GetAll();


            foreach (var route in currRoutes)
            {
                if (route.StartPoint == startPoint && route.EndPoint == endPoint && route.Length == length)
                {
                    return string.Format(OutputMessages.RouteExisting, startPoint, endPoint, length);
                }
                else if (route.StartPoint == startPoint && route.EndPoint == endPoint && route.Length < length)
                {
                    return string.Format(OutputMessages.RouteIsTooLong, startPoint, endPoint);
                }
            }

            IRoute newRoute = new Route(startPoint, endPoint, length, currRoutes.Count + 1);
            routes.AddModel(newRoute);


            currRoutes = routes.GetAll();
            foreach (var route in currRoutes)
            {
                if (route.StartPoint == startPoint && route.EndPoint == endPoint && route.Length > length)
                {
                    IRoute longerRoute = routes.FindById(route.RouteId.ToString());
                    longerRoute.LockRoute();
                }
            }
            return string.Format(OutputMessages.NewRouteAdded, startPoint, endPoint, length);
        }

        public string MakeTrip(string drivingLicenseNumber, string licensePlateNumber, string routeId, bool isAccidentHappened)
        {
            IUser user = users.FindById(drivingLicenseNumber);
            IVehicle vehicle = vehicles.FindById(licensePlateNumber);
            IRoute route = routes.FindById(routeId);

            if (user.IsBlocked == true)
            {
                return string.Format(OutputMessages.UserBlocked, drivingLicenseNumber);
            }
            if (vehicle.IsDamaged == true)
            {
                return string.Format(OutputMessages.VehicleDamaged, licensePlateNumber);
            }
            if (route.IsLocked == true)
            {
                return string.Format(OutputMessages.RouteLocked, routeId);
            }

            vehicle.Drive(route.Length);

            if (isAccidentHappened == true)
            {
                vehicle.ChangeStatus();
                user.DecreaseRating();
            }

            user.IncreaseRating();
            return vehicle.ToString();
        }

        public string RepairVehicles(int count)
        {
            IReadOnlyCollection<IVehicle> currVehicles = vehicles.GetAll();

            List<IVehicle> damagedVehicles = currVehicles.Where(v => v.IsDamaged == true).OrderBy(v => v.Brand).ThenBy(v => v.Model).ToList();

            int realCount = 0;

            if (damagedVehicles.Count == count)
            {
                realCount = count;
            }
            else
            {
                realCount = damagedVehicles.Count;
            }

            foreach (var vehicle in damagedVehicles)
            {
                vehicles.FindById(vehicle.LicensePlateNumber).ChangeStatus();
                vehicles.FindById(vehicle.LicensePlateNumber).Recharge();
            }

            return string.Format(OutputMessages.RepairedVehicles, realCount);
        }

        public string UsersReport()
        {
            IReadOnlyCollection<IUser> currUsers = users.GetAll();
            List<IUser> corectUsers = currUsers.OrderByDescending(u => u.Rating).ThenBy(u => u.LastName).ThenBy(u => u.FirstName).ToList();
            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"*** E-Drive-Rent ***");
            foreach (var user in corectUsers)
            {
                sb.AppendLine(user.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
