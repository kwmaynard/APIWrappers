using System.Collections.Generic;

namespace MatchPlayApiWrapper.Models
{
    /// <summary>
    /// Represents match statistics for a player in a tournament.
    /// </summary>
    public class MatchStats
    {
        /// <summary>
        /// Gets or sets the player ID.
        /// </summary>
        public int PlayerId { get; set; }

        /// <summary>
        /// Gets or sets the number of matches played.
        /// </summary>
        public int MatchesPlayed { get; set; }

        /// <summary>
        /// Gets or sets the number of wins.
        /// </summary>
        public int Wins { get; set; }

        /// <summary>
        /// Gets or sets the number of losses.
        /// </summary>
        public int Losses { get; set; }

        /// <summary>
        /// Gets or sets the number of ties.
        /// </summary>
        public int Ties { get; set; }

        /// <summary>
        /// Gets or sets the dictionary of opponent match counts.
        /// </summary>
        public Dictionary<int, int> OpponentMatchCounts { get; set; }
    }
}