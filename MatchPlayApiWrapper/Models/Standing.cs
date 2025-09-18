using System.Collections.Generic;

namespace MatchPlayApiWrapper.Models
{
    /// <summary>
    /// Represents a player's standing in a tournament.
    /// </summary>
    public class Standing
    {
        /// <summary>
        /// Gets or sets the player ID.
        /// </summary>
        public int PlayerId { get; set; }

        /// <summary>
        /// Gets or sets the position of the player.
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// Gets or sets the points earned by the player.
        /// </summary>
        public string Points { get; set; }

        /// <summary>
        /// Gets or sets the points with tiebreaker.
        /// </summary>
        public string PointsWithTiebreaker { get; set; }

        /// <summary>
        /// Gets or sets the number of games played.
        /// </summary>
        public int GamesPlayed { get; set; }

        /// <summary>
        /// Gets or sets the strike count.
        /// </summary>
        public int StrikeCount { get; set; }

        /// <summary>
        /// Gets or sets the adjustment value.
        /// </summary>
        public int Adjustment { get; set; }

        /// <summary>
        /// Gets or sets the number of Frenzy wins (nullable).
        /// </summary>
        public int? FrenzyWins { get; set; }

        /// <summary>
        /// Gets or sets the number of Frenzy losses (nullable).
        /// </summary>
        public int? FrenzyLosses { get; set; }

        /// <summary>
        /// Gets or sets the list of tiebreakers.
        /// </summary>
        public List<string> Tiebreakers { get; set; }

        /// <summary>
        /// Gets or sets the list of active games.
        /// </summary>
        public List<int> ActiveGames { get; set; }

        /// <summary>
        /// Gets or sets the color of the active game.
        /// </summary>
        public string ActiveGameColor { get; set; }
    }
}