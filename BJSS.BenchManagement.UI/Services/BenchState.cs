using Models;
using Microsoft.AspNetCore.Components;

namespace BJSS.BenchManagement.UI.Services
{
    public class BenchState
    {
        public List<BenchPlayer> Players = new List<BenchPlayer> 
        { 
            new BenchPlayer() 
            { 
                FullName = "Damásio Sabino", 
                Role = "Software Engineer"
            },
            new BenchPlayer() 
            { 
                FullName = "Josué Costa", 
                Role = "Software Engineer"
            } 
        };

        public BenchState(HttpClient httpClient, NavigationManager navigationManager)
        {
            _httpClient = httpClient;
            _navigationManager = navigationManager;
        }

        public HttpClient _httpClient { get; }
        public NavigationManager _navigationManager { get; }

        public async Task<IList<BenchPlayer>> GetAllPlayers()
        {
            var response = await _httpClient.GetFromJsonAsync<List<BenchPlayer>>($"{_navigationManager.BaseUri}orders");
            if (response == null)
                new List<BenchPlayer>();

            return response;
        }
    }
}