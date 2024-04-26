using Newtonsoft.Json;

namespace WebAssemblyDemo.Client.Models
{
    public class ServersApiRepository : IServersRepository
    {
        private const string apiName = "ServersApi";
        private readonly IHttpClientFactory httpClientFactory;

        public ServersApiRepository(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        public async Task<List<Server>> GetServersAsync()
        {
            var httpClient = httpClientFactory.CreateClient(apiName);

            var response = await httpClient.GetAsync("servers.json");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            if (!string.IsNullOrEmpty(content) && content != "null")
            {
                return JsonConvert.DeserializeObject<List<Server>>(content) ?? new List<Server>();
            }
            else
                return new List<Server>();
        }
    }
}
