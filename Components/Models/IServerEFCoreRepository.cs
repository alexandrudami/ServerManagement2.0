using BlazorSVM.Models;

namespace ServerManagement2._0.Components.Models
{
    public interface IServerEFCoreRepository
    {
        void AddServer(Server server);
        void DeleteServer(int serverID);
        Server? GetServerById(int id);
        List<Server> GetServers();
        List<Server> GetServersByCity(string cityName);
        List<Server> SearchServers(string serverFilter);
        void UpdateServer(int serverID, Server server);
    }
}