using System.Collections.Generic;
using System.Threading.Tasks;
using MatchPlayApiWrapper.Models;

namespace MatchPlayApiWrapper
{
    /// <summary>
    /// Interface for MatchPlayApiClient methods.
    /// </summary>
    /// <seealso href="https://api.matchplay.com/docs">MatchPlay API Documentation</seealso>
    public interface IMatchPlayApiClient
    {
        /// <summary>
        /// Retrieves a list of all tournaments.
        /// </summary>
        /// <returns>A list of Tournament POCOs.</returns>
        Task<List<Tournament>> GetTournamentsAsync();

        /// <summary>
        /// Retrieves a specific tournament by its ID.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>A Tournament POCO.</returns>
        Task<Tournament> GetTournamentByIdAsync(int tournamentId);

        /// <summary>
        /// Retrieves Amazing Race details for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>An AmazingRace POCO.</returns>
        Task<AmazingRace> GetAmazingRaceAsync(int tournamentId);

        /// <summary>
        /// Retrieves Frenzy details for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>A Frenzy POCO.</returns>
        Task<Frenzy> GetFrenzyAsync(int tournamentId);

        /// <summary>
        /// Retrieves Max Matchplay details for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>A MaxMatchplay POCO.</returns>
        Task<MaxMatchplay> GetMaxMatchplayAsync(int tournamentId);

        /// <summary>
        /// Retrieves all single player games for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>A list of SinglePlayerGame POCOs.</returns>
        Task<List<SinglePlayerGame>> GetSinglePlayerGamesAsync(int tournamentId);

        /// <summary>
        /// Retrieves single player games as CSV for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>CSV string of single player games.</returns>
        Task<string> GetSinglePlayerGamesCsvAsync(int tournamentId);

        /// <summary>
        /// Retrieves top scores for single player games in a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>A list of TopScore POCOs.</returns>
        Task<List<TopScore>> GetSinglePlayerGamesTopScoresAsync(int tournamentId);

        /// <summary>
        /// Retrieves a single player game by its ID for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <param name="gameId">The game ID.</param>
        /// <returns>A SinglePlayerGame POCO.</returns>
        Task<SinglePlayerGame> GetSinglePlayerGameByIdAsync(int tournamentId, int gameId);

        /// <summary>
        /// Retrieves all cards for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>A list of Card POCOs.</returns>
        Task<List<Card>> GetCardsAsync(int tournamentId);

        /// <summary>
        /// Retrieves a card by its ID for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <param name="cardId">The card ID.</param>
        /// <returns>A Card POCO.</returns>
        Task<Card> GetCardByIdAsync(int tournamentId, int cardId);

        /// <summary>
        /// Retrieves all queues for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>A list of Queue POCOs.</returns>
        Task<List<Queue>> GetQueuesAsync(int tournamentId);

        /// <summary>
        /// Retrieves matchplay statistics for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>A MatchplayStats POCO.</returns>
        Task<MatchplayStats> GetMatchplayStatsAsync(int tournamentId);

        /// <summary>
        /// Retrieves round statistics for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>A list of RoundStats POCOs.</returns>
        Task<List<RoundStats>> GetRoundStatsAsync(int tournamentId);

        /// <summary>
        /// Retrieves arena statistics for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>A list of ArenaStats POCOs.</returns>
        Task<List<ArenaStats>> GetArenaStatsAsync(int tournamentId);

        /// <summary>
        /// Retrieves player statistics for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>A list of PlayerStats POCOs.</returns>
        Task<List<PlayerStats>> GetPlayerStatsAsync(int tournamentId);

        /// <summary>
        /// Retrieves match statistics for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>A list of MatchStats POCOs.</returns>
        Task<List<MatchStats>> GetMatchStatsAsync(int tournamentId);

        /// <summary>
        /// Retrieves best game statistics for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>A BestGameStats POCO.</returns>
        Task<BestGameStats> GetBestGameStatsAsync(int tournamentId);

        /// <summary>
        /// Retrieves players as CSV for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>CSV string of players.</returns>
        Task<string> GetPlayersCsvAsync(int tournamentId);

        /// <summary>
        /// Retrieves arena background summary for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>A list of ArenaBgSummary POCOs.</returns>
        Task<List<ArenaBgSummary>> GetArenaBgSummaryAsync(int tournamentId);

        /// <summary>
        /// Retrieves arena background details for a specific arena in a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <param name="arenaId">The arena ID.</param>
        /// <returns>An ArenaBgDetails POCO.</returns>
        Task<ArenaBgDetails> GetArenaBgDetailsAsync(int tournamentId, int arenaId);

        /// <summary>
        /// Retrieves all games for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>A list of Game POCOs.</returns>
        Task<List<Game>> GetGamesAsync(int tournamentId);

        /// <summary>
        /// Retrieves all games for the active or latest round in a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>A list of Game POCOs.</returns>
        Task<List<Game>> GetActiveGamesAsync(int tournamentId);

        /// <summary>
        /// Retrieves games as CSV for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>CSV string of games.</returns>
        Task<string> GetGamesCsvAsync(int tournamentId);

        /// <summary>
        /// Retrieves a game by its ID for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <param name="gameId">The game ID.</param>
        /// <returns>A Game POCO.</returns>
        Task<Game> GetGameByIdAsync(int tournamentId, int gameId);

        /// <summary>
        /// Retrieves all rounds for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>A list of Round POCOs.</returns>
        Task<List<Round>> GetRoundsAsync(int tournamentId);

        /// <summary>
        /// Retrieves all standings for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>A list of Standing POCOs.</returns>
        Task<List<Standing>> GetStandingsAsync(int tournamentId);
    }
}