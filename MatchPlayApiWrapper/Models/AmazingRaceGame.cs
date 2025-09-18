using System;
using System.Collections.Generic;

namespace MatchPlayApiWrapper.Models
{
    /// <summary>
    /// Represents a game in the Amazing Race tournament.
    /// </summary>
    public class AmazingRaceGame
    {
        /// <summary>Gets or sets the game ID.</summary>
        public int GameId { get; set; }

        /// <summary>Gets or sets the round ID.</summary>
        public int RoundId { get; set; }

        /// <summary>Gets or sets the tournament ID.</summary>
        public int TournamentId { get; set; }

        /// <summary>Gets or sets the arena ID (nullable).</summary>
        public int? ArenaId { get; set; }

        /// <summary>Gets or sets the bank ID (nullable).</summary>
        public int? BankId { get; set; }

        /// <summary>Gets or sets the game index (nullable).</summary>
        public int? Index { get; set; }

        /// <summary>Gets or sets the set number (nullable).</summary>
        public int? Set { get; set; }

        /// <summary>Gets or sets the player ID with advantage (nullable).</summary>
        public int? PlayerIdAdvantage { get; set; }

        /// <summary>Gets or sets the scorekeeper ID (nullable).</summary>
        public int? ScorekeeperId { get; set; }

        /// <summary>Gets or sets the game status.</summary>
        public string Status { get; set; }

        /// <summary>Gets or sets the start date and time (nullable).</summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>Gets or sets the game duration (nullable).</summary>
        public int? Duration { get; set; }

        /// <summary>Gets or sets a value indicating whether this is a bye game.</summary>
        public bool Bye { get; set; }

        /// <summary>Gets or sets the list of player IDs.</summary>
        public List<int> PlayerIds { get; set; }

        /// <summary>Gets or sets the list of user IDs.</summary>
        public List<int> UserIds { get; set; }

        /// <summary>Gets or sets the result positions.</summary>
        public List<int> ResultPositions { get; set; }

        /// <summary>Gets or sets the result points.</summary>
        public List<string> ResultPoints { get; set; }

        /// <summary>Gets or sets the result scores (nullable).</summary>
        public List<int?> ResultScores { get; set; }

        /// <summary>Gets or sets the arena details.</summary>
        public AmazingRaceArena Arena { get; set; }

        /// <summary>Gets or sets the list of suggestions.</summary>
        public List<string> Suggestions { get; set; }
    }
}