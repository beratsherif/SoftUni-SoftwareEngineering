namespace EDriveRent.Repositories
{
    using EDriveRent.Models.Contracts;
    using EDriveRent.Repositories.Contracts;
    using System.Collections.Generic;
    using System.Linq;

    public class RouteRepository : IRepository<IRoute>
    {
        private List<IRoute> routes;
        public RouteRepository()
        {
            routes = new List<IRoute>();
        }
        public void AddModel(IRoute model)
        {
            routes.Add(model);
        }

        public IRoute FindById(string identifier)
        {
            int currIdentifier = int.Parse(identifier);
            IRoute currRoute = routes.FirstOrDefault(r => r.RouteId == currIdentifier);

            if (currRoute == null)
            {
                return null;
            }
            else
            {
                return currRoute;
            }
        }

        public IReadOnlyCollection<IRoute> GetAll()
        {
            return routes.AsReadOnly();
        }

        public bool RemoveById(string identifier)
        {
            int currIdentifier = int.Parse(identifier);
            IRoute currRoute = routes.FirstOrDefault(r => r.RouteId == currIdentifier);
            if (currRoute == null)
            {
                return false;
            }
            else
            {
                routes.Remove(currRoute);
                return true;
            }
        }
    }
}
