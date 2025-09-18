using System.Threading.Tasks;
using IFPAApiWrapper.Models;

namespace IFPAApiWrapper
{
    /// <summary>
    /// Interface for IFPA Pinball API client methods.
    /// </summary>
    /// <seealso href="https://www.ifpapinball.com/api/documentation/">IFPA API Documentation</seealso>
    public interface IIFPAApiClient
    {
        /// <summary>
        /// Gets a director by their ID.
        /// </summary>
        /// <param name="directorId">The director's ID.</param>
        /// <returns>The director details.</returns>
        Task<Director> GetDirectorAsync(int directorId);

        /// <summary>
        /// Gets a tournament by its ID.
        /// </summary>
        /// <param name="tournamentId">The tournament's ID.</param>
        /// <returns>The tournament details.</returns>
        Task<Tournament> GetTournamentAsync(int tournamentId);

        /// <summary>
        /// Gets a player by their ID.
        /// </summary>
        /// <param name="playerId">The player's ID.</param>
        /// <returns>The player details.</returns>
        Task<Player> GetPlayerAsync(int playerId);

        /// <summary>
        /// Gets multiple players by their IDs.
        /// </summary>
        /// <param name="playerIds">Comma-separated player IDs.</param>
        /// <returns>The response containing multiple players.</returns>
        Task<PlayerMultiResponse> GetPlayersAsync(string playerIds);

        /// <summary>
        /// Gets player-vs-player statistics for a player.
        /// </summary>
        /// <param name="playerId">The player's ID.</param>
        /// <returns>The PvP response for the player.</returns>
        Task<PlayerPvpResponse> GetPlayerPvpAsync(int playerId);

        /// <summary>
        /// Gets player-vs-player statistics between two players.
        /// </summary>
        /// <param name="playerId">The first player's ID.</param>
        /// <param name="otherPlayerId">The second player's ID.</param>
        /// <returns>The PvP response between two players.</returns>
        Task<PlayerPvpToPlayerResponse> GetPlayerPvpToPlayerAsync(int playerId, int otherPlayerId);

        /// <summary>
        /// Gets the rank history for a player.
        /// </summary>
        /// <param name="playerId">The player's ID.</param>
        /// <returns>The player's rank history response.</returns>
        Task<PlayerRankHistoryResponse> GetPlayerRankHistoryAsync(int playerId);

        /// <summary>
        /// Gets the results for a player in a specific ranking system and type.
        /// </summary>
        /// <param name="playerId">The player's ID.</param>
        /// <param name="rankingSystem">The ranking system.</param>
        /// <param name="type">The type of results.</param>
        /// <returns>The player's results response.</returns>
        Task<PlayerResultsResponse> GetPlayerResultsAsync(int playerId, string rankingSystem, string type);

        /// <summary>
        /// Searches for players by name, country, state/province, tournament, or tournament position.
        /// </summary>
        /// <param name="name">Player name.</param>
        /// <param name="country">Country code.</param>
        /// <param name="stateprov">State or province code.</param>
        /// <param name="tournament">Tournament name.</param>
        /// <param name="tourpos">Tournament position.</param>
        /// <returns>The player search response.</returns>
        Task<PlayerSearchResponse> SearchPlayersAsync(string name = null, string country = null, string stateprov = null, string tournament = null, int? tourpos = null);

        /// <summary>
        /// Searches for directors by name, country, state/province, or city.
        /// </summary>
        /// <param name="name">Director name.</param>
        /// <param name="country">Country code.</param>
        /// <param name="stateprov">State or province code.</param>
        /// <param name="city">City name.</param>
        /// <returns>The director search response.</returns>
        Task<DirectorSearchResponse> SearchDirectorsAsync(string name = null, string country = null, string stateprov = null, string city = null);

        /// <summary>
        /// Gets tournaments for a specific director.
        /// </summary>
        /// <param name="directorId">The director's ID.</param>
        /// <returns>The director tournaments response.</returns>
        Task<DirectorTournamentsResponse> GetDirectorTournamentsAsync(int directorId);

        /// <summary>
        /// Gets global rankings for a specific system and page.
        /// </summary>
        /// <param name="system">Ranking system.</param>
        /// <param name="page">Page number.</param>
        /// <returns>The global rankings response.</returns>
        Task<RankingResponse> GetGlobalRankingsAsync(string system = "MAIN", int? page = null);

        /// <summary>
        /// Gets country rankings for a specific country, system, and page.
        /// </summary>
        /// <param name="countryCode">Country code.</param>
        /// <param name="system">Ranking system.</param>
        /// <param name="page">Page number.</param>
        /// <returns>The country rankings response.</returns>
        Task<CountryRankingResponse> GetCountryRankingsAsync(string countryCode, string system = "MAIN", int? page = null);

        /// <summary>
        /// Gets state rankings for a specific country, state/province, system, and page.
        /// </summary>
        /// <param name="countryCode">Country code.</param>
        /// <param name="stateProv">State or province code.</param>
        /// <param name="system">Ranking system.</param>
        /// <param name="page">Page number.</param>
        /// <returns>The state rankings response.</returns>
        Task<StateRankingResponse> GetStateRankingsAsync(string countryCode, string stateProv, string system = "MAIN", int? page = null);

        /// <summary>
        /// Gets region rankings for a specific region, system, and page.
        /// </summary>
        /// <param name="regionCode">Region code.</param>
        /// <param name="system">Ranking system.</param>
        /// <param name="page">Page number.</param>
        /// <returns>The region rankings response.</returns>
        Task<RegionRankingResponse> GetRegionRankingsAsync(string regionCode, string system = "MAIN", int? page = null);

        /// <summary>
        /// Gets series rankings for a specific series, year, system, and page.
        /// </summary>
        /// <param name="seriesCode">Series code.</param>
        /// <param name="year">Year.</param>
        /// <param name="system">Ranking system.</param>
        /// <param name="page">Page number.</param>
        /// <returns>The series rankings response.</returns>
        Task<SeriesRankingResponse> GetSeriesRankingsAsync(string seriesCode, int year, string system = "MAIN", int? page = null);

        /// <summary>
        /// Gets a list of series for a specific region and/or year.
        /// </summary>
        /// <param name="regionCode">Region code.</param>
        /// <param name="year">Year.</param>
        /// <returns>The series list response.</returns>
        Task<SeriesListResponse> GetSeriesListAsync(string regionCode = null, int? year = null);

        /// <summary>
        /// Gets details for a specific series and year.
        /// </summary>
        /// <param name="seriesCode">Series code.</param>
        /// <param name="year">Year.</param>
        /// <returns>The series response.</returns>
        Task<SeriesResponse> GetSeriesAsync(string seriesCode, int year);

        /// <summary>
        /// Gets global statistics for a specific system and page.
        /// </summary>
        /// <param name="system">Ranking system.</param>
        /// <param name="page">Page number.</param>
        /// <returns>The global stats response.</returns>
        Task<StatsResponse> GetGlobalStatsAsync(string system = "MAIN", int? page = null);

        /// <summary>
        /// Gets country statistics for a specific country, system, and page.
        /// </summary>
        /// <param name="countryCode">Country code.</param>
        /// <param name="system">Ranking system.</param>
        /// <param name="page">Page number.</param>
        /// <returns>The country stats response.</returns>
        Task<StatsResponse> GetCountryStatsAsync(string countryCode, string system = "MAIN", int? page = null);

        /// <summary>
        /// Gets state statistics for a specific country, state/province, system, and page.
        /// </summary>
        /// <param name="countryCode">Country code.</param>
        /// <param name="stateProv">State or province code.</param>
        /// <param name="system">Ranking system.</param>
        /// <param name="page">Page number.</param>
        /// <returns>The state stats response.</returns>
        Task<StatsResponse> GetStateStatsAsync(string countryCode, string stateProv, string system = "MAIN", int? page = null);

        /// <summary>
        /// Gets region statistics for a specific region, system, and page.
        /// </summary>
        /// <param name="regionCode">Region code.</param>
        /// <param name="system">Ranking system.</param>
        /// <param name="page">Page number.</param>
        /// <returns>The region stats response.</returns>
        Task<StatsResponse> GetRegionStatsAsync(string regionCode, string system = "MAIN", int? page = null);

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
        Task<TournamentSearchResponse> SearchTournamentsAsync(string name = null, string country = null, string stateprov = null, string city = null, int? directorId = null, int? year = null);

        /// <summary>
        /// Gets results for a specific tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament's ID.</param>
        /// <returns>The tournament results response.</returns>
        Task<TournamentResultsResponse> GetTournamentResultsAsync(int tournamentId);
    }
}