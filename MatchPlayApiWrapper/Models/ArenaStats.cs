namespace MatchPlayApiWrapper.Models
{
    /// <summary>
    /// Represents statistics for an arena in a tournament.
    /// </summary>
    public class ArenaStats
    {
        /// <summary>Gets or sets the arena ID.</summary>
        public int ArenaId { get; set; }

        /// <summary>Gets or sets the arena name.</summary>
        public string ArenaName { get; set; }

        /// <summary>Gets or sets the number of games played in the arena.</summary>
        public int GamesPlayed { get; set; }

        /// <summary>Gets or sets the number of unique players in the arena.</summary>
        public int UniquePlayers { get; set; }

        /// <summary>Gets or sets the total scores submitted in the arena.</summary>
        public int TotalScoresSubmitted { get; set; }

        /// <summary>Gets or sets the best score in the arena (nullable).</summary>
        public int? BestScore { get; set; }

        /// <summary>Gets or sets the player ID of the best score (nullable).</summary>
        public int? BestScorePlayerId { get; set; }

        /// <summary>Gets or sets the name of the best score player.</summary>
        public string BestScorePlayerName { get; set; }
    }
}