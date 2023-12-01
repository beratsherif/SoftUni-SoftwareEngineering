namespace EDriveRent.Repositories
{
    using EDriveRent.Models.Contracts;
    using EDriveRent.Repositories.Contracts;
    using System.Collections.Generic;
    using System.Linq;
    public class UserRepository : IRepository<IUser>
    {
        private List<IUser> users;
        public UserRepository()
        {
            users = new List<IUser>();
        }
        public void AddModel(IUser model)
        {
            users.Add(model);
        }
        public bool RemoveById(string identifier)
        {
            IUser currUser = users.FirstOrDefault(u => u.DrivingLicenseNumber == identifier);
            if (currUser == null)
            {
                return false;
            }
            else
            {
                users.Remove(currUser);
                return true;
            }
        }

        public IUser FindById(string identifier)
        {
            IUser currUser = users.FirstOrDefault(u => u.DrivingLicenseNumber == identifier);
            if (currUser == null)
            {
                return null;
            }
            else
            {
                return currUser;
            }

        }

        public IReadOnlyCollection<IUser> GetAll()
        {
            return users.AsReadOnly();
        }
       
    }
}
