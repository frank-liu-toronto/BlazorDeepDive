
namespace WebAssemblyDemo.Client.Models
{
    public interface IServersRepository
    {
        Task<List<Server>> GetServersAsync();
    }
}