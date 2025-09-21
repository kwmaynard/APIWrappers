using System;
using System.Net.Http;
using System.Threading.Tasks;
using IFPAApiWrapper.Models;
using Newtonsoft.Json;

namespace IFPAApiWrapper
{
    /// <summary>
    /// Client for accessing the IFPA Pinball API.
    /// </summary>
    /// <seealso href="https://www.ifpapinball.com/api/documentation/">IFPA API Documentation</seealso>
    public class IFPAApiClient : IIFPAApiClient
    {
        /// <summary>
        /// The HTTP client used for requests.
        /// </summary>
        private readonly HttpClient _httpClient;

        /// <summary>
        /// The API key for authentication.
        /// </summary>
        private readonly string _apiKey;

        /// <summary>
        /// The base URL for the IFPA API.
        /// </summary>
        private const string BaseUrl = "https://api.ifpapinball.com/";

        /// <summary>
        /// Initializes a new instance of the <see cref="IFPAApiClient"/> class.
        /// </summary>
        /// <param name="apiKey">The IFPA API key.</param>
        /// <exception cref="ArgumentNullException">Thrown if apiKey is null.</exception>
        public IFPAApiClient(string apiKey)
        {
            _apiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
            _httpClient = new HttpClient { BaseAddress = new Uri(BaseUrl) };
            _httpClient.DefaultRequestHeaders.Add("X-API-Key", _apiKey);
        }

        /// <summary>
        /// Gets a director by their ID.
        /// </summary>
        /// <param name="directorId">The director's ID.</param>
        /// <returns>The director details.</returns>
        public async Task<Director> GetDirectorAsync(int directorId)
        {
            var response = await _httpClient.GetAsync($"director/{directorId}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Director>(json);
        }

        /// <summary>
        /// Gets a tournament by its ID.
        /// </summary>
        /// <param name="tournamentId">The tournament's ID.</param>
        /// <returns>The tournament details.</returns>
        public async Task<Tournament> GetTournamentAsync(int tournamentId)
        {
            var response = await _httpClient.GetAsync($"tournament/{tournamentId}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Tournament>(json);
        }

        /// <summary>
        /// Gets a player by their ID.
        /// </summary>
        /// <param name="playerId">The player's ID.</param>
        /// <returns>The player details.</returns>
        public async Task<Player> GetPlayerAsync(int playerId)
        {
            var response = await _httpClient.GetAsync($"player/{playerId}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Player>(json);
        }

        /// <summary>
        /// Gets multiple players by their IDs.
        /// </summary>
        /// <param name="playerIds">Comma-separated player IDs.</param>
        /// <returns>The response containing multiple players.</returns>
        public async Task<PlayerMultiResponse> GetPlayersAsync(string playerIds)
        {
            var response = await _httpClient.GetAsync($"player?players={playerIds}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<PlayerMultiResponse>(json);
        }

        /// <summary>
        /// Gets player-vs-player statistics for a player.
        /// </summary>
        /// <param name="playerId">The player's ID.</param>
        /// <returns>The PvP response for the player.</returns>
        public async Task<PlayerPvpResponse> GetPlayerPvpAsync(int playerId)
        {
            var response = await _httpClient.GetAsync($"player/{playerId}/pvp");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<PlayerPvpResponse>(json);
        }

        /// <summary>
        /// Gets player-vs-player statistics between two players.
        /// </summary>
        /// <param name="playerId">The first player's ID.</param>
        /// <param name="otherPlayerId">The second player's ID.</param>
        /// <returns>The PvP response between two players.</returns>
        public async Task<PlayerPvpToPlayerResponse> GetPlayerPvpToPlayerAsync(int playerId, int otherPlayerId)
        {
            var response = await _httpClient.GetAsync($"player/{playerId}/pvp/{otherPlayerId}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<PlayerPvpToPlayerResponse>(json);
        }

        /// <summary>
        /// Gets the rank history for a player.
        /// </summary>
        /// <param name="playerId">The player's ID.</param>
        /// <returns>The player's rank history response.</returns>
        public async Task<PlayerRankHistoryResponse> GetPlayerRankHistoryAsync(int playerId)
        {
            var response = await _httpClient.GetAsync($"player/{playerId}/rank_history");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<PlayerRankHistoryResponse>(json);
        }

        /// <summary>
        /// Gets the results for a player in a specific ranking system and type.
        /// </summary>
        /// <param name="playerId">The player's ID.</param>
        /// <param name="rankingSystem">The ranking system.</param>
        /// <param name="type">The type of results.</param>
        /// <returns>The player's results response.</returns>
        public async Task<PlayerResultsResponse> GetPlayerResultsAsync(int playerId, string rankingSystem, string type)
        {
            var response = await _httpClient.GetAsync($"player/{playerId}/results/{rankingSystem}/{type}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<PlayerResultsResponse>(json);
        }

        /// <summary>
        /// Searches for players by name, country, state/province, tournament, or tournament position.
        /// </summary>
        /// <param name="name">Player name.</param>
        /// <param name="country">Country code.</param>
        /// <param name="stateprov">State or province code.</param>
        /// <param name="tournament">Tournament name.</param>
        /// <param name="tourpos">Tournament position.</param>
        /// <returns>The player search response.</returns>
        public async Task<PlayerSearchResponse> SearchPlayersAsync(string name = null, string country = null, string stateprov = null, string tournament = null, int? tourpos = null)
        {
            var url = "player/search?";
            if (!string.IsNullOrEmpty(name)) url += $"name={Uri.EscapeDataString(name)}&";
            if (!string.IsNullOrEmpty(country)) url += $"country={Uri.EscapeDataString(country)}&";
            if (!string.IsNullOrEmpty(stateprov)) url += $"stateprov={Uri.EscapeDataString(stateprov)}&";
            if (!string.IsNullOrEmpty(tournament)) url += $"tournament={Uri.EscapeDataString(tournament)}&";
            if (tourpos.HasValue) url += $"tourpos={tourpos.Value}&";
            var response = await _httpClient.GetAsync(url.TrimEnd('&'));
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<PlayerSearchResponse>(json);
        }

        /// <summary>
        /// Searches for directors by name, country, state/province, or city.
        /// </summary>
        /// <param name="name">Director name.</param>
        /// <param name="country">Country code.</param>
        /// <param name="stateprov">State or province code.</param>
        /// <param name="city">City name.</param>
        /// <returns>The director search response.</returns>
        public async Task<DirectorSearchResponse> SearchDirectorsAsync(string name = null, string country = null, string stateprov = null, string city = null)
        {
            var url = "director/search?";
            if (!string.IsNullOrEmpty(name)) url += $"name={Uri.EscapeDataString(name)}&";
            if (!string.IsNullOrEmpty(country)) url += $"country={Uri.EscapeDataString(country)}&";
            if (!string.IsNullOrEmpty(stateprov)) url += $"stateprov={Uri.EscapeDataString(stateprov)}&";
            if (!string.IsNullOrEmpty(city)) url += $"city={Uri.EscapeDataString(city)}&";
            var response = await _httpClient.GetAsync(url.TrimEnd('&'));
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<DirectorSearchResponse>(json);
        }

        /// <summary>
        /// Gets tournaments for a specific director.
        /// </summary>
        /// <param name="directorId">The director's ID.</param>
        /// <returns>The director tournaments response.</returns>
        public async Task<DirectorTournamentsResponse> GetDirectorTournamentsAsync(int directorId)
        {
            var response = await _httpClient.GetAsync($"director/{directorId}/tournaments");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<DirectorTournamentsResponse>(json);
        }

        /// <summary>
        /// Gets global rankings for a specific system and page.
        /// </summary>
        /// <param name="system">Ranking system.</param>
        /// <param name="page">Page number.</param>
        /// <returns>The global rankings response.</returns>
        public async Task<RankingResponse> GetGlobalRankingsAsync(string system = "MAIN", int? page = null)
        {
            var url = $"rankings/{system}";
            if (page.HasValue) url += $"?page={page.Value}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<RankingResponse>(json);
        }

        /// <summary>
        /// Gets country rankings for a specific country, system, and page.
        /// </summary>
        /// <param name="countryCode">Country code.</param>
        /// <param name="system">Ranking system.</param>
        /// <param name="page">Page number.</param>
        /// <returns>The country rankings response.</returns>
        public async Task<CountryRankingResponse> GetCountryRankingsAsync(string countryCode, string system = "MAIN", int? page = null)
        {
            var url = $"rankings/{system}/country/{countryCode}";
            if (page.HasValue) url += $"?page={page.Value}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<CountryRankingResponse>(json);
        }

        /// <summary>
        /// Gets state rankings for a specific country, state/province, system, and page.
        /// </summary>
        /// <param name="countryCode">Country code.</param>
        /// <param name="stateProv">State or province code.</param>
        /// <param name="system">Ranking system.</param>
        /// <param name="page">Page number.</param>
        /// <returns>The state rankings response.</returns>
        public async Task<StateRankingResponse> GetStateRankingsAsync(string countryCode, string stateProv, string system = "MAIN", int? page = null)
        {
            var url = $"rankings/{system}/country/{countryCode}/stateprov/{stateProv}";
            if (page.HasValue) url += $"?page={page.Value}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<StateRankingResponse>(json);
        }

        /// <summary>
        /// Gets region rankings for a specific region, system, and page.
        /// </summary>
        /// <param name="regionCode">Region code.</param>
        /// <param name="system">Ranking system.</param>
        /// <param name="page">Page number.</param>
        /// <returns>The region rankings response.</returns>
        public async Task<RegionRankingResponse> GetRegionRankingsAsync(string regionCode, string system = "MAIN", int? page = null)
        {
            var url = $"rankings/{system}/region/{regionCode}";
            if (page.HasValue) url += $"?page={page.Value}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<RegionRankingResponse>(json);
        }

        /// <summary>
        /// Gets series rankings for a specific series, year, system, and page.
        /// </summary>
        /// <param name="seriesCode">Series code.</param>
        /// <param name="year">Year.</param>
        /// <param name="system">Ranking system.</param>
        /// <param name="page">Page number.</param>
        /// <returns>The series rankings response.</returns>
        public async Task<SeriesRankingResponse> GetSeriesRankingsAsync(string seriesCode, int year, string system = "MAIN", int? page = null)
        {
            var url = $"rankings/{system}/series/{seriesCode}/{year}";
            if (page.HasValue) url += $"?page={page.Value}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<SeriesRankingResponse>(json);
        }

        /// <summary>
        /// Gets a list of series for a specific region and/or year.
        /// </summary>
        /// <param name="regionCode">Region code.</param>
        /// <param name="year">Year.</param>
        /// <returns>The series list response.</returns>
        public async Task<SeriesListResponse> GetSeriesListAsync(string regionCode = null, int? year = null)
        {
            var url = "series?";
            if (!string.IsNullOrEmpty(regionCode)) url += $"region_code={Uri.EscapeDataString(regionCode)}&";
            if (year.HasValue) url += $"year={year.Value}&";
            var response = await _httpClient.GetAsync(url.TrimEnd('&'));
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<SeriesListResponse>(json);
        }

        /// <summary>
        /// Gets details for a specific series and year.
        /// </summary>
        /// <param name="seriesCode">Series code.</param>
        /// <param name="year">Year.</param>
        /// <returns>The series response.</returns>
        public async Task<SeriesResponse> GetSeriesAsync(string seriesCode, int year)
        {
            var response = await _httpClient.GetAsync($"series/{seriesCode}/{year}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<SeriesResponse>(json);
        }

        /// <summary>
        /// Gets global statistics for a specific system and page.
        /// </summary>
        /// <param name="system">Ranking system.</param>
        /// <param name="page">Page number.</param>
        /// <returns>The global stats response.</returns>
        public async Task<StatsResponse> GetGlobalStatsAsync(string system = "MAIN", int? page = null)
        {
            var url = $"stats/{system}";
            if (page.HasValue) url += $"?page={page.Value}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<StatsResponse>(json);
        }

        /// <summary>
        /// Gets country statistics for a specific country, system, and page.
        /// </summary>
        /// <param name="countryCode">Country code.</param>
        /// <param name="system">Ranking system.</param>
        /// <param name="page">Page number.</param>
        /// <returns>The country stats response.</returns>
        public async Task<StatsResponse> GetCountryStatsAsync(string countryCode, string system = "MAIN", int? page = null)
        {
            var url = $"stats/{system}/country/{countryCode}";
            if (page.HasValue) url += $"?page={page.Value}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<StatsResponse>(json);
        }

        /// <summary>
        /// Gets state statistics for a specific country, state/province, system, and page.
        /// </summary>
        /// <param name="countryCode">Country code.</param>
        /// <param name="stateProv">State or province code.</param>
        /// <param name="system">Ranking system.</param>
        /// <param name="page">Page number.</param>
        /// <returns>The state stats response.</returns>
        public async Task<StatsResponse> GetStateStatsAsync(string countryCode, string stateProv, string system = "MAIN", int? page = null)
        {
            var url = $"stats/{system}/country/{countryCode}/stateprov/{stateProv}";
            if (page.HasValue) url += $"?page={page.Value}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<StatsResponse>(json);
        }

        /// <summary>
        /// Gets region statistics for a specific region, system, and page.
        /// </summary>
        /// <param name="regionCode">Region code.</param>
        /// <param name="system">Ranking system.</param>
        /// <param name="page">Page number.</param>
        /// <returns>The region stats response.</returns>
        public async Task<StatsResponse> GetRegionStatsAsync(string regionCode, string system = "MAIN", int? page = null)
        {
            var url = $"stats/{system}/region/{regionCode}";
            if (page.HasValue) url += $"?page={page.Value}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<StatsResponse>(json);
        }

        /// <summary>
        /// Searches for tournaments by name, country, state/province, city, director ID, or year.
        /// </summary>
        /// <param name="name">Tournament name.</param>
        /// <param name="country">Country code.</param>
        /// <param name="stateprov">State or province code.</param>
        /// <param name="city">City name.</param>
        /// <param name="directorId">Director ID.</param>
        /// <param name="year">Year.</param>
        /// <returns>The tournament search response.</returns>
        public async Task<TournamentSearchResponse> SearchTournamentsAsync(string name = null, string country = null, string stateprov = null, string city = null, int? directorId = null, int? year = null)
        {
            var url = "tournament/search?";
            if (!string.IsNullOrEmpty(name)) url += $"name={Uri.EscapeDataString(name)}&";
            if (!string.IsNullOrEmpty(country)) url += $"country={Uri.EscapeDataString(country)}&";
            if (!string.IsNullOrEmpty(stateprov)) url += $"stateprov={Uri.EscapeDataString(stateprov)}&";
            if (!string.IsNullOrEmpty(city)) url += $"city={Uri.EscapeDataString(city)}&";
            if (directorId.HasValue) url += $"director_id={directorId.Value}&";
            if (year.HasValue) url += $"year={year.Value}&";
            var response = await _httpClient.GetAsync(url.TrimEnd('&'));
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TournamentSearchResponse>(json);
        }

        /// <summary>
        /// Gets results for a specific tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament's ID.</param>
        /// <returns>The tournament results response.</returns>
        public async Task<TournamentResultsResponse> GetTournamentResultsAsync(int tournamentId)
        {
            var response = await _httpClient.GetAsync($"tournament/{tournamentId}/results");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TournamentResultsResponse>(json);
        }
    }
}