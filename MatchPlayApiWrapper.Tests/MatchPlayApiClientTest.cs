namespace MatchPlayApiWrapper.Tests
{
    public class MatchPlayApiClientTest
    {
        private readonly string _bearerToken = "";

        [Fact]
        public void MatchPlayApiClient_NoKey()
        {
            Assert.Throws<ArgumentNullException>(() => new MatchPlayApiClient(null));
        }

        [Fact]
        public async Task GetTournamentsAsync_ReturnsList()
        {
            var client = new MatchPlayApiClient(_bearerToken);
            var result = await client.GetTournamentsAsync();
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetTournamentByIdAsync_ReturnsTournament()
        {
            var client = new MatchPlayApiClient(_bearerToken);
            int tournamentId = 1; // Replace with a valid ID
            var result = await client.GetTournamentByIdAsync(tournamentId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetAmazingRaceAsync_ReturnsAmazingRace()
        {
            var client = new MatchPlayApiClient(_bearerToken);
            int tournamentId = 1;
            var result = await client.GetAmazingRaceAsync(tournamentId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetFrenzyAsync_ReturnsFrenzy()
        {
            var client = new MatchPlayApiClient(_bearerToken);
            int tournamentId = 1;
            var result = await client.GetFrenzyAsync(tournamentId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetMaxMatchplayAsync_ReturnsMaxMatchplay()
        {
            var client = new MatchPlayApiClient(_bearerToken);
            int tournamentId = 1;
            var result = await client.GetMaxMatchplayAsync(tournamentId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetSinglePlayerGamesAsync_ReturnsList()
        {
            var client = new MatchPlayApiClient(_bearerToken);
            int tournamentId = 1;
            var result = await client.GetSinglePlayerGamesAsync(tournamentId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetSinglePlayerGamesCsvAsync_ReturnsCsv()
        {
            var client = new MatchPlayApiClient(_bearerToken);
            int tournamentId = 1;
            var result = await client.GetSinglePlayerGamesCsvAsync(tournamentId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetSinglePlayerGamesTopScoresAsync_ReturnsList()
        {
            var client = new MatchPlayApiClient(_bearerToken);
            int tournamentId = 1;
            var result = await client.GetSinglePlayerGamesTopScoresAsync(tournamentId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetSinglePlayerGameByIdAsync_ReturnsGame()
        {
            var client = new MatchPlayApiClient(_bearerToken);
            int tournamentId = 1, gameId = 1;
            var result = await client.GetSinglePlayerGameByIdAsync(tournamentId, gameId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetCardsAsync_ReturnsList()
        {
            var client = new MatchPlayApiClient(_bearerToken);
            int tournamentId = 1;
            var result = await client.GetCardsAsync(tournamentId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetCardByIdAsync_ReturnsCard()
        {
            var client = new MatchPlayApiClient(_bearerToken);
            int tournamentId = 1, cardId = 1;
            var result = await client.GetCardByIdAsync(tournamentId, cardId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetQueuesAsync_ReturnsList()
        {
            var client = new MatchPlayApiClient(_bearerToken);
            int tournamentId = 1;
            var result = await client.GetQueuesAsync(tournamentId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetMatchplayStatsAsync_ReturnsStats()
        {
            var client = new MatchPlayApiClient(_bearerToken);
            int tournamentId = 1;
            var result = await client.GetMatchplayStatsAsync(tournamentId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetRoundStatsAsync_ReturnsList()
        {
            var client = new MatchPlayApiClient(_bearerToken);
            int tournamentId = 1;
            var result = await client.GetRoundStatsAsync(tournamentId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetArenaStatsAsync_ReturnsList()
        {
            var client = new MatchPlayApiClient(_bearerToken);
            int tournamentId = 1;
            var result = await client.GetArenaStatsAsync(tournamentId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetPlayerStatsAsync_ReturnsList()
        {
            var client = new MatchPlayApiClient(_bearerToken);
            int tournamentId = 1;
            var result = await client.GetPlayerStatsAsync(tournamentId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetMatchStatsAsync_ReturnsList()
        {
            var client = new MatchPlayApiClient(_bearerToken);
            int tournamentId = 1;
            var result = await client.GetMatchStatsAsync(tournamentId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetBestGameStatsAsync_ReturnsStats()
        {
            var client = new MatchPlayApiClient(_bearerToken);
            int tournamentId = 1;
            var result = await client.GetBestGameStatsAsync(tournamentId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetPlayersCsvAsync_ReturnsCsv()
        {
            var client = new MatchPlayApiClient(_bearerToken);
            int tournamentId = 1;
            var result = await client.GetPlayersCsvAsync(tournamentId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetArenaBgSummaryAsync_ReturnsList()
        {
            var client = new MatchPlayApiClient(_bearerToken);
            int tournamentId = 1;
            var result = await client.GetArenaBgSummaryAsync(tournamentId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetArenaBgDetailsAsync_ReturnsDetails()
        {
            var client = new MatchPlayApiClient(_bearerToken);
            int tournamentId = 1, arenaId = 1;
            var result = await client.GetArenaBgDetailsAsync(tournamentId, arenaId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetGamesAsync_ReturnsList()
        {
            var client = new MatchPlayApiClient(_bearerToken);
            int tournamentId = 1;
            var result = await client.GetGamesAsync(tournamentId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetActiveGamesAsync_ReturnsList()
        {
            var client = new MatchPlayApiClient(_bearerToken);
            int tournamentId = 1;
            var result = await client.GetActiveGamesAsync(tournamentId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetGamesCsvAsync_ReturnsCsv()
        {
            var client = new MatchPlayApiClient(_bearerToken);
            int tournamentId = 1;
            var result = await client.GetGamesCsvAsync(tournamentId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetGameByIdAsync_ReturnsGame()
        {
            var client = new MatchPlayApiClient(_bearerToken);
            int tournamentId = 1, gameId = 1;
            var result = await client.GetGameByIdAsync(tournamentId, gameId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetRoundsAsync_ReturnsList()
        {
            var client = new MatchPlayApiClient(_bearerToken);
            int tournamentId = 1;
            var result = await client.GetRoundsAsync(tournamentId);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetStandingsAsync_ReturnsList()
        {
            var client = new MatchPlayApiClient(_bearerToken);
            int tournamentId = 1;
            var result = await client.GetStandingsAsync(tournamentId);
            Assert.NotNull(result);
        }
    }
}