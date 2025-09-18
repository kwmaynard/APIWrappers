using System;

namespace MatchPlayApiWrapper.Models
{
    /// <summary>
    /// Represents a queue in the Amazing Race tournament.
    /// </summary>
    public class AmazingRaceQueue
    {
        /// <summary>Gets or sets the queue ID.</summary>
        public int QueueId { get; set; }

        /// <summary>Gets or sets the tournament ID.</summary>
        public int TournamentId { get; set; }

        /// <summary>Gets or sets the arena ID (nullable).</summary>
        public int? ArenaId { get; set; }

        /// <summary>Gets or sets the player ID (nullable).</summary>
        public int? PlayerId { get; set; }

        /// <summary>Gets or sets the position in the queue (nullable).</summary>
        public int? Position { get; set; }

        /// <summary>Gets or sets the creation date and time (nullable).</summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>Gets or sets the last update date and time (nullable).</summary>
        public DateTime? UpdatedAt { get; set; }
    }
}