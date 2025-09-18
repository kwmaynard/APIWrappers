namespace MatchPlayApiWrapper.Models
{
    /// <summary>
    /// Represents statistics for best games in a tournament.
    /// </summary>
    public class BestGameStats
    {
        /// <summary>Gets or sets the total number of best game overall attempts.</summary>
        public int BestGameOverallAttempts { get; set; }

        /// <summary>Gets or sets the number of best game attempts on a specific arena.</summary>
        public int BestGameAttemptsOnArena { get; set; }

        /// <summary>Gets or sets the number of arenas counted for best games.</summary>
        public int BestGameArenasCounted { get; set; }

        /// <summary>Gets or sets the number of best games achieved.</summary>
        public int BestGameNumberOfBestGames { get; set; }

        /// <summary>Gets or sets suggestions related to best games.</summary>
        public string Suggestions { get; set; }
    }
}