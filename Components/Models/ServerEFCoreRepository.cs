using BlazorSVM.Models;
using Microsoft.EntityFrameworkCore;
using ServerManagement2._0.Data;
namespace ServerManagement2._0.Components.Models



{
    public class ServerEFCoreRepository : IServerEFCoreRepository
    {
        private readonly IDbContextFactory<ServerManagementContext> contextFactory;

        public ServerEFCoreRepository(IDbContextFactory<ServerManagementContext> contextFactory)
        {
            this.contextFactory = contextFactory;
        }

        public void AddServer(Server server)
        {
            using var db = contextFactory.CreateDbContext();
            db.Servers.Add(server);
            db.SaveChanges();
        }

        public List<Server> GetServers()
        {
            using var db = contextFactory.CreateDbContext();
            return db.Servers.ToList();
        }

        public List<Server> GetServersByCity(string cityName)
        {
            using var db = contextFactory.CreateDbContext();
            return db.Servers.Where(x => x.City != null && x.City.ToLower().IndexOf(cityName.ToLower()) >= 0).ToList();
        }

        public Server? GetServerById(int id)
        {
            using var db = contextFactory.CreateDbContext();
            var server = db.Servers.Find(id);
            if (server is not null) return server;
            return new Server();
        }

        public void UpdateServer(int serverID, Server server)
        {
            if (server == null) throw new ArgumentNullException(nameof(server));
            if (serverID != server.ServerID) return;

            using var db = contextFactory.CreateDbContext();
            var serverToUpdate = db.Servers.Find(serverID);
            if (serverToUpdate != null)
            {
                serverToUpdate.IsOnline = server.IsOnline;
                serverToUpdate.Name = server.Name;
                serverToUpdate.City = server.City;

                db.SaveChanges();
            }
        }

        public void DeleteServer(int serverID)
        {
            using var db = contextFactory.CreateDbContext();
            var server = db.Servers.Find(serverID);
            if (server is null) return;


            db.Servers.Remove(server);
            db.SaveChanges();

        }

        public List<Server> SearchServers(string serverFilter)
        {
            using var db = contextFactory.CreateDbContext();
            return db.Servers.Where(x => x.Name != null && x.Name.ToLower().IndexOf(serverFilter.ToLower()) >= 0).ToList();
        }
    }
}
