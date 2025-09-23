namespace IFPAApiWrapper.Tests
{
    public class IFPAApiClientTest
    {
        private readonly string _apiKey = "";

        [Fact]
        public void IFPAApiClient_NoKey()
        {
            Assert.Throws<ArgumentNullException>(() => new IFPAApiClient(null));
        }

        [Fact]
        public async Task GetDirectorAsync_ReturnsDirector()
        {
            var client = new IFPAApiClient(_apiKey);
            int directorId = 1;
            var result = await client.GetDirectorAsync(directorId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetTournamentAsync_ReturnsTournament()
        {
            var client = new IFPAApiClient(_apiKey);
            int tournamentId = 1;
            var result = await client.GetTournamentAsync(tournamentId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetPlayerAsync_ReturnsPlayer()
        {
            var client = new IFPAApiClient(_apiKey);
            int playerId = 1;
            var result = await client.GetPlayerAsync(playerId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetPlayersAsync_ReturnsPlayers()
        {
            var client = new IFPAApiClient(_apiKey);
            string playerIds = "1,2";
            var result = await client.GetPlayersAsync(playerIds);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetPlayerPvpAsync_ReturnsPvp()
        {
            var client = new IFPAApiClient(_apiKey);
            int playerId = 1;
            var result = await client.GetPlayerPvpAsync(playerId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetPlayerPvpToPlayerAsync_ReturnsPvp()
        {
            var client = new IFPAApiClient(_apiKey);
            int playerId = 1, otherPlayerId = 2;
            var result = await client.GetPlayerPvpToPlayerAsync(playerId, otherPlayerId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetPlayerRankHistoryAsync_ReturnsHistory()
        {
            var client = new IFPAApiClient(_apiKey);
            int playerId = 1;
            var result = await client.GetPlayerRankHistoryAsync(playerId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetPlayerResultsAsync_ReturnsResults()
        {
            var client = new IFPAApiClient(_apiKey);
            int playerId = 1;
            var result = await client.GetPlayerResultsAsync(playerId, "MAIN", "all");
            Assert.NotNull(result);
        }

        [Fact]
        public async Task SearchPlayersAsync_ReturnsResults()
        {
            var client = new IFPAApiClient(_apiKey);
            var result = await client.SearchPlayersAsync(name: "test");
            Assert.NotNull(result);
        }

        [Fact]
        public async Task SearchDirectorsAsync_ReturnsResults()
        {
            var client = new IFPAApiClient(_apiKey);
            var result = await client.SearchDirectorsAsync(name: "test");
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetDirectorTournamentsAsync_ReturnsResults()
        {
            var client = new IFPAApiClient(_apiKey);
            int directorId = 1;
            var result = await client.GetDirectorTournamentsAsync(directorId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetGlobalRankingsAsync_ReturnsRankings()
        {
            var client = new IFPAApiClient(_apiKey);
            var result = await client.GetGlobalRankingsAsync();
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetCountryRankingsAsync_ReturnsRankings()
        {
            var client = new IFPAApiClient(_apiKey);
            var result = await client.GetCountryRankingsAsync("US");
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetStateRankingsAsync_ReturnsRankings()
        {
            var client = new IFPAApiClient(_apiKey);
            var result = await client.GetStateRankingsAsync("US", "CA");
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetRegionRankingsAsync_ReturnsRankings()
        {
            var client = new IFPAApiClient(_apiKey);
            var result = await client.GetRegionRankingsAsync("US-W");
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetSeriesRankingsAsync_ReturnsRankings()
        {
            var client = new IFPAApiClient(_apiKey);
            var result = await client.GetSeriesRankingsAsync("US-W", 2024);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetSeriesListAsync_ReturnsList()
        {
            var client = new IFPAApiClient(_apiKey);
            var result = await client.GetSeriesListAsync();
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetSeriesAsync_ReturnsSeries()
        {
            var client = new IFPAApiClient(_apiKey);
            var result = await client.GetSeriesAsync("US-W", 2024);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetGlobalStatsAsync_ReturnsStats()
        {
            var client = new IFPAApiClient(_apiKey);
            var result = await client.GetGlobalStatsAsync();
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetCountryStatsAsync_ReturnsStats()
        {
            var client = new IFPAApiClient(_apiKey);
            var result = await client.GetCountryStatsAsync("US");
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetStateStatsAsync_ReturnsStats()
        {
            var client = new IFPAApiClient(_apiKey);
            var result = await client.GetStateStatsAsync("US", "CA");
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetRegionStatsAsync_ReturnsStats()
        {
            var client = new IFPAApiClient(_apiKey);
            var result = await client.GetRegionStatsAsync("US-W");
            Assert.NotNull(result);
        }

        [Fact]
        public async Task SearchTournamentsAsync_ReturnsResults()
        {
            var client = new IFPAApiClient(_apiKey);
            var result = await client.SearchTournamentsAsync(name: "test");
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetTournamentResultsAsync_ReturnsResults()
        {
            var client = new IFPAApiClient(_apiKey);
            int tournamentId = 1;
            var result = await client.GetTournamentResultsAsync(tournamentId);
            Assert.NotNull(result);
        }
    }
}