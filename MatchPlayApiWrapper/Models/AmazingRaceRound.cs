using System;
using System.Collections.Generic;

namespace MatchPlayApiWrapper.Models
{
    /// <summary>
    /// Represents a round in the Amazing Race tournament.
    /// </summary>
    public class AmazingRaceRound
    {
        /// <summary>Gets or sets the round ID.</summary>
        public int RoundId { get; set; }

        /// <summary>Gets or sets the tournament ID.</summary>
        public int TournamentId { get; set; }

        /// <summary>Gets or sets the round name.</summary>
        public string Name { get; set; }

        /// <summary>Gets or sets the round status.</summary>
        public string Status { get; set; }

        /// <summary>Gets or sets the round index.</summary>
        public int Index { get; set; }

        /// <summary>Gets or sets the creation date and time (nullable).</summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>Gets or sets the completion date and time (nullable).</summary>
        public DateTime? CompletedAt { get; set; }

        /// <summary>Gets or sets the list of games in the round.</summary>
        public List<AmazingRaceGame> Games { get; set; }
    }
}