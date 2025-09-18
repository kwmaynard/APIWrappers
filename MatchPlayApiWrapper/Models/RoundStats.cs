namespace MatchPlayApiWrapper.Models
{
    /// <summary>
    /// Represents round statistics in a tournament.
    /// </summary>
    public class RoundStats
    {
        /// <summary>
        /// Gets or sets the round ID.
        /// </summary>
        public int RoundId { get; set; }

        /// <summary>
        /// Gets or sets the number of games played in the round.
        /// </summary>
        public int GamesPlayed { get; set; }

        /// <summary>
        /// Gets or sets the number of unique players in the round.
        /// </summary>
        public int UniquePlayers { get; set; }

        /// <summary>
        /// Gets or sets the total scores submitted in the round.
        /// </summary>
        public int TotalScoresSubmitted { get; set; }

        /// <summary>
        /// Gets or sets the best score in the round (nullable).
        /// </summary>
        public int? BestScore { get; set; }

        /// <summary>
        /// Gets or sets the player ID of the best score (nullable).
        /// </summary>
        public int? BestScorePlayerId { get; set; }

        /// <summary>
        /// Gets or sets the name of the best score player.
        /// </summary>
        public string BestScorePlayerName { get; set; }
    }
}