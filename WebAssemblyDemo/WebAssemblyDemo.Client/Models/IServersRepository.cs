
namespace WebAssemblyDemo.Client.Models
{
    public interface IServersRepository
    {
        Task AddServerAsync(Server server);
        Task<List<Server>> GetServersAsync();
    }
}