using System.Net.Http;

namespace ScoreSaberApi
{
    public class ScoreSaber
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://scoresaber.com/api";
        public ScoreSaber()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/142.0.0.0 Safari/537.36"
            );
        }

        public async Task<string> GetPlayers()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/players");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetLeaderboards()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/leaderboards");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetRankingsTop()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/ranking/requests/top");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetRankingsBelowTop()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/ranking/requests/belowTop");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetPlayer(long playerId)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/player/{playerId}/full");
            return await response.Content.ReadAsStringAsync();
        }
      
        public async Task<string> GetPlayerScores(long playerId)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/player/{playerId}/scores");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
