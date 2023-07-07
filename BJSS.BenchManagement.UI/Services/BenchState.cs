using BJSS.BenchManagement.UI.Models;
using Microsoft.AspNetCore.Components;

namespace BJSS.BenchManagement.UI.Services
{
    public class BenchState
    {
        public HttpClient _httpClient { get; }
        public NavigationManager _navigationManager { get; }

        public BenchState(HttpClient httpClient, NavigationManager navigationManager)
        {
            _httpClient = httpClient;
            _navigationManager = navigationManager;
        }

        public async Task<IList<BenchPlayer>> GetAllPlayers()
        {
            var response = await _httpClient.GetFromJsonAsync<List<BenchPlayer>>($"{_navigationManager.BaseUri}bench");
            if (response == null)
                new List<BenchPlayer>();

            return response;
        }
    }
}