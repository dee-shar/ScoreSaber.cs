# ScoreSaber.cs
Web-API for [scoresaber.com](https://scoresaber.com) which is Beat Saber's largest leaderboard system for custom songs, hosting 60 million scores across 170,000+ leaderboards, with more than 1 million users worldwide

## Example
```cs
using ScoreSaberApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new ScoreSaber();
            string leaderboards = await api.GetLeaderboards();
            Console.WriteLine(leaderboards);
        }
    }
}
```
