
namespace WebAssemblyDemo.Client.Models
{
    public interface IServersRepository
    {
        Task AddServerAsync(Server server);
        Task DeleteServerAsync(int serverId);
        Task<Server?> GetServerByIdAsync(int id);
        Task<List<Server>> GetServersAsync();
        Task UpdateServerAsync(int serverId, Server server);
    }
}