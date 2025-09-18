using System;

namespace MatchPlayApiWrapper.Models
{
    /// <summary>
    /// Represents a round in a tournament.
    /// </summary>
    public class Round
    {
        /// <summary>
        /// Gets or sets the round ID.
        /// </summary>
        public int RoundId { get; set; }

        /// <summary>
        /// Gets or sets the tournament ID.
        /// </summary>
        public int TournamentId { get; set; }

        /// <summary>
        /// Gets or sets the arena ID (nullable).
        /// </summary>
        public int? ArenaId { get; set; }

        /// <summary>
        /// Gets or sets the score (nullable).
        /// </summary>
        public int? Score { get; set; }

        /// <summary>
        /// Gets or sets the index of the round.
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// Gets or sets the name of the round.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the status of the round.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the duration of the round (nullable).
        /// </summary>
        public int? Duration { get; set; }

        /// <summary>
        /// Gets or sets the creation date and time (nullable).
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the completion date and time (nullable).
        /// </summary>
        public DateTime? CompletedAt { get; set; }
    }
}