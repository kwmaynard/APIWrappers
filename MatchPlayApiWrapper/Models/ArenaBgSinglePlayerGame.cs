using System;

namespace MatchPlayApiWrapper.Models
{
    /// <summary>
    /// Represents a single player game in an arena background summary.
    /// </summary>
    public class ArenaBgSinglePlayerGame
    {
        /// <summary>Gets or sets the single player game ID.</summary>
        public int SinglePlayerGameId { get; set; }

        /// <summary>Gets or sets the arena ID.</summary>
        public int ArenaId { get; set; }

        /// <summary>Gets or sets the tournament ID.</summary>
        public int TournamentId { get; set; }

        /// <summary>Gets or sets the player ID.</summary>
        public int PlayerId { get; set; }

        /// <summary>Gets or sets the scorekeeper ID (nullable).</summary>
        public int? ScorekeeperId { get; set; }

        /// <summary>Gets or sets the status of the game.</summary>
        public string Status { get; set; }

        /// <summary>Gets or sets the points for the game.</summary>
        public string Points { get; set; }

        /// <summary>Gets or sets the score for the game.</summary>
        public int Score { get; set; }

        /// <summary>Gets or sets a value indicating whether this is the best game.</summary>
        public bool BestGame { get; set; }

        /// <summary>Gets or sets the index of the game.</summary>
        public int Index { get; set; }

        /// <summary>Gets or sets the creation date and time.</summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>Gets or sets the last update date and time.</summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>Gets or sets the card ID associated with the game.</summary>
        public int CardId { get; set; }
    }
}